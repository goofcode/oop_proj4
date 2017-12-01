using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Telerik.Charting;
using Telerik.WinControls.UI;
using System;
using System.Windows.Forms;

namespace oop_proj4
{
    /// <summary>
    /// DB를 관리하는 singleton 클래스입니다.
    /// </summary>
    [Database]
    class DBManager : DataContext
    {
        // singleton pattern 
        private static DBManager _instance;
        private DBManager(SQLiteConnection conn) : base(conn) { }
        public static DBManager Instance()
        {
            if (_instance == null)
            {
                string dbPath = "database.db";
                string connString = @"Data Source=" + dbPath;

                // exit if db not exists
                if (!File.Exists(dbPath))
                {
                    MessageBox.Show("DataBase Not Found!");
                    Application.Exit();
                }
                else _instance = new DBManager(new SQLiteConnection(connString));

            }
            return _instance;
        }

        private string GetMD5HashString(string str)
        {
            byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++) sBuilder.Append(data[i].ToString("x2"));
            return sBuilder.ToString();
        }

        /// <summary>
        /// Create tables in case of db not found
        /// * This method needs to be fixed on deployment
        /// </summary>        
        /// <summary>
        /// checks if given id and pw are valid or not
        /// </summary>
        /// <param name="id">Admin ID</param>
        /// <param name="pw">Admin PW</param>
        /// <returns></returns>
        public bool CheckAdmin(string id, string pw)
        {
            // grab Admin table
            Table<Admin> Admins = _instance.GetTable<Admin>();

            // select with given id and pw
            string pwhash = GetMD5HashString(pw);
            var query = from cust in Admins
                        where cust.Admin_id == id && cust.Admin_pw == pwhash
                        select cust;

            if (query.Count() == 0)
                return false;

            return true;
        }

        public void insertMember(Member member)
        {
            var query = "INSERT INTO Member VALUES (" + member.Id + ", '" + member.Name + "', '" + member.Tel + "', " + member.Gender + ", '1997-12-23 00:00:00', " + member.RegisterationState + ", 30, '" + member.Memo + "')";
            _instance.ExecuteCommand(query);
        }

        public void updateMember(Member member)
        {
            var query = "UPDATE Member SET Name = '" + member.Name + "', Tel = '" + member.Tel + "', Gender = " + member.Gender + ", BirthDate = '" + member.BirthDate.ToShortDateString() + "', RegisterationState = " + member.RegisterationState + ", LeftDay = " + member.LeftDay + ", Memo = '" + member.Memo + "' WHERE Id = " + member.Id;
            _instance.ExecuteCommand(query);
        }

        public PieSeries GetGenderPieSeries()
        {
            Table<Member> members = _instance.GetTable<Member>();

            var male_count = (from member in members
                              where member.Gender == 1
                              select member).Count();
            var female_count = (from member in members
                                where member.Gender == 2
                                select member).Count();

            PieSeries series = new PieSeries();
            series.DataPoints.Add(new PieDataPoint(male_count, "남"));
            series.DataPoints.Add(new PieDataPoint(female_count, "여"));
            series.ShowLabels = true;
            series.DisplayMember = "남";
            return series;

       
        }

        public int GetAge(Member member)
        {

            var today = DateTime.Today;
            var age = today.Year - member.BirthDate.Year;
            if (member.BirthDate > today.AddYears(-age)) age--;
            return age;
        }
        public PieSeries GetAgeGroupPieSeries()
        {
            Table<Member> members = _instance.GetTable<Member>();

            string[] legendname = {"10 대 이하","10 대","20 대","30 대", "40 대", "50 대", "60 대 이상"};

            int[] ageGroup = new int[7];
            
            foreach(Member member in members)
            {
                int age = GetAge(member);
                ageGroup[(age < 70) ? age / 10 : 6]++;
            }

            PieSeries series = new PieSeries();
            for (int i = 0; i < 7; i++)
                series.DataPoints.Add(new PieDataPoint(ageGroup[i], legendname[i]));
            return series;
            
        }

        public int GetAccMemCount(DateTime compareDate)
        {
            Table<Member> members = _instance.GetTable<Member>();
            return (from member in members
                    where member.RegisterationDate < compareDate
                    select member).Count();
        }
        public LineSeries GetAccMemberLineSeries(int year)
        {
            Table<Member> members = _instance.GetTable<Member>();
            DateTime date = new DateTime(year, 2, 1);

            string[] Months = { " ", "1 월", "2 월", "3 월", "4 월", "5 월", "6 월", "7 월", "8 월", "9 월", "10 월", "11 월", "12 월" };
            int[] MonthMemCount = new int[13];

            for (int i = 1; i <= 12; i++)
            {
                MonthMemCount[i] = GetAccMemCount(date);
                date.AddMonths(1);

            }
            LineSeries series = new LineSeries();
            for (int i = 1; i <= 12; i++)
            {
                series.DataPoints.Add(new CategoricalDataPoint(MonthMemCount[i], Months[i]));
            }
            series.ShowLabels = true;
            return series;
        }

        public int GetNewMemCount(DateTime compareDate)
        {
            Table<Member> members = _instance.GetTable<Member>();
            return (from member in members
                    where member.RegisterationDate.Year == compareDate.Year && member.RegisterationDate.Month == member.RegisterationDate.Month
                    select member).Count();
        }
        public LineSeries GetNewMemberLineSeries(int year)
        {
            Table<Member> members = _instance.GetTable<Member>();
            DateTime date = new DateTime(year, 2, 1);

            string[] Months = { " ", "1 월", "2 월", "3 월", "4 월", "5 월", "6 월", "7 월", "8 월", "9 월", "10 월", "11 월", "12 월" };
            int[] MonthNewMemCount = new int[13];

            for (int i = 1; i <= 12; i++)
            {
                MonthNewMemCount[i] = GetNewMemCount(date);
                date.AddMonths(1);

            }
            LineSeries series = new LineSeries();
            for (int i = 1; i <= 12; i++)
            {
                series.DataPoints.Add(new CategoricalDataPoint(MonthNewMemCount[i], Months[i]));
            }
            series.ShowLabels = true;
            return series;
        }
    }
}
