namespace oop_proj4
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.pnlLogin = new Telerik.WinControls.UI.RadPanel();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.lblPW = new Telerik.WinControls.UI.RadLabel();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.lblID = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(216, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(54, 49);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Black;
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblPW);
            this.pnlLogin.Controls.Add(this.txtID);
            this.pnlLogin.Controls.Add(this.lblID);
            this.pnlLogin.EnableCodedUITests = true;
            this.pnlLogin.ForeColor = System.Drawing.Color.Black;
            this.pnlLogin.Location = new System.Drawing.Point(216, 206);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(278, 150);
            this.pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(201, 67);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(57, 53);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.ThemeName = "Windows8";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(49, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '▲';
            this.txtPassword.Size = new System.Drawing.Size(146, 31);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.ThemeName = "Windows8";
            // 
            // lblPW
            // 
            this.lblPW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.ForeColor = System.Drawing.Color.White;
            this.lblPW.Location = new System.Drawing.Point(13, 95);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(32, 25);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "PW";
            this.lblPW.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPW.ThemeName = "Windows8";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(49, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 31);
            this.txtID.TabIndex = 1;
            this.txtID.ThemeName = "Windows8";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(13, 65);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblID.ThemeName = "Windows8";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("맑은 고딕", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radLabel2.Location = new System.Drawing.Point(277, 155);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(205, 41);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "ADMIN LOGIN";
            this.radLabel2.ThemeName = "Windows8";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 418);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadPanel pnlLogin;
        private Telerik.WinControls.UI.RadLabel lblID;
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadLabel lblPW;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}

