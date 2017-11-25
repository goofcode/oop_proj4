using System;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Configuration;
using System.Data.SQLite;
using System.IO;

namespace oop_proj4
{
    /// <summary>
    /// DB를 관리하는 singleton 클래스입니다.
    /// </summary>
    [Database]
    class DBManager : DataContext
    {
        private static DBManager _instance;

        // singleton pattern constructor and instance method
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

        /// <summary>
        /// Create tables in case of db not found
        /// </summary>
        private void InitDB()
        {
            string admin_table = "CREATE TABLE Admin(Id integer primary key not null, Admin_id varchar(50) not null, Admin_pw varchar(50) not null)";
            string admin_insert = "INSERT INTO Admin VALUES (0, 'dev', 'dev')";
            _instance.ExecuteCommand(admin_table);
            _instance.ExecuteCommand(admin_insert);

            string member_table = "CREATE TABLE Member( `Id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `Name` varchar ( 50 ) NOT NULL, `Gender` intEGER NOT NULL, `BirthDate` date NOT NULL, `RegisterationState` INTEGER NOT NULL, `LeftDay` INTEGER NOT NULL, `Memo` TEXT )";
            _instance.ExecuteCommand(member_table);
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
            var query = from cust in Admins
                        where cust.Admin_id == id && cust.Admin_pw == pw
                        select cust;

            if (query.Count() == 0)
                return false;

            return true;
        }
    }
}
