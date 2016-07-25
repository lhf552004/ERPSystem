namespace ERP
{
    partial class AgentManagementWinForm
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
            this.AgentGridView = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DetailPage = new System.Windows.Forms.TabPage();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.ModifyUserText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ModifyUserLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdentText = new System.Windows.Forms.TextBox();
            this.Identlabel = new System.Windows.Forms.Label();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.ListgroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgentGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.DetailPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ButtonGroupBox.SuspendLayout();
            this.ListgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgentGridView
            // 
            this.AgentGridView.AllowUserToAddRows = false;
            this.AgentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgentGridView.Location = new System.Drawing.Point(6, 19);
            this.AgentGridView.Name = "AgentGridView";
            this.AgentGridView.RowTemplate.Height = 23;
            this.AgentGridView.Size = new System.Drawing.Size(396, 150);
            this.AgentGridView.TabIndex = 0;
            this.AgentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecepitGridView_CellClick);
            this.AgentGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RecepitGridView_KeyUp);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(17, 20);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 35);
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "新建";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(17, 66);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 35);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "复制";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(17, 112);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 35);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DetailPage);
            this.tabControl1.Location = new System.Drawing.Point(10, 182);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 186);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // DetailPage
            // 
            this.DetailPage.Controls.Add(this.ModifyButton);
            this.DetailPage.Controls.Add(this.groupBox1);
            this.DetailPage.Location = new System.Drawing.Point(4, 22);
            this.DetailPage.Name = "DetailPage";
            this.DetailPage.Padding = new System.Windows.Forms.Padding(3);
            this.DetailPage.Size = new System.Drawing.Size(515, 160);
            this.DetailPage.TabIndex = 0;
            this.DetailPage.Text = "细节";
            this.DetailPage.UseVisualStyleBackColor = true;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Enabled = false;
            this.ModifyButton.Location = new System.Drawing.Point(415, 11);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 35);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "修改";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LevelComboBox);
            this.groupBox1.Controls.Add(this.AddressText);
            this.groupBox1.Controls.Add(this.DescriptionText);
            this.groupBox1.Controls.Add(this.AddressLabel);
            this.groupBox1.Controls.Add(this.Descriptionlabel);
            this.groupBox1.Controls.Add(this.ModifyUserText);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Controls.Add(this.LevelLabel);
            this.groupBox1.Controls.Add(this.ModifyUserLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.IdentText);
            this.groupBox1.Controls.Add(this.Identlabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Location = new System.Drawing.Point(61, 104);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(99, 20);
            this.LevelComboBox.TabIndex = 6;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(62, 75);
            this.AddressText.Multiline = true;
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(303, 21);
            this.AddressText.TabIndex = 5;
            this.AddressText.TextChanged += new System.EventHandler(this.ProdDescription_TextChanged);
            this.AddressText.Enter += new System.EventHandler(this.ReceiptDescription_Enter);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(61, 45);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(303, 21);
            this.DescriptionText.TabIndex = 5;
            this.DescriptionText.TextChanged += new System.EventHandler(this.ProdDescription_TextChanged);
            this.DescriptionText.Enter += new System.EventHandler(this.ReceiptDescription_Enter);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(8, 80);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(29, 12);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "地址";
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(7, 50);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(29, 12);
            this.Descriptionlabel.TabIndex = 4;
            this.Descriptionlabel.Text = "备注";
            // 
            // ModifyUserText
            // 
            this.ModifyUserText.Enabled = false;
            this.ModifyUserText.Location = new System.Drawing.Point(261, 102);
            this.ModifyUserText.Name = "ModifyUserText";
            this.ModifyUserText.Size = new System.Drawing.Size(100, 21);
            this.ModifyUserText.TabIndex = 3;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(264, 20);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 21);
            this.NameText.TabIndex = 3;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(8, 108);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(29, 12);
            this.LevelLabel.TabIndex = 2;
            this.LevelLabel.Text = "级别";
            // 
            // ModifyUserLabel
            // 
            this.ModifyUserLabel.AutoSize = true;
            this.ModifyUserLabel.Location = new System.Drawing.Point(196, 108);
            this.ModifyUserLabel.Name = "ModifyUserLabel";
            this.ModifyUserLabel.Size = new System.Drawing.Size(41, 12);
            this.ModifyUserLabel.TabIndex = 2;
            this.ModifyUserLabel.Text = "修改者";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(199, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "名称";
            // 
            // IdentText
            // 
            this.IdentText.Enabled = false;
            this.IdentText.Location = new System.Drawing.Point(61, 16);
            this.IdentText.Name = "IdentText";
            this.IdentText.Size = new System.Drawing.Size(100, 21);
            this.IdentText.TabIndex = 1;
            // 
            // Identlabel
            // 
            this.Identlabel.AutoSize = true;
            this.Identlabel.Location = new System.Drawing.Point(7, 21);
            this.Identlabel.Name = "Identlabel";
            this.Identlabel.Size = new System.Drawing.Size(29, 12);
            this.Identlabel.TabIndex = 0;
            this.Identlabel.Text = "代码";
            // 
            // ButtonGroupBox
            // 
            this.ButtonGroupBox.Controls.Add(this.NewButton);
            this.ButtonGroupBox.Controls.Add(this.DeleteButton);
            this.ButtonGroupBox.Controls.Add(this.CopyButton);
            this.ButtonGroupBox.Location = new System.Drawing.Point(408, 9);
            this.ButtonGroupBox.Name = "ButtonGroupBox";
            this.ButtonGroupBox.Size = new System.Drawing.Size(114, 159);
            this.ButtonGroupBox.TabIndex = 5;
            this.ButtonGroupBox.TabStop = false;
            // 
            // ListgroupBox
            // 
            this.ListgroupBox.Controls.Add(this.AgentGridView);
            this.ListgroupBox.Controls.Add(this.ButtonGroupBox);
            this.ListgroupBox.Location = new System.Drawing.Point(4, -3);
            this.ListgroupBox.Name = "ListgroupBox";
            this.ListgroupBox.Size = new System.Drawing.Size(529, 179);
            this.ListgroupBox.TabIndex = 6;
            this.ListgroupBox.TabStop = false;
            // 
            // AgentManagementWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 380);
            this.Controls.Add(this.ListgroupBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "AgentManagementWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代理商";
            this.Load += new System.EventHandler(this.DispatchWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgentGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.DetailPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ListgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AgentGridView;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DetailPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.GroupBox ListgroupBox;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IdentText;
        private System.Windows.Forms.Label Identlabel;
        private System.Windows.Forms.Label Categorylabel;
        //private System.Windows.Forms.TextBox ModifyDate;
        //private System.Windows.Forms.Label ModifyDatelabel;
        //private System.Windows.Forms.TextBox ModifyUser;
        //private System.Windows.Forms.Label ModifyUserlabel;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.TextBox ModifyUserText;
        private System.Windows.Forms.Label ModifyUserLabel;
    }
}