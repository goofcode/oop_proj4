using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Configuration;
using System.Windows.Forms;

namespace oop_proj4
{
    /// <summary>
    /// DB를 관리하는 singleton 클래스입니다.
    /// </summary>
    [Database]
    class DBManager:DataContext
    {
        private static DBManager _instance;

        // classes can be mapped to table so that enable to use LINQ
        [Table(Name = "Admin")] public class Admin
        {
            [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }
            [Column] public string Admin_id { get; set; }
            [Column] public string Admin_pw { get; set; }
        }
        [Table(Name = "Member")] public class Member
        {
            [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }
            [Column] public string Name { get; set; }
            [Column] public int Gender { get; set; }
            [Column] public DateTime BirthDate{ get; set; }
            [Column] public int RegisterationState { get; set; }
            [Column] public int LeftDay { get; set; }
            [Column] public string Memo{ get; set; }
        }

        // singleton pattern constructor and instance method
        private DBManager():base(ConfigurationManager.ConnectionStrings["db"].ToString()){}
        public static DBManager Instance()
        {
            if (_instance == null) _instance = new DBManager();
            return _instance;
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
