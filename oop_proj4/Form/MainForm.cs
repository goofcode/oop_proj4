using System.Data.Linq;

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

            this.radDesktopAlert1.CaptionText = "사장님";
            this.radDesktopAlert1.ContentText = "나빠요.";
            this.radDesktopAlert1.Show();
        }
    }
}
