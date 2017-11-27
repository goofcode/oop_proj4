namespace oop_proj4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.pvMain = new Telerik.WinControls.UI.RadPageView();
            this.pageGroupAccount = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.pageManage = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageStatistics = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageAccounting = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageGroupUser = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.pageSetting = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageLogout = new Telerik.WinControls.UI.RadPageViewPage();
            this.object_6abb8877_465c_4679_8322_baa7ddac60d1 = new Telerik.WinControls.RootRadElement();
            this.grdPage = new Telerik.WinControls.UI.RadGridView();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pvMain)).BeginInit();
            this.pvMain.SuspendLayout();
            this.pageManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPage.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pvMain
            // 
            this.pvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvMain.Controls.Add(this.pageGroupAccount);
            this.pvMain.Controls.Add(this.pageManage);
            this.pvMain.Controls.Add(this.pageStatistics);
            this.pvMain.Controls.Add(this.pageAccounting);
            this.pvMain.Controls.Add(this.pageGroupUser);
            this.pvMain.Controls.Add(this.pageSetting);
            this.pvMain.Controls.Add(this.pageLogout);
            this.pvMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvMain.Location = new System.Drawing.Point(0, 0);
            this.pvMain.Name = "pvMain";
            this.pvMain.SelectedPage = this.pageManage;
            this.pvMain.Size = new System.Drawing.Size(1314, 572);
            this.pvMain.TabIndex = 0;
            this.pvMain.ThemeName = "Windows8";
            this.pvMain.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pvMain.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pvMain.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.FillHeight;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pvMain.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Left;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.pvMain.GetChildAt(0).GetChildAt(0))).MinSize = new System.Drawing.Size(150, 0);
            // 
            // pageGroupAccount
            // 
            this.pageGroupAccount.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.pageGroupAccount.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.pageGroupAccount.Location = new System.Drawing.Point(0, 0);
            this.pageGroupAccount.Name = "pageGroupAccount";
            this.pageGroupAccount.Size = new System.Drawing.Size(0, 0);
            this.pageGroupAccount.Text = "회원";
            // 
            // pageManage
            // 
            this.pageManage.Controls.Add(this.grdPage);
            this.pageManage.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.pageManage.Location = new System.Drawing.Point(154, 5);
            this.pageManage.Name = "pageManage";
            this.pageManage.Size = new System.Drawing.Size(1155, 562);
            this.pageManage.Text = "회원 관리";
            this.pageManage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageStatistics
            // 
            this.pageStatistics.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.pageStatistics.Location = new System.Drawing.Point(154, 5);
            this.pageStatistics.Name = "pageStatistics";
            this.pageStatistics.Size = new System.Drawing.Size(1155, 562);
            this.pageStatistics.Text = "통계";
            this.pageStatistics.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pageAccounting
            // 
            this.pageAccounting.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.pageAccounting.Location = new System.Drawing.Point(154, 5);
            this.pageAccounting.Name = "pageAccounting";
            this.pageAccounting.Size = new System.Drawing.Size(1155, 562);
            this.pageAccounting.Text = "회계";
            this.pageAccounting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageGroupUser
            // 
            this.pageGroupUser.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.pageGroupUser.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.pageGroupUser.Location = new System.Drawing.Point(0, 0);
            this.pageGroupUser.Name = "pageGroupUser";
            this.pageGroupUser.Size = new System.Drawing.Size(0, 0);
            this.pageGroupUser.Text = "프로그램 설정";
            // 
            // pageSetting
            // 
            this.pageSetting.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.pageSetting.Location = new System.Drawing.Point(154, 5);
            this.pageSetting.Name = "pageSetting";
            this.pageSetting.Size = new System.Drawing.Size(1155, 562);
            this.pageSetting.Text = "설정";
            this.pageSetting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageLogout
            // 
            this.pageLogout.ItemSize = new System.Drawing.SizeF(117F, 31F);
            this.pageLogout.Location = new System.Drawing.Point(154, 5);
            this.pageLogout.Name = "pageLogout";
            this.pageLogout.Size = new System.Drawing.Size(1155, 562);
            this.pageLogout.Text = "로그아웃";
            this.pageLogout.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // object_6abb8877_465c_4679_8322_baa7ddac60d1
            // 
            this.object_6abb8877_465c_4679_8322_baa7ddac60d1.Name = "object_6abb8877_465c_4679_8322_baa7ddac60d1";
            this.object_6abb8877_465c_4679_8322_baa7ddac60d1.StretchHorizontally = true;
            this.object_6abb8877_465c_4679_8322_baa7ddac60d1.StretchVertically = true;
            // 
            // grdPage
            // 
            this.grdPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPage.Location = new System.Drawing.Point(3, 53);
            // 
            // 
            // 
            this.grdPage.MasterTemplate.AllowAddNewRow = false;
            this.grdPage.MasterTemplate.AllowColumnReorder = false;
            this.grdPage.MasterTemplate.AllowDragToGroup = false;
            this.grdPage.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "이름";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 54;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "Gender";
            gridViewDecimalColumn1.HeaderText = "성별";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Gender";
            gridViewDecimalColumn1.Width = 64;
            gridViewDateTimeColumn1.FieldName = "BirthDate";
            gridViewDateTimeColumn1.HeaderText = "생년월일";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "BirthDate";
            gridViewDateTimeColumn1.Width = 79;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "RegisterationState";
            gridViewDecimalColumn2.HeaderText = "등록상태";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "RegisterationState";
            gridViewDecimalColumn2.Width = 146;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "LeftDay";
            gridViewDecimalColumn3.HeaderText = "잔여일";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "LeftDay";
            gridViewDecimalColumn3.Width = 66;
            gridViewTextBoxColumn2.FieldName = "Memo";
            gridViewTextBoxColumn2.HeaderText = "메모";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Memo";
            gridViewTextBoxColumn2.Width = 58;
            this.grdPage.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn2});
            this.grdPage.MasterTemplate.DataSource = this.memberBindingSource;
            this.grdPage.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdPage.Name = "grdPage";
            this.grdPage.ReadOnly = true;
            this.grdPage.Size = new System.Drawing.Size(1149, 499);
            this.grdPage.TabIndex = 4;
            this.grdPage.ThemeName = "Windows8";
            // 
            // radDesktopAlert1
            // 
            this.radDesktopAlert1.ThemeName = "Windows8";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(oop_proj4.Member);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 569);
            this.Controls.Add(this.pvMain);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 관리";
            this.ThemeName = "Windows8";
            ((System.ComponentModel.ISupportInitialize)(this.pvMain)).EndInit();
            this.pvMain.ResumeLayout(false);
            this.pageManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPage.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadPageView pvMain;
        private Telerik.WinControls.UI.RadPageViewItemPage pageGroupAccount;
        private Telerik.WinControls.UI.RadPageViewPage pageManage;
        private Telerik.WinControls.UI.RadPageViewPage pageStatistics;
        private Telerik.WinControls.UI.RadPageViewPage pageAccounting;
        private Telerik.WinControls.UI.RadPageViewItemPage pageGroupUser;
        private Telerik.WinControls.UI.RadPageViewPage pageSetting;
        private Telerik.WinControls.UI.RadPageViewPage pageLogout;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private Telerik.WinControls.UI.RadGridView grdPage;
        private Telerik.WinControls.RootRadElement object_6abb8877_465c_4679_8322_baa7ddac60d1;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
    }
}