using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace oop_proj4
{
    public partial class NewMember : Telerik.WinControls.UI.RadForm
    {
        public Member returnMember { get; set; }
        public DialogResult result { get; set; }
        public int type { get; set; }

        public NewMember()
        {
            InitializeComponent();

            this.btnApply.Click += (s, e) =>
            {
                this.result = DialogResult.OK;

                if (this.type == 1)
                {
                    this.returnMember = new Member();
                }

                this.returnMember.Id = int.Parse(txtId.Text);
                this.returnMember.Name = txtName.Text;
                this.returnMember.Tel = txtTel.Text;
                this.returnMember.Gender = int.Parse(txtGender.Text);
                this.returnMember.BirthDate = dtpBirth.Value;
                this.returnMember.RegisterationState = int.Parse(txtState.Text);
                this.returnMember.LeftDay = int.Parse(txtLeftDay.Text);
                this.returnMember.Memo = txtMemo.Text;

                this.Close();
            };

            this.btnCancel.Click += (s, e) =>
            {
                this.result = DialogResult.Cancel;
                this.Close();
            };
        }

        public void ShowDialog(int type)
        {
            this.type = type;

            this.ShowDialog();
        }

        public void ShowDialog(int type, Member member)
        {
            this.type = type;

            this.returnMember = member;

            if (this.type == 2)
            {
                this.txtId.Text = this.returnMember.Id.ToString();
                this.txtName.Text = this.returnMember.Name;
                this.txtTel.Text = this.returnMember.Tel;
                this.txtGender.Text = this.returnMember.Gender.ToString();
                this.txtState.Text = this.returnMember.RegisterationState.ToString();
                this.dtpBirth.Value = this.returnMember.BirthDate;
                this.txtLeftDay.Text = this.returnMember.LeftDay.ToString();
                this.txtMemo.Text = this.returnMember.Memo;

                this.btnApply.Text = "적용";
            }

            this.ShowDialog();
        }
    }
}
