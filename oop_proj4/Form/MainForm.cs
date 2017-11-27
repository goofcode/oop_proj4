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

        private void pvMain_SelectedPageChanged(object sender, System.EventArgs e)
        {

        }

        private void radChartView1_Click(object sender, System.EventArgs e)
        {

        }

        private void pageStatistics_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void radChartView2_Click(object sender, System.EventArgs e)
        {

        }

        private void radButton1_Click(object sender, System.EventArgs e)
        {

        }

        private void rad_SelectedPageChanged(object sender, System.EventArgs e)
        {

        }

        private void radTextBox4_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
