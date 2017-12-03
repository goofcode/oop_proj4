using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Telerik.Charting;
using Telerik.WinControls.UI;
using System;
using System.Windows.Forms;
using System.Collections;

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
                string dbPath = "..\\..\\database.db";
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
        public void AddMember(Member member)
        {
            var query = "INSERT INTO Member VALUES (" + member.Id + ", '" + member.Name + "', '" + member.Tel + "', " + member.Gender + ", '1997-12-23 00:00:00', " + member.RegisterationState + ", 30, '" + member.Memo + "')";
            _instance.ExecuteCommand(query);
        }
        public void UpdateMember(Member member)
        {
            var query = "UPDATE Member SET Name = '" + member.Name + "', Tel = '" + member.Tel + "', Gender = " + member.Gender + ", BirthDate = '" + member.BirthDate.ToShortDateString() + "', RegisterationState = " + member.RegisterationState + ", LeftDay = " + member.LeftDay + ", Memo = '" + member.Memo + "' WHERE Id = " + member.Id;
            _instance.ExecuteCommand(query);
        }
        public void UpdateAdminPW(string pw)
        {
            string pwhash = GetMD5HashString(pw);
            var query = "UPDATE Admin SET Admin_pw = '" + pwhash + "' WHERE Admin_id = '" + Program.AdminId + "'";
            _instance.ExecuteCommand(query);
        }
        public bool IsAdminExist(string id)
        {
            Table<Admin> Admins = _instance.GetTable<Admin>();
            int admin_num = (from admin in Admins
                             where admin.Admin_id == id
                             select admin).Count();
            if (admin_num == 0) return false;
            return true;
        }
        public void AddAdmin(string id, string pw)
        {
            var query = "INSERT INTO Admin (Admin_id, Admin_pw) " +
                "VALUES ('" + id + "', '" + GetMD5HashString(pw) + "')";
            _instance.ExecuteCommand(query);
        }
        public void DeleteAdmin(string id)
        {
            var query = "DELETE FROM Admin " +
    "WHERE Admin_id = '" + id + "'";
            _instance.ExecuteCommand(query);
        }

        public ArrayList GetAdminIdList()
        {
            ArrayList adminIdList = new ArrayList();
            Table<Admin> admins = _instance.GetTable<Admin>();
            foreach(Admin admin in admins)
                adminIdList.Add(admin.Admin_id);
            
            return adminIdList;
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

            string[] legendname = {"10 대 이하","10 대","20 대","30 대", "40 대", "50 대 이상"};

            int[] ageGroup = new int[6];
            
            foreach(Member member in members)
            {
                int age = GetAge(member);
                ageGroup[(age < 50) ? age / 10 : 5]++;
            }

            PieSeries series = new PieSeries();
            for (int i = 0; i < 6; i++)
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

            int count = 0;
            foreach(Member mem in members)
            {
                if (mem.RegisterationDate.Year == compareDate.Year && mem.RegisterationDate.Month == compareDate.Month) count++;
            }
            return count;
        }
        public LineSeries GetNewMemberLineSeries(int year)
        {
            Table<Member> members = _instance.GetTable<Member>();
            DateTime date = new DateTime(year, 1, 1);

            string[] Months = { " ", "1 월", "2 월", "3 월", "4 월", "5 월", "6 월", "7 월", "8 월", "9 월", "10 월", "11 월", "12 월" };
            int[] MonthNewMemCount = new int[13];

            for (int i = 1; i <= 12; i++)
            {
                MonthNewMemCount[i] = GetNewMemCount(date.AddMonths(i-1));
            }
            LineSeries series = new LineSeries();
            for (int i = 1; i <= 12; i++)
            {
                series.DataPoints.Add(new CategoricalDataPoint(MonthNewMemCount[i], Months[i]));
            }
            series.ShowLabels = true;
            return series;
        }

        public int GetMonTotalAmount(DateTime compareDate)
        {
            Table<Transaction> transactions = _instance.GetTable<Transaction>();

            int sum = 0;
            foreach(Transaction t in transactions)
                if (t.Date.Year == compareDate.Year && t.Date.Month == compareDate.Month) sum+=t.Amount;
            return sum;
        }
        public LineSeries GetTotalAmountLineSeries(int year)
        {
            Table<Transaction> members = _instance.GetTable<Transaction>();
            DateTime date = new DateTime(year, 1, 1);

            string[] Months = { " ", "1 월", "2 월", "3 월", "4 월", "5 월", "6 월", "7 월", "8 월", "9 월", "10 월", "11 월", "12 월" };
            int[] MonthAmount = new int[13];

            for (int i = 1; i <= 12; i++)
            {
                MonthAmount[i] = GetMonTotalAmount(date);
                date = date.AddMonths(1);
            }
            LineSeries series = new LineSeries();
            for (int i = 1; i <= 12; i++)
            {
                series.DataPoints.Add(new CategoricalDataPoint(MonthAmount[i], Months[i]));
            }
            series.ShowLabels = true;
            return series;
        }

        public int GetMonOverMonAmount(DateTime Date)
        {
            return GetMonTotalAmount(Date) - GetMonTotalAmount(Date.AddMonths(-1));
        }
        public LineSeries GetMonOverAmountLineSeries(int year)
        {
            Table<Transaction> members = _instance.GetTable<Transaction>();
            DateTime date = new DateTime(year, 1, 1);

            string[] Months = { " ", "1 월", "2 월", "3 월", "4 월", "5 월", "6 월", "7 월", "8 월", "9 월", "10 월", "11 월", "12 월" };
            int[] monOverAmount = new int[13];

            for (int i = 1; i <= 12; i++)
            {
                monOverAmount[i] = GetMonOverMonAmount(date);
                date = date.AddMonths(1);
            }
            LineSeries series = new LineSeries();
            for (int i = 1; i <= 12; i++)
            {
                series.DataPoints.Add(new CategoricalDataPoint(monOverAmount[i], Months[i]));
            }
            series.ShowLabels = true;
            return series;
        }
    }
}
