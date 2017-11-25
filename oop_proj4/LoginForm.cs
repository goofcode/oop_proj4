using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace oop_proj4
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            this.LoginBtn.Click += (s, e) => 
            {
                // if succeed to login, start main form
                if (DBManager.Instance().CheckAdmin(this.IDTxt.Text, this.PWTxt.Text))
                {
                    Program.ShowMainForm();
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong ID or PW");
            };
            this.FormClosed += (s, e) => { Program.End(); };
        }
    }
}
