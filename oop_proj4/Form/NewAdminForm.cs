using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace oop_proj4
{
    public partial class NewAdminForm : Telerik.WinControls.UI.RadForm
    {
        public NewAdminForm()
        {
            InitializeComponent();
            this.SubmintBtn.Click += (s, e) =>
            {
                string id = this.NewIDTxt.Text;
                string pw = this.NewPasswordTxt.Text;
                string confirm_pw = this.ConfirmNewPasswordTxt.Text;

                if (!DBManager.Instance().IsAdminExist(id))
                {
                    if(pw == confirm_pw)
                    {
                        DBManager.Instance().AddAdmin(id, pw);
                        RadMessageBox.SetThemeName(this.ThemeName);
                        RadMessageBox.Show("새로운 관리자가 등록되었습니다", "Complete", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        RadMessageBox.SetThemeName(this.ThemeName);
                        RadMessageBox.Show("입력한 비밀번호가 서로 다릅니다", "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                }
                else
                {
                    RadMessageBox.SetThemeName(this.ThemeName);
                    RadMessageBox.Show("해당 ID를 가진 관리자가 이미 존재합니다", "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            };
        }
    }
}
