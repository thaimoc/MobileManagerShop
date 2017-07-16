namespace MobilesApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvbHome = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbProducts = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbBills = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbMemberManisger = new DevExpress.XtraNavBar.NavBarItem();
            this.nvBarShoping = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbStockReceived = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbWages = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvbLogIn = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbRegister = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbLogOut = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nvbLogIn,
            this.nvbHome,
            this.nvbProducts,
            this.nvbBills,
            this.nvbMemberManisger,
            this.nvbRegister,
            this.nvBarShoping,
            this.nvbLogOut,
            this.nvbStockReceived,
            this.nvbWages});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 156;
            this.navBarControl1.Size = new System.Drawing.Size(173, 481);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("DevExpress Dark Style");
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Menu";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbHome),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbProducts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbBills),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbMemberManisger),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvBarShoping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbStockReceived),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbWages)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.SmallImage")));
            // 
            // nvbHome
            // 
            this.nvbHome.Caption = "Home";
            this.nvbHome.Name = "nvbHome";
            this.nvbHome.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbHome.SmallImage")));
            this.nvbHome.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbHome_LinkClicked);
            // 
            // nvbProducts
            // 
            this.nvbProducts.Caption = "Products manager";
            this.nvbProducts.Name = "nvbProducts";
            this.nvbProducts.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbProducts.SmallImage")));
            this.nvbProducts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbProducts_LinkClicked);
            // 
            // nvbBills
            // 
            this.nvbBills.Caption = "Bill manager";
            this.nvbBills.Name = "nvbBills";
            this.nvbBills.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbBills.SmallImage")));
            this.nvbBills.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbBills_LinkClicked);
            // 
            // nvbMemberManisger
            // 
            this.nvbMemberManisger.Caption = "Member\'s manatger";
            this.nvbMemberManisger.Name = "nvbMemberManisger";
            this.nvbMemberManisger.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbMemberManisger.SmallImage")));
            this.nvbMemberManisger.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbMemberManisger_LinkClicked);
            // 
            // nvBarShoping
            // 
            this.nvBarShoping.Caption = "Shoping";
            this.nvBarShoping.Name = "nvBarShoping";
            this.nvBarShoping.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvBarShoping.SmallImage")));
            this.nvBarShoping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvBarShoping_LinkClicked);
            // 
            // nvbStockReceived
            // 
            this.nvbStockReceived.Caption = "Stock Manatger";
            this.nvbStockReceived.Name = "nvbStockReceived";
            this.nvbStockReceived.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbStockReceived.SmallImage")));
            this.nvbStockReceived.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbStockReceived_LinkClicked);
            // 
            // nvbWages
            // 
            this.nvbWages.Caption = "Wages Manager";
            this.nvbWages.Name = "nvbWages";
            this.nvbWages.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbWages.SmallImage")));
            this.nvbWages.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbWages_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Member\'s Option";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbLogIn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbRegister),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbLogOut)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // nvbLogIn
            // 
            this.nvbLogIn.Caption = "Log In";
            this.nvbLogIn.Name = "nvbLogIn";
            this.nvbLogIn.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbLogIn.SmallImage")));
            this.nvbLogIn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbLogIn_LinkClicked);
            // 
            // nvbRegister
            // 
            this.nvbRegister.Caption = "Register";
            this.nvbRegister.Name = "nvbRegister";
            this.nvbRegister.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbRegister.SmallImage")));
            this.nvbRegister.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbRegister_LinkClicked);
            // 
            // nvbLogOut
            // 
            this.nvbLogOut.Caption = "Log Out";
            this.nvbLogOut.Name = "nvbLogOut";
            this.nvbLogOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbLogOut.SmallImage")));
            this.nvbLogOut.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbLogOut_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 481);
            this.Controls.Add(this.navBarControl1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nvbLogIn;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nvbHome;
        private DevExpress.XtraNavBar.NavBarItem nvbProducts;
        private DevExpress.XtraNavBar.NavBarItem nvbBills;
        private DevExpress.XtraNavBar.NavBarItem nvbMemberManisger;
        private DevExpress.XtraNavBar.NavBarItem nvbRegister;
        private DevExpress.XtraNavBar.NavBarItem nvBarShoping;
        private DevExpress.XtraNavBar.NavBarItem nvbLogOut;
        private DevExpress.XtraNavBar.NavBarItem nvbStockReceived;
        private DevExpress.XtraNavBar.NavBarItem nvbWages;
    }
}