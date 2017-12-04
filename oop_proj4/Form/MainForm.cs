using System;
using System.Data.Linq;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace oop_proj4
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.FormClosed += (s, e) => { Program.End(); };
            
            this.btnNew.Click += (s, e) =>
            {
                NewMemberForm NewMember = new NewMemberForm();
                NewMember.ShowDialog(NewMemberForm.NEWMEMBER);

                if (NewMember.result == System.Windows.Forms.DialogResult.OK)
                {
                    DBManager.Instance().InsertMember(NewMember.returnMember);
                    this.appendMemberToGridView(NewMember.returnMember);

                    this.grdPage.Update();
                }
            };

            this.btnEdit.Click += (s, e) =>
            {
                if (this.grdPage.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(this.grdPage.SelectedRows[0].Cells["columnId"].Value);
                    Member selectedMember = DBManager.Instance().getMember(id);
                    editNewMember(selectedMember, this.grdPage.SelectedRows[0].Index);
                }
                else
                {
                    RadMessageBox.Show("수정할 회원정보를 클릭해주세요.", "알림", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            };

            this.btnRemove.Click += (s, e) =>
            {
                DialogResult dialogResult = RadMessageBox.Show("정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = this.grdPage.Rows.Count - 1; i >= 0; i--)
                    {
                        if ((int)this.grdPage.Rows[i].Cells["columnCheckbox"].Value == 1)
                        {
                            DBManager.Instance().DeleteMember(int.Parse(this.grdPage.Rows[i].Cells["columnId"].Value.ToString()));
                            this.grdPage.Rows.RemoveAt(i);
                        }
                    }
                }
            };

            this.grdPage.CellDoubleClick += (s, e) =>
            {
                if (e.ColumnIndex == this.grdPage.Columns["columnCheckbox"].Index)
                    return;

                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    int id = Convert.ToInt32(this.grdPage.Rows[rowIndex].Cells["columnId"].Value);
                    Member selectedMember = DBManager.Instance().getMember(id);
                    editNewMember(selectedMember, rowIndex);
                }
            };

            this.grdPage.CellClick += (s, e) =>
            {
                if (e.ColumnIndex == this.grdPage.Columns["columnCheckbox"].Index)
                {
                    int rowIndex = e.RowIndex;

                    if (rowIndex < 0)
                        return;

                    int value = (int)this.grdPage.Rows[rowIndex].Cells["columnCheckbox"].Value;
                    if (value == 0)
                        this.grdPage.Rows[rowIndex].Cells["columnCheckbox"].Value = 1;
                    else
                        this.grdPage.Rows[rowIndex].Cells["columnCheckbox"].Value = 0;
                }
            };

            this.grdPage.CellPaint += (s, e) =>
            {
                if (e.Cell != null && e.Cell.RowInfo is GridViewDataRowInfo && e.Cell.ColumnInfo.Name == "columnName")
                {
                    Pen pen;
                    if (e.Cell.RowInfo.Cells["columnGender"].Value == "남자")
                    {
                        pen = Pens.Blue;
                    }
                    else
                    {
                        pen = Pens.Red;
                    }

                    using (Font font = new Font("맑은 고딕", 8))
                    {
                        e.Graphics.DrawEllipse(pen, e.Cell.RowInfo.Height / 2 - 5, e.Cell.RowInfo.Height / 2 - 5, 10, 10);
                    }    
                }
            };


            this.NewTransactionBtn.Click += (s, e) =>
            {
                NewTransactionForm NewTransaction = new NewTransactionForm();
                NewTransaction.ShowDialog(NewTransactionForm.NEWTRANSACTION);

                if (NewTransaction.result == System.Windows.Forms.DialogResult.OK)
                {
                    DBManager.Instance().InsertTransaction(NewTransaction.returnTransaction);
                    this.appendTransactionToGridView(NewTransaction.returnTransaction);

                    this.TransactionGridView.Update();
                }
            };
            
            this.EditTransactionBtn.Click += (s, e) =>
            {
                if (this.TransactionGridView.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(this.TransactionGridView.SelectedRows[0].Cells["columnId"].Value);
                    Transaction selectedTransaction = DBManager.Instance().getTransaction(id);
                    editNewTransaction(selectedTransaction, this.TransactionGridView.SelectedRows[0].Index);
                }
                else
                {
                    RadMessageBox.Show("수정할 거래내역을 클릭해주세요.", "알림", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            };

            this.DeleteTransactionBtn.Click += (s, e) =>
            {
                DialogResult dialogResult = RadMessageBox.Show("정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = this.TransactionGridView.Rows.Count - 1; i >= 0; i--)
                    {
                        if ((int)this.TransactionGridView.Rows[i].Cells["columnCheckbox"].Value == 1)
                        {
                            DBManager.Instance().DeleteTransaction(int.Parse(this.TransactionGridView.Rows[i].Cells["columnId"].Value.ToString()));
                            this.TransactionGridView.Rows.RemoveAt(i);
                        }
                    }
                }
            };

            this.TransactionGridView.CellDoubleClick += (s, e) =>
            {
                if (e.ColumnIndex == this.TransactionGridView.Columns["columnCheckbox"].Index)
                    return;

                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    int id = Convert.ToInt32(this.TransactionGridView.Rows[rowIndex].Cells["columnId"].Value);
                    Transaction selectedTransaction = DBManager.Instance().getTransaction(id);
                    editNewTransaction(selectedTransaction, rowIndex);
                }
            };

            this.TransactionGridView.CellClick += (s, e) =>
            {
                if (e.ColumnIndex == this.TransactionGridView.Columns["columnCheckbox"].Index)
                {
                    int rowIndex = e.RowIndex;

                    if (rowIndex < 0)
                        return;

                    int value = (int)this.TransactionGridView.Rows[rowIndex].Cells["columnCheckbox"].Value;
                    if (value == 0)
                        this.TransactionGridView.Rows[rowIndex].Cells["columnCheckbox"].Value = 1;
                    else
                        this.TransactionGridView.Rows[rowIndex].Cells["columnCheckbox"].Value = 0;
                }
            };

            this.pageLogout.Paint += (s, e) =>
            {
                Program.End();
            };

            this.EditAdminBtn.Click += (s, e) =>
            {
                EditAdminForm editAdminForm = new EditAdminForm();
                editAdminForm.ShowDialog();
            };
            this.NewAdminBtn.Click += (s, e) =>
            {
                 NewAdminForm newAdminForm = new NewAdminForm();
                 newAdminForm.ShowDialog();
                 this.AdminListView.DataSource = DBManager.Instance().GetAdminIdList();
            };
            this.DeleteAminBtn.Click += (s, e) =>
            {
                if( this.AdminListView.Items.Count != 1)
                {
                    DeleteAdminForm deleteAdminForm = new DeleteAdminForm(this.AdminListView.SelectedItem.Text);
                    deleteAdminForm.ShowDialog();
                    this.AdminListView.DataSource = DBManager.Instance().GetAdminIdList();
                }
                else
                {
                    RadMessageBox.SetThemeName(this.ThemeName);
                    RadMessageBox.Show("마지막 관리자를 삭제할 수 없습니다", "Delete", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            };
            this.MemberStatisticPage.Paint += (s, e) =>
            {
                this.MemberStatisticGenderChart.Series.Clear();
                this.MemberStatisticAgeChart.Series.Clear();
                this.MemberStatisticGenderChart.Series.Add(DBManager.Instance().GetGenderPieSeries());
                this.MemberStatisticAgeChart.Series.Add(DBManager.Instance().GetAgeGroupPieSeries());
            };

            this.YearStatisticPage.Paint += (s, e) =>
            {
                this.YearlyStatisticsMembersChart.Series.Clear();
                this.YearlyStatisticsMoneyChart.Series.Clear();
                this.YearlyStatisticsMembersChart.Series.Add(DBManager.Instance().GetAccMemberLineSeries(2017));
                this.YearlyStatisticsMoneyChart.Series.Add(DBManager.Instance().GetNewMemberLineSeries(2017));
            };

            this.StatisticsAccountPage.Paint += (s, e) =>
            {
                this.YearlyMoneyChart.Series.Clear();
                this.MonthlyMoneyDiffChart.Series.Clear();
                this.YearlyMoneyChart.Series.Add(DBManager.Instance().GetTotalAmountLineSeries(2017));
                this.MonthlyMoneyDiffChart.Series.Add(DBManager.Instance().GetMonOverAmountLineSeries(2017));

            };

            this.AdminListView.DataSource = DBManager.Instance().GetAdminIdList();

            Table<Member> members = DBManager.Instance().GetTable<Member>();
            foreach (Member member in members)
            {
                this.appendMemberToGridView(member);
            }
            this.grdPage.BestFitColumns();

            Table<Transaction> transactions = DBManager.Instance().GetTable<Transaction>();
            foreach (Transaction transaction in transactions)
            {
                this.appendTransactionToGridView(transaction);
            }
            this.TransactionGridView.BestFitColumns();

            ConditionalFormattingObject obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "남자", "", true);
            obj.CellForeColor = Color.Blue;
            this.grdPage.Columns["columnGender"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "여자", "", true);
            obj.CellForeColor = Color.Red;
            this.grdPage.Columns["columnGender"].ConditionalFormattingObjectList.Add(obj);
            
            obj = new ConditionalFormattingObject("StateFormat", ConditionTypes.Equal, "정지", "", true);
            obj.CellForeColor = Color.Silver;
            this.grdPage.Columns["columnRegistrationState"].ConditionalFormattingObjectList.Add(obj);   

            obj = new ConditionalFormattingObject("StateFormat", ConditionTypes.Equal, "탈퇴", "", true);
            obj.RowBackColor = Color.PaleVioletRed;
            this.grdPage.Columns["columnRegistrationState"].ConditionalFormattingObjectList.Add(obj);

            ConditionalFormattingObject transactionObj = new ConditionalFormattingObject("In/OutcomeFormat", ConditionTypes.Equal, "수입", "", true);
            transactionObj.CellForeColor = Color.Blue;
            this.TransactionGridView.Columns["columnType"].ConditionalFormattingObjectList.Add(transactionObj);

            transactionObj = new ConditionalFormattingObject("In/OutcomeFormat", ConditionTypes.Equal, "지출", "", true);
            transactionObj.CellForeColor = Color.Red;
            this.TransactionGridView.Columns["columnType"].ConditionalFormattingObjectList.Add(transactionObj);

            transactionObj = new ConditionalFormattingObject("PayMethodFormat", ConditionTypes.Equal, "카드", "", true);
            transactionObj.RowBackColor = Color.Wheat;
            this.TransactionGridView.Columns["columnPayMethod"].ConditionalFormattingObjectList.Add(transactionObj);

            transactionObj = new ConditionalFormattingObject("In/OutcomeFormat", ConditionTypes.Equal, "현금", "", true);
            transactionObj.RowBackColor = Color.LightCoral;
            this.TransactionGridView.Columns["columnPayMethod"].ConditionalFormattingObjectList.Add(transactionObj);
        }

        private void editNewMember(Member selectedMember, int rowIndex)
        {
            NewMemberForm editMember = new NewMemberForm();
            editMember.ShowDialog(NewMemberForm.EDITMEMBER, selectedMember);

            if (editMember.result == System.Windows.Forms.DialogResult.OK)
            {
                DBManager.Instance().UpdateMember(editMember.returnMember);
                this.updateMemberToGridView(editMember.returnMember, rowIndex);
            }
        }

        
        private object[] getRowDataFromMember(Member member)
        {
            return new object[] {
                    0
                    , member.Id // 숨김
                    , member.Name
                    , member.Tel
                    , member.ToStringGender()
                    , member.ToStringRegistrationState()
                    , member.EndDate.ToShortDateString()
                    , member.RegisterationDate.ToShortDateString()
                    , member.Point
                    , member.Memo
                };
        }
        private void appendMemberToGridView(Member member)
        {
            this.grdPage.Rows.Add(this.getRowDataFromMember(member));
        }
        private void updateMemberToGridView(Member member, int rowIndex)
        {
            object[] rowdata = this.getRowDataFromMember(member);
            for (int i = 0; i < rowdata.Length; i++)
                this.grdPage.Rows[rowIndex].Cells[i].Value = rowdata[i];
        }

        private void editNewTransaction(Transaction selectedTransacton, int rowIndex)
        {
            NewTransactionForm editTransaction = new NewTransactionForm();
            editTransaction.ShowDialog(NewTransactionForm.EDITTRANSACTION, selectedTransacton);

            if (editTransaction.result == System.Windows.Forms.DialogResult.OK)
            {
                DBManager.Instance().UpdateTransaction(editTransaction.returnTransaction);
                this.updateTransactionToGridView(editTransaction.returnTransaction, rowIndex);
            }
        }

        private object[] getRowDataFromTransaction(Transaction transaction)
        {
            return new object[] {
                 0,
                transaction.Id,
                transaction.ToStringDate(),
                DBManager.Instance().getMember(transaction.MemberId).Name,
                transaction.ToStringAmount(),
                transaction.ToStringType(),
                transaction.ToStringPayMethod(),
                transaction.Memo
            };
        }
        private void appendTransactionToGridView(Transaction transaction)
        {
            this.TransactionGridView.Rows.Add(this.getRowDataFromTransaction(transaction));
        }
        private void updateTransactionToGridView (Transaction transaction, int rowIndex)
        {
            object[] rowdata = this.getRowDataFromTransaction(transaction);
            for (int i = 0; i < rowdata.Length; i++)
                this.TransactionGridView.Rows[rowIndex].Cells[i].Value = rowdata[i];
        }
    }
}
