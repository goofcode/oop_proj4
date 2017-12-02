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

            Table<Member> members = DBManager.Instance().GetTable<Member>();
            foreach (Member member in members)
            {
                this.grdPage.Rows.Add(new object[] { false, member.Id, member.Name,
                member.Tel, member.Gender == 1 ? "남자" : "여자" });
                this.grdPage.DataSource = member;
            }

            ConditionalFormattingObject obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "1", "", true);
            obj.CellForeColor = System.Drawing.Color.Blue;
            this.grdPage.Columns["columnGender"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("GenderFormat", ConditionTypes.Equal, "2", "", true);
            obj.CellForeColor = System.Drawing.Color.Red;
            this.grdPage.Columns["columnGender"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("StateFormat", ConditionTypes.Equal, "2", "", true);
            obj.RowBackColor = System.Drawing.Color.PaleVioletRed;
            this.grdPage.Columns["columnRegistrationState"].ConditionalFormattingObjectList.Add(obj);

            obj = new ConditionalFormattingObject("LeftDayFormat", ConditionTypes.LessOrEqual, "30", "", true);
            obj.CellForeColor = System.Drawing.Color.Red;
            this.grdPage.Columns["columnLeftDay"].ConditionalFormattingObjectList.Add(obj);
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
    }
}
