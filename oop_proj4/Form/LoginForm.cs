using Telerik.WinControls;

namespace oop_proj4
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm 
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (DBManager.Instance().CheckAdmin(this.txtID.Text, this.txtPassword.Text))
            {
                Program.ShowMainForm();
                this.Hide();
            }
            else
            {
                RadMessageBox.SetThemeName(this.ThemeName);
                RadMessageBox.Show("Wrong ID or PW", "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
    }
}
