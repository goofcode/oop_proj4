using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace oop_proj4
{
    public partial class NewTransactionForm : Telerik.WinControls.UI.RadForm
    {
        public const int NEWTRANSACTION = 1;
        public const int EDITTRANSACTION = 2;

        public Transaction returnTransaction { get; set; }
        public DialogResult result { get; set; }
        public int type { get; set; }

        public NewTransactionForm()
        {
            InitializeComponent();

            this.btnApply.Click += (s, e) =>
            {
                this.result = DialogResult.OK;

                if (this.type == NEWTRANSACTION)
                {
                    this.returnTransaction = new Transaction();
                }

                this.returnTransaction.Id = int.Parse(this.txtId.Text);
                this.returnTransaction.MemberId = (int)this.ddlName.SelectedItem.Tag;
                this.returnTransaction.Amount = int.Parse(this.txtAmount.Text);
                this.returnTransaction.Date = this.dtpDate.Value;
                this.returnTransaction.Type = int.Parse(this.ddlType.SelectedItem.Tag.ToString());
                this.returnTransaction.PayMethod = int.Parse(this.ddlPay.SelectedItem.Tag.ToString());
                this.returnTransaction.Memo = this.txtMemo.Text;

                this.Close();
            };

            this.btnCancel.Click += (s, e) =>
            {
                this.result = DialogResult.Cancel;
                this.Close();
            };

            this.Load += (s, e) =>
            {
                if (this.type == NEWTRANSACTION)
                {
                    this.txtId.Text = DBManager.Instance().getAutoIncrementIDWithTrasaction().ToString();
                    this.ddlType.SelectedIndex = 0;
                    this.ddlPay.SelectedIndex = 0;
                }

                getNameFromDatabase();

                this.dtpDate.MaxDate = Telerik.WinControls.UI.RadDateTimePicker.MaximumDateTime;
                this.dtpDate.Value = System.DateTime.Now;
            };
        }

        public void ShowDialog(int type)
        {
            this.type = type;

            this.ShowDialog();
        }

        public void ShowDialog(int type, Transaction transaction)
        {
            this.type = type;

            this.returnTransaction = transaction;

            if (this.type == EDITTRANSACTION)
            {
                this.txtId.Text = this.returnTransaction.Id.ToString();
                this.dtpDate.Value = this.returnTransaction.Date;
                this.txtAmount.Text = this.returnTransaction.Amount.ToString();

                for (int i = 0; i < this.ddlType.Items.Count; i++)
                {
                    if (int.Parse(this.ddlType.Items[i].Tag.ToString()) == this.returnTransaction.Type)
                    {
                        this.ddlType.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < this.ddlPay.Items.Count; i++)
                {
                    if (int.Parse(this.ddlPay.Items[i].Tag.ToString()) == this.returnTransaction.PayMethod)
                    {
                        this.ddlPay.SelectedIndex = i;
                    }
                }

                this.txtMemo.Text = this.returnTransaction.Memo;

                this.btnApply.Text = "적용";
            }

            this.ShowDialog();
        }

        private void getNameFromDatabase()
        {
            System.Data.Linq.Table<Member> members = DBManager.Instance().GetTable<Member>();
            foreach (Member member in members)
            {
                this.ddlName.Items.Add(member.Name);
                this.ddlName.Items[this.ddlName.Items.Count - 1].Tag = member.Id;
               
                if (this.type == EDITTRANSACTION)
                {
                    if (this.returnTransaction.MemberId == member.Id)
                    {
                        this.ddlName.SelectedIndex = this.ddlName.Items.Count - 1;
                    }
                }
            }

            if (this.type == NEWTRANSACTION) {
                if (this.ddlName.Items.Count > 0)
                {
                    this.ddlName.SelectedIndex = 0;
                }
            }
        }
    }
}
