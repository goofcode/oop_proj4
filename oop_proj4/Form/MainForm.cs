using Telerik.WinControls;

namespace oop_proj4
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            // this.Load += (s, e) => { this.DBGrid.DataSource = DBManager.Instance().GetTable<Member>(); };
            this.FormClosed += (s, e) => { Program.End(); };
        }
    }
}
