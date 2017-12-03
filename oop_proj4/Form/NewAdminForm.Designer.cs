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
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.NewIDTxt = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmNewPasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewIDTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmNewPasswordTxt
            // 
            this.ConfirmNewPasswordTxt.AutoSize = false;
            this.ConfirmNewPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPasswordTxt.Location = new System.Drawing.Point(21, 199);
            this.ConfirmNewPasswordTxt.Name = "ConfirmNewPasswordTxt";
            this.ConfirmNewPasswordTxt.PasswordChar = '●';
            this.ConfirmNewPasswordTxt.Size = new System.Drawing.Size(200, 30);
            this.ConfirmNewPasswordTxt.TabIndex = 9;
            this.ConfirmNewPasswordTxt.UseSystemPasswordChar = true;
            // 
            // SubmintBtn
            // 
            this.SubmintBtn.Location = new System.Drawing.Point(276, 155);
            this.SubmintBtn.Name = "SubmintBtn";
            this.SubmintBtn.Size = new System.Drawing.Size(99, 74);
            this.SubmintBtn.TabIndex = 10;
            this.SubmintBtn.Text = "추가";
            this.SubmintBtn.ThemeName = "Windows8";
            // 
            // NewPasswordTxt
            // 
            this.NewPasswordTxt.AutoSize = false;
            this.NewPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTxt.Location = new System.Drawing.Point(21, 163);
            this.NewPasswordTxt.Name = "NewPasswordTxt";
            this.NewPasswordTxt.PasswordChar = '●';
            this.NewPasswordTxt.Size = new System.Drawing.Size(200, 30);
            this.NewPasswordTxt.TabIndex = 8;
            this.NewPasswordTxt.UseSystemPasswordChar = true;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(21, 119);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(85, 29);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "비밀번호";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(21, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 29);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "아이디";
            // 
            // NewIDTxt
            // 
            this.NewIDTxt.AutoSize = false;
            this.NewIDTxt.Location = new System.Drawing.Point(21, 57);
            this.NewIDTxt.Name = "NewIDTxt";
            this.NewIDTxt.Size = new System.Drawing.Size(200, 30);
            this.NewIDTxt.TabIndex = 11;
            // 
            // NewAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 251);
            this.Controls.Add(this.NewIDTxt);
            this.Controls.Add(this.ConfirmNewPasswordTxt);
            this.Controls.Add(this.SubmintBtn);
            this.Controls.Add(this.NewPasswordTxt);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAdminForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "NewAdminForm";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmNewPasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewIDTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox ConfirmNewPasswordTxt;
        private Telerik.WinControls.UI.RadButton SubmintBtn;
        private Telerik.WinControls.UI.RadTextBox NewPasswordTxt;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox NewIDTxt;
    }
}