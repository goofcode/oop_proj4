using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oop_proj4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += (s, e) => { this.DBGrid.DataSource = DBManager.Instance().GetTable<Member>(); };
            this.FormClosed += (s, e) => { Program.End(); };
        }
    }
}
