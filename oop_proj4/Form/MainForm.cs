using System.Data.Linq;
using System.Drawing;
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
                NewMember.ShowDialog(1);

                if (NewMember.result == System.Windows.Forms.DialogResult.OK)
                {
                    DBManager.Instance().insertMember(NewMember.returnMember);
                    this.grdPage.Rows.Add(NewMember.returnMember.Name,
                                     NewMember.returnMember.Tel,
                                     NewMember.returnMember.Gender,
                                     NewMember.returnMember.BirthDate.ToShortDateString(),
                                     NewMember.returnMember.RegisterationState,
                                     NewMember.returnMember.LeftDay,
                                     NewMember.returnMember.Memo);

                    this.grdPage.Update();
                }
            };

            this.btnEdit.Click += (s, e) =>
            {
                Member selectedMember = (Member) this.grdPage.SelectedRows[0].DataBoundItem;
                editNewMember(selectedMember);
                this.grdPage.Select();
            };

            this.grdPage.CellDoubleClick += (s, e) =>
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    Member selectedMember = (Member) this.grdPage.Rows[rowIndex].DataBoundItem;
                    editNewMember(selectedMember);
                }
            };

            this.grdPage.CellPaint += (s, e) =>
            {
                if (e.Cell != null && e.Cell.RowInfo is GridViewDataRowInfo && e.Cell.ColumnInfo.Name == "Name")
                {
                    Pen pen;
                    if ((int)e.Cell.RowInfo.Cells["Gender"].Value == 1)
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

            };
            this.StatisticsAccountPage.Paint += (s, e) =>
            {
                this.YearlyMoneyChart.Series.Clear();
                this.MonthlyMoneyDiffChart.Series.Clear();
                this.YearlyMoneyChart.Series.Add(DBManager.Instance().GetTotalAmountLineSeries(2017));
                this.MonthlyMoneyDiffChart.Series.Add(DBManager.Instance().GetMonOverAmountLineSeries(2017));
            };

            Table<Member> members = DBManager.Instance().GetTable<Member>();
            this.grdPage.DataSource = members;

            ConditionalFormattingObject obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "1", "", true);
            obj.CellForeColor = System.Drawing.Color.Blue;
            this.grdPage.Columns["Gender"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "2", "", true);
            obj.CellForeColor = System.Drawing.Color.Red;
            this.grdPage.Columns["Gender"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("StateFormat", ConditionTypes.Equal, "2", "", true);
            obj.RowBackColor = System.Drawing.Color.PaleVioletRed;
            this.grdPage.Columns["RegisterationState"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("LeftDayFormat", ConditionTypes.LessOrEqual, "30", "", true);
            obj.CellForeColor = System.Drawing.Color.Red;
            this.grdPage.Columns["LeftDay"].ConditionalFormattingObjectList.Add(obj);

            this.grdPage.Columns["Name"].TextAlignment = ContentAlignment.MiddleRight;
        }

        private void editNewMember(Member selectedMember)
        {
            NewMember editMember = new NewMember();
            editMember.ShowDialog(2, selectedMember);

            if (editMember.result == System.Windows.Forms.DialogResult.OK)
            {
                DBManager.Instance().updateMember(editMember.returnMember);
            }
        }

        private void rad_SelectedPageChanged(object sender, System.EventArgs e)
        {

        }

        private void radPageViewPage1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void 월간_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void radPageViewPage1_Paint_1(object sender, System.Windows.Forms.PaintEventArgs e)
        {
          
           
        }

        private void radChartView7_Click(object sender, System.EventArgs e)
        {
            
        }

        private void memberBindingSource_CurrentChanged(object sender, System.EventArgs e)
        {

        }

        private void radChartView5_Click(object sender, System.EventArgs e)
        {

        }

        private void MemberStatisticAgeChart_Click(object sender, System.EventArgs e)
        {

        }

        private void MonthStatisticPageMonthlyMembers_Click(object sender, System.EventArgs e)
        {

        }

        private void radTextBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void radLabel3_Click(object sender, System.EventArgs e)
        {

        }

        private void radLabel4_Click(object sender, System.EventArgs e)
        {

        }

        private void MonthlyStatisticsMembersChart_Click(object sender, System.EventArgs e)
        {

        }
    }
}
