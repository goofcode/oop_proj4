using System.Data.Linq;
using Telerik.WinControls;

namespace oop_proj4
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => { Program.End(); };
                
            int dividedWidth = this.grdPage.Width / this.grdPage.Columns.Count;
            foreach (Telerik.WinControls.UI.GridViewColumn column in this.grdPage.Columns) {
                column.Width = dividedWidth;
            }

            Table<Member> members = DBManager.Instance().GetTable<Member>();
            grdPage.DataSource = members;
            // @TODO : members 로 부터 직접 그리드뷰에 넣기.. BirthDate, 성별, 등록상태 처리해줘야 함

            this.radDesktopAlert1.CaptionText = "사장님";
            this.radDesktopAlert1.ContentText = "나빠요.";
            this.radDesktopAlert1.Show();

            this.btnNew.Click += (s, e) =>
            {
                NewMember NewMember = new NewMember();
                NewMember.ShowDialog(1);

                if (NewMember.result == System.Windows.Forms.DialogResult.OK)
                {
                    DBManager.Instance().insertMember(NewMember.returnMember);
                    grdPage.Rows.Add(NewMember.returnMember.Name,
                                     NewMember.returnMember.Tel,
                                     NewMember.returnMember.Gender,
                                     NewMember.returnMember.BirthDate.ToShortDateString(),
                                     NewMember.returnMember.RegisterationState,
                                     NewMember.returnMember.LeftDay,
                                     NewMember.returnMember.Memo);
                    // @TODO : 새로고침 해줘야함
                }
            };

            this.btnEdit.Click += (s, e) =>
            {
                Member selectedMember = (Member) grdPage.SelectedRows[0].DataBoundItem;

                NewMember editStudent = new NewMember();
                editStudent.ShowDialog(2, selectedMember);

                if (editStudent.result == System.Windows.Forms.DialogResult.OK)
                {
                    DBManager.Instance().updateMember(editStudent.returnMember);
                    // @TODO : 새로고침 해줘야함
                }
            };
        }
    }
}
