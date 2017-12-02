namespace oop_proj4
{
    partial class EditAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdminForm));
            this.CurrentPasswordTxt = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.ChangePasswordTxt = new Telerik.WinControls.UI.RadTextBox();
            this.ChangePasswordBtn = new Telerik.WinControls.UI.RadButton();
            this.ConfirmPasswordTxt = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasswordBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentPasswordTxt
            // 
            this.CurrentPasswordTxt.AutoSize = false;
            this.CurrentPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordTxt.Location = new System.Drawing.Point(31, 87);
            this.CurrentPasswordTxt.Name = "CurrentPasswordTxt";
            this.CurrentPasswordTxt.PasswordChar = '●';
            this.CurrentPasswordTxt.Size = new System.Drawing.Size(200, 30);
            this.CurrentPasswordTxt.TabIndex = 1;
            this.CurrentPasswordTxt.UseSystemPasswordChar = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(31, 44);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(128, 29);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "현재 비밀번호";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(31, 141);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(147, 29);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "변경할 비밀번호";
            // 
            // ChangePasswordTxt
            // 
            this.ChangePasswordTxt.AutoSize = false;
            this.ChangePasswordTxt.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordTxt.Location = new System.Drawing.Point(31, 185);
            this.ChangePasswordTxt.Name = "ChangePasswordTxt";
            this.ChangePasswordTxt.PasswordChar = '●';
            this.ChangePasswordTxt.Size = new System.Drawing.Size(200, 30);
            this.ChangePasswordTxt.TabIndex = 3;
            this.ChangePasswordTxt.UseSystemPasswordChar = true;
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(286, 177);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(99, 74);
            this.ChangePasswordBtn.TabIndex = 4;
            this.ChangePasswordBtn.Text = "변경";
            this.ChangePasswordBtn.ThemeName = "Windows8";
            // 
            // ConfirmPasswordTxt
            // 
            this.ConfirmPasswordTxt.AutoSize = false;
            this.ConfirmPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTxt.Location = new System.Drawing.Point(31, 221);
            this.ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            this.ConfirmPasswordTxt.PasswordChar = '●';
            this.ConfirmPasswordTxt.Size = new System.Drawing.Size(200, 30);
            this.ConfirmPasswordTxt.TabIndex = 4;
            this.ConfirmPasswordTxt.UseSystemPasswordChar = true;
            // 
            // EditAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 283);
            this.Controls.Add(this.ConfirmPasswordTxt);
            this.Controls.Add(this.ChangePasswordBtn);
            this.Controls.Add(this.ChangePasswordTxt);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.CurrentPasswordTxt);
            this.Controls.Add(this.radLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAdminForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EditAdminForm";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasswordBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTextBox CurrentPasswordTxt;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox ChangePasswordTxt;
        private Telerik.WinControls.UI.RadButton ChangePasswordBtn;
        private Telerik.WinControls.UI.RadTextBox ConfirmPasswordTxt;
    }
}