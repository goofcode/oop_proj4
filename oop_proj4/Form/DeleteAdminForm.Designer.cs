namespace oop_proj4
{
    partial class DeleteAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAdminForm));
            this.DeleteBtn = new Telerik.WinControls.UI.RadButton();
            this.lblPassword = new Telerik.WinControls.UI.RadLabel();
            this.PasswordTxt = new Telerik.WinControls.UI.RadTextBox();
            this.lblSeperator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(24, 118);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(305, 30);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "삭제";
            this.DeleteBtn.ThemeName = "Windows8";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(56, 26);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(233, 29);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "비밀번호를 입력해 주세요.";
            this.lblPassword.ThemeName = "Windows8";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoSize = false;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(24, 61);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '●';
            this.PasswordTxt.Size = new System.Drawing.Size(305, 29);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTxt.ThemeName = "Windows8";
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // lblSeperator
            // 
            this.lblSeperator.BackColor = System.Drawing.Color.Red;
            this.lblSeperator.Location = new System.Drawing.Point(24, 104);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(306, 1);
            this.lblSeperator.TabIndex = 13;
            // 
            // DeleteAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 165);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.DeleteBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAdminForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "주짓수 회원관리 프로그램 - [관리자 삭제하기]";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton DeleteBtn;
        private Telerik.WinControls.UI.RadLabel lblPassword;
        private Telerik.WinControls.UI.RadTextBox PasswordTxt;
        private System.Windows.Forms.Label lblSeperator;
    }
}