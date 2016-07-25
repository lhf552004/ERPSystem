namespace ERP
{
    partial class MainWinForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductHandling = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.StockStatic = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Receipt = new System.Windows.Forms.ToolStripMenuItem();
            this.RecepitSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Dispatch = new System.Windows.Forms.ToolStripMenuItem();
            this.DispatchSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Agent = new System.Windows.Forms.ToolStripMenuItem();
            this.AgentToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpectedReceiptAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpectedPayAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LogInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductHandling,
            this.StockStatic,
            this.Receipt,
            this.Dispatch,
            this.Agent,
            this.Account,
            this.Admin,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProductHandling
            // 
            this.ProductHandling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductManagement});
            this.ProductHandling.Name = "ProductHandling";
            this.ProductHandling.Size = new System.Drawing.Size(86, 25);
            this.ProductHandling.Text = "物料处理";
            // 
            // ProductManagement
            // 
            this.ProductManagement.Name = "ProductManagement";
            this.ProductManagement.Size = new System.Drawing.Size(144, 26);
            this.ProductManagement.Text = "物料管理";
            this.ProductManagement.Click += new System.EventHandler(this.ProductManagement_Click);
            // 
            // StockStatic
            // 
            this.StockStatic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticsMenu});
            this.StockStatic.Name = "StockStatic";
            this.StockStatic.Size = new System.Drawing.Size(86, 25);
            this.StockStatic.Text = "库存统计";
            // 
            // StatisticsMenu
            // 
            this.StatisticsMenu.Name = "StatisticsMenu";
            this.StatisticsMenu.Size = new System.Drawing.Size(144, 26);
            this.StatisticsMenu.Text = "库存统计";
            this.StatisticsMenu.Click += new System.EventHandler(this.StatisticsMenu_Click);
            // 
            // Receipt
            // 
            this.Receipt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecepitSubMenu});
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(54, 25);
            this.Receipt.Text = "收货";
            // 
            // RecepitSubMenu
            // 
            this.RecepitSubMenu.Name = "RecepitSubMenu";
            this.RecepitSubMenu.Size = new System.Drawing.Size(112, 26);
            this.RecepitSubMenu.Text = "收货";
            this.RecepitSubMenu.Click += new System.EventHandler(this.RecepitSubMenu_Click);
            // 
            // Dispatch
            // 
            this.Dispatch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DispatchSubMenu});
            this.Dispatch.Name = "Dispatch";
            this.Dispatch.Size = new System.Drawing.Size(54, 25);
            this.Dispatch.Text = "发货";
            // 
            // DispatchSubMenu
            // 
            this.DispatchSubMenu.Name = "DispatchSubMenu";
            this.DispatchSubMenu.Size = new System.Drawing.Size(112, 26);
            this.DispatchSubMenu.Text = "发货";
            this.DispatchSubMenu.Click += new System.EventHandler(this.DispatchSubMenu_Click);
            // 
            // Agent
            // 
            this.Agent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgentToolStripMenu});
            this.Agent.Name = "Agent";
            this.Agent.Size = new System.Drawing.Size(70, 25);
            this.Agent.Text = "代理商";
            // 
            // AgentToolStripMenu
            // 
            this.AgentToolStripMenu.Name = "AgentToolStripMenu";
            this.AgentToolStripMenu.Size = new System.Drawing.Size(160, 26);
            this.AgentToolStripMenu.Text = "代理商管理";
            this.AgentToolStripMenu.Click += new System.EventHandler(this.AgentToolStripMenu_Click);
            // 
            // Account
            // 
            this.Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpectedReceiptAccountMenuItem,
            this.ExpectedPayAccountMenuItem});
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(54, 25);
            this.Account.Text = "账款";
            // 
            // ExpectedReceiptAccountMenuItem
            // 
            this.ExpectedReceiptAccountMenuItem.Name = "ExpectedReceiptAccountMenuItem";
            this.ExpectedReceiptAccountMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ExpectedReceiptAccountMenuItem.Text = "应收账款";
            this.ExpectedReceiptAccountMenuItem.Click += new System.EventHandler(this.ExpectedReceiptAccountMenuItem_Click);
            // 
            // ExpectedPayAccountMenuItem
            // 
            this.ExpectedPayAccountMenuItem.Name = "ExpectedPayAccountMenuItem";
            this.ExpectedPayAccountMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ExpectedPayAccountMenuItem.Text = "应付账款";
            // 
            // Admin
            // 
            this.Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserManagementMenuItem,
            this.LoginMenuItem,
            this.LogoutMenuItem,
            this.ExitMenuItem});
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(54, 25);
            this.Admin.Text = "管理";
            // 
            // UserManagementMenuItem
            // 
            this.UserManagementMenuItem.Name = "UserManagementMenuItem";
            this.UserManagementMenuItem.Size = new System.Drawing.Size(144, 26);
            this.UserManagementMenuItem.Text = "用户管理";
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.BackgroundImage = global::Main.Properties.Resources.LogIn;
            this.LoginMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(144, 26);
            this.LoginMenuItem.Text = "登录";
            // 
            // LogoutMenuItem
            // 
            this.LogoutMenuItem.BackgroundImage = global::Main.Properties.Resources.LogOut;
            this.LogoutMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoutMenuItem.Name = "LogoutMenuItem";
            this.LogoutMenuItem.Size = new System.Drawing.Size(144, 26);
            this.LogoutMenuItem.Text = "注销";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.BackgroundImage = global::Main.Properties.Resources.Exit;
            this.ExitMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(144, 26);
            this.ExitMenuItem.Text = "退出";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutSubMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(54, 25);
            this.HelpMenu.Text = "帮助";
            // 
            // AboutSubMenu
            // 
            this.AboutSubMenu.Name = "AboutSubMenu";
            this.AboutSubMenu.Size = new System.Drawing.Size(112, 26);
            this.AboutSubMenu.Text = "关于";
            this.AboutSubMenu.Click += new System.EventHandler(this.AboutSubMenu_Click);
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.BackColor = System.Drawing.Color.White;
            this.UserNamelabel.Location = new System.Drawing.Point(549, 11);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(0, 12);
            this.UserNamelabel.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogInToolStripButton,
            this.LogoutToolStripButton,
            this.ExitToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(41, 233);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LogInToolStripButton
            // 
            this.LogInToolStripButton.AutoSize = false;
            this.LogInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogInToolStripButton.Image = global::Main.Properties.Resources.LogIn;
            this.LogInToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LogInToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogInToolStripButton.Name = "LogInToolStripButton";
            this.LogInToolStripButton.Size = new System.Drawing.Size(40, 40);
            this.LogInToolStripButton.Text = "toolStripButton1";
            // 
            // LogoutToolStripButton
            // 
            this.LogoutToolStripButton.AutoSize = false;
            this.LogoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogoutToolStripButton.Image = global::Main.Properties.Resources.LogOut;
            this.LogoutToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LogoutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutToolStripButton.Name = "LogoutToolStripButton";
            this.LogoutToolStripButton.Size = new System.Drawing.Size(40, 40);
            this.LogoutToolStripButton.Text = "toolStripButton1";
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.AutoSize = false;
            this.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitToolStripButton.Image = global::Main.Properties.Resources.Exit;
            this.ExitToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ExitToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(35, 35);
            this.ExitToolStripButton.Text = "toolStripButton1";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // MainWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(620, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWinForm";
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWinForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProductHandling;
        private System.Windows.Forms.ToolStripMenuItem ProductManagement;
        private System.Windows.Forms.ToolStripMenuItem Admin;
        private System.Windows.Forms.ToolStripMenuItem UserManagementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Receipt;
        private System.Windows.Forms.ToolStripMenuItem Dispatch;
        private System.Windows.Forms.ToolStripMenuItem StockStatic;
        private System.Windows.Forms.ToolStripMenuItem Agent;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem RecepitSubMenu;
        private System.Windows.Forms.ToolStripMenuItem StatisticsMenu;
        private System.Windows.Forms.ToolStripMenuItem DispatchSubMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LogInToolStripButton;
        private System.Windows.Forms.ToolStripButton LogoutToolStripButton;
        private System.Windows.Forms.ToolStripButton ExitToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem AboutSubMenu;
        private System.Windows.Forms.ToolStripMenuItem AgentToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem ExpectedReceiptAccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpectedPayAccountMenuItem;
    }
}