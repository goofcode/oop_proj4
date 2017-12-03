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
                NewMember NewMember = new NewMember();
                NewMember.ShowDialog(NewMember.NEWMEMBER);

                if (NewMember.result == System.Windows.Forms.DialogResult.OK)
                {
                    DBManager.Instance().InsertMember(NewMember.returnMember);
                    this.appendMemberToGridView(NewMember.returnMember);

                    this.grdPage.Update();
                }
            };

            this.btnEdit.Click += (s, e) =>
            {
                int id = Convert.ToInt32(this.grdPage.SelectedRows[0].Cells["columnId"].Value);
                Member selectedMember = DBManager.Instance().getMember(id);
                editNewMember(selectedMember, this.grdPage.SelectedRows[0].Index);
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

            this.btnRemove.Click += (s, e) =>
            {
                DialogResult dialogResult = RadMessageBox.Show("정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = this.grdPage.Rows.Count - 1; i >= 0; i--)
                    {
                        if ((int)this.grdPage.Rows[i].Cells["columnCheckbox"].Value == 1)
                        {
                            this.grdPage.Rows.RemoveAt(i);
                        }
                    }
                }
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

            ConditionalFormattingObject obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "남자", "", true);
            obj.CellForeColor = System.Drawing.Color.Blue;
            this.grdPage.Columns["columnGender"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "여자", "", true);
            obj.CellForeColor = System.Drawing.Color.Red;
            this.grdPage.Columns["columnGender"].ConditionalFormattingObjectList.Add(obj);
            
            obj = new ConditionalFormattingObject("StateFormat", ConditionTypes.Equal, "정지", "", true);
            obj.CellForeColor = Color.Silver;
            this.grdPage.Columns["columnRegistrationState"].ConditionalFormattingObjectList.Add(obj);   

            obj = new ConditionalFormattingObject("StateFormat", ConditionTypes.Equal, "탈퇴", "", true);
            obj.RowBackColor = System.Drawing.Color.PaleVioletRed;
            this.grdPage.Columns["columnRegistrationState"].ConditionalFormattingObjectList.Add(obj);
        }

        private void editNewMember(Member selectedMember, int rowIndex)
        {
            NewMember editMember = new NewMember();
            editMember.ShowDialog(NewMember.EDITMEMBER, selectedMember);

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
                    , member.EndDate
                    , member.RegisterationDate
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
    }
}
