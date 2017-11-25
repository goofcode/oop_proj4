using System.Windows.Forms;

namespace oop_proj4
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            this.LoginBtn.Click += (s, e) => 
            {
                // if succeed to login, start main form
                if (DBManager.Instance().CheckAdmin(this.IDTxt.Text, this.PWTxt.Text))
                {
                    Program.ShowMainForm();
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong ID or PW");
            };
            this.FormClosed += (s, e) => { Program.End(); };
        }
    }
}
