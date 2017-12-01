using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace oop_proj4
{
    /// <summary>
    /// DB를 관리하는 singleton 클래스입니다.
    /// </summary>
    [Database]
    class DBManager : DataContext
    {
        public enum RegisterationState {active};


        // singleton pattern 
        private static DBManager _instance;
        private DBManager(SQLiteConnection conn) : base(conn) { }
        public static DBManager Instance()
        {
            if (_instance == null)
            {
                string dbPath = "database.db";
                string connString = @"Data Source=" + dbPath;

                // create database file if not exists
                if (!File.Exists(dbPath))
                {
                    _instance = new DBManager(new SQLiteConnection(connString));
                    _instance.InitDB();
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
        private void InitDB()
        {
            // create and set admin
            string create_admin_tabe = "CREATE TABLE Admin(" +
                                       "`Id`            INTEGER         NOT NULL    PRIMARY KEY     AUTOINCREMENT, " +
                                       "`Admin_id`      VARCHAR(50)     NOT NULL, " +
                                       "`Admin_pw`      VARCHAR(128)     NOT NULL" +
                                       ")";
            string dev_admin_insert = "INSERT INTO Admin VALUES (0, 'dev', '" + GetMD5HashString("dev") + "')";

            // create and set member
            string create_member_table = "CREATE TABLE Member( " +
                                         "`Id`                  INTEGER         NOT NULL    PRIMARY KEY     AUTOINCREMENT, " +
                                         "`Name`                VARCHAR( 50 )   NOT NULL, " +
                                         "`Tel`                 VARCHAR( 50 )   NOT NULL, " +
                                         "`Gender`              INTEGER         NOT NULL, " +
                                         "`BirthDate`           DATE            NOT NULL, " +
                                         "`RegisterationState`  INTEGER         NOT NULL, " +
                                         "`LeftDay`             INTEGER         NOT NULL, " +
                                         "`Memo`                TEXT " +
                                         ")";
            string[] insert_members = { "INSERT INTO Member VALUES (1, '미필띠후', '010-1234-5678', 1, '1997-12-23', 0, 30, 'aka 산업띠후')",
                                        "INSERT INTO Member VALUES (2, '한주임', '010-1234-5678', 1, '1993-03-24', 0, 330, NULL)",
                                        "INSERT INTO Member VALUES (3, '한대리', '010-1234-5678', 2, '1997-11-12', 2, 30, NULL)",
                                        "INSERT INTO Member VALUES (4, '지사장', '010-1234-5678', 1, '1995-11-28', 1, 123, NULL)" };

            string create_transaction_table = "CREATE TABLE Transaction( " +
                 "`Id`                  INTEGER         NOT NULL    PRIMARY KEY     AUTOINCREMENT, " +
                 "`MemberId             INTEGER         NOT NULL, " +
                 "`Date`                DATE            NOT NULL, " +
                 "`Type`                INTEGER         NOT NULL, " +   
                 "`PayMethod`           INTEGER         NOT NULL, " +
                 "`Memo`                TEXT " +
                 ")";

            string[] insert_transactions = { "INSERT INTO Member VALUES (1, '1', '1997-12-23', 0, 0, NULL)",
                                            "INSERT INTO Member VALUES (2, '2', '1993-03-24', 0, 1, NULL)",
                                            "INSERT INTO Member VALUES (3, '1', '1997-11-12', 2, 2, NULL)",
                                            "INSERT INTO Member VALUES (4, '3', '1995-11-28', 1, 1, NULL)" };


            _instance.ExecuteCommand(create_admin_tabe);
            _instance.ExecuteCommand(create_member_table);
            _instance.ExecuteCommand(create_transaction_table);

            _instance.ExecuteCommand(dev_admin_insert);
            foreach (string insert_member in insert_members){
                _instance.ExecuteCommand(insert_member);
            }
            foreach (string insert_transaction in insert_transactions){
                _instance.ExecuteCommand(insert_transaction);
            }
        }

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

        public Table<Member> GetAllMember() { return _instance.GetTable<Member>();}
    }
}
