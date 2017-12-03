namespace oop_proj4
{
    partial class NewTransactionForm
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTransactionForm));
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtDateLabel = new Telerik.WinControls.UI.RadTextBox();
            this.txtNameLabel = new Telerik.WinControls.UI.RadTextBox();
            this.ddlName = new Telerik.WinControls.UI.RadDropDownList();
            this.txtAmountLabel = new Telerik.WinControls.UI.RadTextBox();
            this.txtAmount = new Telerik.WinControls.UI.RadTextBox();
            this.ddlType = new Telerik.WinControls.UI.RadDropDownList();
            this.txtTypeLabel = new Telerik.WinControls.UI.RadTextBox();
            this.btnApply = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.ddlPay = new Telerik.WinControls.UI.RadDropDownList();
            this.txtPayLabel = new Telerik.WinControls.UI.RadTextBox();
            this.txtMemoLabel = new Telerik.WinControls.UI.RadTextBox();
            this.txtMemo = new Telerik.WinControls.UI.RadTextBox();
            this.txtId = new Telerik.WinControls.UI.RadTextBox();
            this.txtIdLabel = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemoLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(121, 59);
            this.dtpDate.MaxDate = new System.DateTime(2017, 11, 27, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 31);
            this.dtpDate.TabIndex = 28;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "2017-11-27";
            this.dtpDate.ThemeName = "Windows8";
            this.dtpDate.Value = new System.DateTime(2017, 11, 27, 0, 0, 0, 0);
            // 
            // txtDateLabel
            // 
            this.txtDateLabel.AcceptsTab = true;
            this.txtDateLabel.Enabled = false;
            this.txtDateLabel.Location = new System.Drawing.Point(12, 59);
            this.txtDateLabel.Name = "txtDateLabel";
            this.txtDateLabel.ReadOnly = true;
            this.txtDateLabel.Size = new System.Drawing.Size(103, 31);
            this.txtDateLabel.TabIndex = 29;
            this.txtDateLabel.Text = "· 거래날짜";
            this.txtDateLabel.ThemeName = "Windows8";
            // 
            // txtNameLabel
            // 
            this.txtNameLabel.AcceptsTab = true;
            this.txtNameLabel.Enabled = false;
            this.txtNameLabel.Location = new System.Drawing.Point(12, 96);
            this.txtNameLabel.Name = "txtNameLabel";
            this.txtNameLabel.ReadOnly = true;
            this.txtNameLabel.Size = new System.Drawing.Size(103, 31);
            this.txtNameLabel.TabIndex = 31;
            this.txtNameLabel.Text = "· 이름";
            this.txtNameLabel.ThemeName = "Windows8";
            // 
            // ddlName
            // 
            this.ddlName.Location = new System.Drawing.Point(122, 96);
            this.ddlName.Name = "ddlName";
            this.ddlName.Size = new System.Drawing.Size(249, 31);
            this.ddlName.TabIndex = 32;
            this.ddlName.ThemeName = "Windows8";
            // 
            // txtAmountLabel
            // 
            this.txtAmountLabel.AcceptsTab = true;
            this.txtAmountLabel.Enabled = false;
            this.txtAmountLabel.Location = new System.Drawing.Point(12, 133);
            this.txtAmountLabel.Name = "txtAmountLabel";
            this.txtAmountLabel.ReadOnly = true;
            this.txtAmountLabel.Size = new System.Drawing.Size(103, 31);
            this.txtAmountLabel.TabIndex = 33;
            this.txtAmountLabel.Text = "· 금액";
            this.txtAmountLabel.ThemeName = "Windows8";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(121, 133);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(250, 31);
            this.txtAmount.TabIndex = 34;
            // 
            // ddlType
            // 
            radListDataItem1.Tag = "0";
            radListDataItem1.Text = "수입";
            radListDataItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            radListDataItem2.Tag = "1";
            radListDataItem2.Text = "지출";
            radListDataItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ddlType.Items.Add(radListDataItem1);
            this.ddlType.Items.Add(radListDataItem2);
            this.ddlType.Location = new System.Drawing.Point(122, 170);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(249, 31);
            this.ddlType.TabIndex = 36;
            this.ddlType.ThemeName = "Windows8";
            // 
            // txtTypeLabel
            // 
            this.txtTypeLabel.AcceptsTab = true;
            this.txtTypeLabel.Enabled = false;
            this.txtTypeLabel.Location = new System.Drawing.Point(12, 170);
            this.txtTypeLabel.Name = "txtTypeLabel";
            this.txtTypeLabel.ReadOnly = true;
            this.txtTypeLabel.Size = new System.Drawing.Size(103, 31);
            this.txtTypeLabel.TabIndex = 35;
            this.txtTypeLabel.Text = "· 거래종류";
            this.txtTypeLabel.ThemeName = "Windows8";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(257, 482);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(51, 30);
            this.btnApply.TabIndex = 38;
            this.btnApply.Text = "등록";
            this.btnApply.ThemeName = "Windows8";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 30);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "취소";
            this.btnCancel.ThemeName = "Windows8";
            // 
            // ddlPay
            // 
            radListDataItem3.Tag = "0";
            radListDataItem3.Text = "카드";
            radListDataItem4.Tag = "1";
            radListDataItem4.Text = "현금";
            this.ddlPay.Items.Add(radListDataItem3);
            this.ddlPay.Items.Add(radListDataItem4);
            this.ddlPay.Location = new System.Drawing.Point(122, 207);
            this.ddlPay.Name = "ddlPay";
            this.ddlPay.Size = new System.Drawing.Size(249, 31);
            this.ddlPay.TabIndex = 40;
            this.ddlPay.ThemeName = "Windows8";
            // 
            // txtPayLabel
            // 
            this.txtPayLabel.AcceptsTab = true;
            this.txtPayLabel.Enabled = false;
            this.txtPayLabel.Location = new System.Drawing.Point(12, 207);
            this.txtPayLabel.Name = "txtPayLabel";
            this.txtPayLabel.ReadOnly = true;
            this.txtPayLabel.Size = new System.Drawing.Size(103, 31);
            this.txtPayLabel.TabIndex = 39;
            this.txtPayLabel.Text = "· 납부방법";
            this.txtPayLabel.ThemeName = "Windows8";
            // 
            // txtMemoLabel
            // 
            this.txtMemoLabel.Enabled = false;
            this.txtMemoLabel.Location = new System.Drawing.Point(12, 244);
            this.txtMemoLabel.Name = "txtMemoLabel";
            this.txtMemoLabel.ReadOnly = true;
            this.txtMemoLabel.Size = new System.Drawing.Size(76, 31);
            this.txtMemoLabel.TabIndex = 42;
            this.txtMemoLabel.Text = "· 메모";
            this.txtMemoLabel.ThemeName = "Windows8";
            // 
            // txtMemo
            // 
            this.txtMemo.AutoSize = false;
            this.txtMemo.Location = new System.Drawing.Point(12, 275);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(359, 191);
            this.txtMemo.TabIndex = 41;
            this.txtMemo.ThemeName = "Windows8";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(121, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 31);
            this.txtId.TabIndex = 44;
            // 
            // txtIdLabel
            // 
            this.txtIdLabel.AcceptsTab = true;
            this.txtIdLabel.Enabled = false;
            this.txtIdLabel.Location = new System.Drawing.Point(12, 22);
            this.txtIdLabel.Name = "txtIdLabel";
            this.txtIdLabel.ReadOnly = true;
            this.txtIdLabel.Size = new System.Drawing.Size(103, 31);
            this.txtIdLabel.TabIndex = 43;
            this.txtIdLabel.Text = "· 번호";
            this.txtIdLabel.ThemeName = "Windows8";
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 523);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdLabel);
            this.Controls.Add(this.txtMemoLabel);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.ddlPay);
            this.Controls.Add(this.txtPayLabel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.txtTypeLabel);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAmountLabel);
            this.Controls.Add(this.ddlName);
            this.Controls.Add(this.txtNameLabel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTransactionForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "거래내역 추가";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemoLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private Telerik.WinControls.UI.RadTextBox txtDateLabel;
        private Telerik.WinControls.UI.RadTextBox txtNameLabel;
        private Telerik.WinControls.UI.RadDropDownList ddlName;
        private Telerik.WinControls.UI.RadTextBox txtAmountLabel;
        private Telerik.WinControls.UI.RadTextBox txtAmount;
        private Telerik.WinControls.UI.RadDropDownList ddlType;
        private Telerik.WinControls.UI.RadTextBox txtTypeLabel;
        private Telerik.WinControls.UI.RadButton btnApply;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadDropDownList ddlPay;
        private Telerik.WinControls.UI.RadTextBox txtPayLabel;
        private Telerik.WinControls.UI.RadTextBox txtMemoLabel;
        private Telerik.WinControls.UI.RadTextBox txtMemo;
        private Telerik.WinControls.UI.RadTextBox txtId;
        private Telerik.WinControls.UI.RadTextBox txtIdLabel;
    }
}