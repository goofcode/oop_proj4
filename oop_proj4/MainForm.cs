﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_proj4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += (s, e) => { this.memberTableAdapter.Fill(this.databaseDataSet.Member); };
            this.FormClosed += (s, e) => { Program.End(); };
        }
    }
}
