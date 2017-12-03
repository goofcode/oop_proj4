using System;
using Telerik.WinControls;

namespace oop_proj4
{
    public partial class EditAdminForm : Telerik.WinControls.UI.RadForm
    {
        public EditAdminForm()
        {
            InitializeComponent();
            this.ChangePasswordBtn.Click += (s, e) =>
            {
                if (DBManager.Instance().CheckAdmin(Program.AdminId, this.CurrentPasswordTxt.Text))
                {
                    if(this.ChangePasswordTxt.Text == this.ConfirmPasswordTxt.Text)
                    {
                        DBManager.Instance().UpdateAdminPW(this.ChangePasswordTxt.Text);
                        RadMessageBox.SetThemeName(this.ThemeName);
                        RadMessageBox.Show("변경되었습니다.", "Confirm", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        RadMessageBox.SetThemeName(this.ThemeName);
                        RadMessageBox.Show("변경할 비밀번호가 서로 다릅니다.", "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                }
                else
                {
                    RadMessageBox.SetThemeName(this.ThemeName);
                    RadMessageBox.Show("현재 비밀번호가 틀렸습니다.", "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            };
        }
        
    }
}
