namespace oop_proj4
{
    partial class NewAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAdminForm));
            this.ConfirmNewPasswordTxt = new Telerik.WinControls.UI.RadTextBox();
            this.SubmintBtn = new Telerik.WinControls.UI.RadButton();
            this.NewPasswordTxt = new Telerik.WinControls.UI.RadTextBox();
            this.lblPW = new Telerik.WinControls.UI.RadLabel();
            this.lblID = new Telerik.WinControls.UI.RadLabel();
            this.NewIDTxt = new Telerik.WinControls.UI.RadTextBox();
            this.lblPWConfirm = new Telerik.WinControls.UI.RadLabel();
            this.lblSeperator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmNewPasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewIDTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPWConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmNewPasswordTxt
            // 
            this.ConfirmNewPasswordTxt.AutoSize = false;
            this.ConfirmNewPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPasswordTxt.Location = new System.Drawing.Point(126, 95);
            this.ConfirmNewPasswordTxt.Name = "ConfirmNewPasswordTxt";
            this.ConfirmNewPasswordTxt.PasswordChar = '●';
            this.ConfirmNewPasswordTxt.Size = new System.Drawing.Size(200, 30);
            this.ConfirmNewPasswordTxt.TabIndex = 9;
            this.ConfirmNewPasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmNewPasswordTxt.UseSystemPasswordChar = true;
            // 
            // SubmintBtn
            // 
            this.SubmintBtn.Location = new System.Drawing.Point(12, 162);
            this.SubmintBtn.Name = "SubmintBtn";
            this.SubmintBtn.Size = new System.Drawing.Size(314, 34);
            this.SubmintBtn.TabIndex = 10;
            this.SubmintBtn.Text = "추가하기";
            this.SubmintBtn.ThemeName = "Windows8";
            // 
            // NewPasswordTxt
            // 
            this.NewPasswordTxt.AutoSize = false;
            this.NewPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTxt.Location = new System.Drawing.Point(126, 59);
            this.NewPasswordTxt.Name = "NewPasswordTxt";
            this.NewPasswordTxt.PasswordChar = '●';
            this.NewPasswordTxt.Size = new System.Drawing.Size(200, 30);
            this.NewPasswordTxt.TabIndex = 8;
            this.NewPasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPasswordTxt.UseSystemPasswordChar = true;
            // 
            // lblPW
            // 
            this.lblPW.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(21, 60);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(94, 29);
            this.lblPW.TabIndex = 6;
            this.lblPW.Text = "비밀번호 :";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 29);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "아이디 :";
            // 
            // NewIDTxt
            // 
            this.NewIDTxt.AutoSize = false;
            this.NewIDTxt.Location = new System.Drawing.Point(126, 23);
            this.NewIDTxt.Name = "NewIDTxt";
            this.NewIDTxt.Size = new System.Drawing.Size(200, 30);
            this.NewIDTxt.TabIndex = 11;
            this.NewIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPWConfirm
            // 
            this.lblPWConfirm.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWConfirm.Location = new System.Drawing.Point(21, 95);
            this.lblPWConfirm.Name = "lblPWConfirm";
            this.lblPWConfirm.Size = new System.Drawing.Size(56, 29);
            this.lblPWConfirm.TabIndex = 7;
            this.lblPWConfirm.Text = "확인 :";
            // 
            // lblSeperator
            // 
            this.lblSeperator.BackColor = System.Drawing.Color.Red;
            this.lblSeperator.Location = new System.Drawing.Point(7, 147);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(319, 1);
            this.lblSeperator.TabIndex = 12;
            // 
            // NewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 210);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.lblPWConfirm);
            this.Controls.Add(this.NewIDTxt);
            this.Controls.Add(this.ConfirmNewPasswordTxt);
            this.Controls.Add(this.SubmintBtn);
            this.Controls.Add(this.NewPasswordTxt);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewAdminForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주짓수 회원관리 프로그램 - [관리자 계정 추가]";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmNewPasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewIDTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPWConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox ConfirmNewPasswordTxt;
        private Telerik.WinControls.UI.RadButton SubmintBtn;
        private Telerik.WinControls.UI.RadTextBox NewPasswordTxt;
        private Telerik.WinControls.UI.RadLabel lblPW;
        private Telerik.WinControls.UI.RadLabel lblID;
        private Telerik.WinControls.UI.RadTextBox NewIDTxt;
        private Telerik.WinControls.UI.RadLabel lblPWConfirm;
        private System.Windows.Forms.Label lblSeperator;
    }
}