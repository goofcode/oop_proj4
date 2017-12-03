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
    public partial class DeleteAdminForm : Telerik.WinControls.UI.RadForm
    {
        public DeleteAdminForm(string id)
        {
            InitializeComponent();
            this.DeleteBtn.Click += (s, e)=>
            {
                if (DBManager.Instance().CheckAdmin(id, this.PasswordTxt.Text))
                {
                    DBManager.Instance().DeleteAdmin(id);
                    this.DialogResult = DialogResult.OK;
                    RadMessageBox.SetThemeName(this.ThemeName);
                    RadMessageBox.Show("삭제되었습니다", "Delete", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.Close();
                }
                else
                {
                    RadMessageBox.SetThemeName(this.ThemeName);
                    RadMessageBox.Show("비밀번호가 다릅니다", "Error", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                    this.Close();
                }
            };
        }
    }
}
