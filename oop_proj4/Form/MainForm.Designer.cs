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
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.pvMain = new Telerik.WinControls.UI.RadPageView();
            this.pageGroupAccount = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.pageManage = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageStatistics = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageAccounting = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageGroupUser = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.pageSetting = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageLogout = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.pvMain)).BeginInit();
            this.pvMain.SuspendLayout();
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
            this.pvMain.Size = new System.Drawing.Size(1437, 855);
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
            this.pageGroupAccount.ItemSize = new System.Drawing.SizeF(97F, 27F);
            this.pageGroupAccount.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.pageGroupAccount.Location = new System.Drawing.Point(0, 0);
            this.pageGroupAccount.Name = "pageGroupAccount";
            this.pageGroupAccount.Size = new System.Drawing.Size(0, 0);
            this.pageGroupAccount.Text = "회원";
            // 
            // pageManage
            // 
            this.pageManage.ItemSize = new System.Drawing.SizeF(97F, 29F);
            this.pageManage.Location = new System.Drawing.Point(154, 5);
            this.pageManage.Name = "pageManage";
            this.pageManage.Size = new System.Drawing.Size(1278, 845);
            this.pageManage.Text = "회원 관리";
            this.pageManage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageStatistics
            // 
            this.pageStatistics.ItemSize = new System.Drawing.SizeF(97F, 29F);
            this.pageStatistics.Location = new System.Drawing.Point(173, 5);
            this.pageStatistics.Name = "pageStatistics";
            this.pageStatistics.Size = new System.Drawing.Size(1259, 845);
            this.pageStatistics.Text = "통계";
            this.pageStatistics.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pageAccounting
            // 
            this.pageAccounting.ItemSize = new System.Drawing.SizeF(97F, 29F);
            this.pageAccounting.Location = new System.Drawing.Point(173, 5);
            this.pageAccounting.Name = "pageAccounting";
            this.pageAccounting.Size = new System.Drawing.Size(1259, 845);
            this.pageAccounting.Text = "회계";
            this.pageAccounting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageGroupUser
            // 
            this.pageGroupUser.ItemSize = new System.Drawing.SizeF(97F, 27F);
            this.pageGroupUser.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.pageGroupUser.Location = new System.Drawing.Point(0, 0);
            this.pageGroupUser.Name = "pageGroupUser";
            this.pageGroupUser.Size = new System.Drawing.Size(0, 0);
            this.pageGroupUser.Text = "프로그램 설정";
            // 
            // pageSetting
            // 
            this.pageSetting.ItemSize = new System.Drawing.SizeF(97F, 29F);
            this.pageSetting.Location = new System.Drawing.Point(154, 5);
            this.pageSetting.Name = "pageSetting";
            this.pageSetting.Size = new System.Drawing.Size(1278, 845);
            this.pageSetting.Text = "설정";
            this.pageSetting.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageLogout
            // 
            this.pageLogout.ItemSize = new System.Drawing.SizeF(97F, 29F);
            this.pageLogout.Location = new System.Drawing.Point(154, 5);
            this.pageLogout.Name = "pageLogout";
            this.pageLogout.Size = new System.Drawing.Size(1278, 845);
            this.pageLogout.Text = "로그아웃";
            this.pageLogout.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 852);
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
    
    }
}