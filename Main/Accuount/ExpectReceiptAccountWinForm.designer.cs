namespace ERP
{
    partial class ExpectReceiptAccountWinForm
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
            this.ExpectReceiptAccountGridView = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DetailPage = new System.Windows.Forms.TabPage();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProdDescription = new System.Windows.Forms.TextBox();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.ProdNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdIdent = new System.Windows.Forms.TextBox();
            this.Identlabel = new System.Windows.Forms.Label();
            this.MonthStatisticsPage = new System.Windows.Forms.TabPage();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.ReceivalStatistic = new System.Windows.Forms.TextBox();
            this.DispatchStatistic = new System.Windows.Forms.TextBox();
            this.SelectedMonth = new System.Windows.Forms.TextBox();
            this.ReceivalStatisticLabel = new System.Windows.Forms.Label();
            this.StatisticProdIdentLabel = new System.Windows.Forms.Label();
            this.DispatchStatisticLabel = new System.Windows.Forms.Label();
            this.SelectedMonthLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.ProdcomboBox = new System.Windows.Forms.ComboBox();
            this.MonthcomboBox = new System.Windows.Forms.ComboBox();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModifyUser = new System.Windows.Forms.TextBox();
            this.ModifyUserlabel = new System.Windows.Forms.Label();
            this.ModifyDate = new System.Windows.Forms.TextBox();
            this.ModifyDatelabel = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.TextBox();
            this.CreationDatelabel = new System.Windows.Forms.Label();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.ListgroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectReceiptAccountGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.DetailPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MonthStatisticsPage.SuspendLayout();
            this.HistoryPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ButtonGroupBox.SuspendLayout();
            this.ListgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExpectReceiptAccountGridView
            // 
            this.ExpectReceiptAccountGridView.AllowUserToAddRows = false;
            this.ExpectReceiptAccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpectReceiptAccountGridView.Location = new System.Drawing.Point(6, 19);
            this.ExpectReceiptAccountGridView.Name = "ExpectReceiptAccountGridView";
            this.ExpectReceiptAccountGridView.RowTemplate.Height = 23;
            this.ExpectReceiptAccountGridView.Size = new System.Drawing.Size(396, 150);
            this.ExpectReceiptAccountGridView.TabIndex = 0;
            this.ExpectReceiptAccountGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProStatisticsGridView_CellClick);
            this.ExpectReceiptAccountGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProStatisticsGridView_KeyDown);
            this.ExpectReceiptAccountGridView.SelectionChanged += new System.EventHandler(this.ProductGridView_SelectionChanged);
            this.ExpectReceiptAccountGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProStatisticsGridView_KeyUp);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(17, 20);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 35);
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "新建";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Visible = false;
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
            this.CopyButton.Visible = false;
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
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DetailPage);
            this.tabControl1.Controls.Add(this.MonthStatisticsPage);
            this.tabControl1.Controls.Add(this.HistoryPage);
            this.tabControl1.Location = new System.Drawing.Point(10, 182);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 173);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // DetailPage
            // 
            this.DetailPage.Controls.Add(this.ModifyButton);
            this.DetailPage.Controls.Add(this.groupBox1);
            this.DetailPage.Location = new System.Drawing.Point(4, 22);
            this.DetailPage.Name = "DetailPage";
            this.DetailPage.Padding = new System.Windows.Forms.Padding(3);
            this.DetailPage.Size = new System.Drawing.Size(515, 147);
            this.DetailPage.TabIndex = 0;
            this.DetailPage.Text = "细节";
            this.DetailPage.UseVisualStyleBackColor = true;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(415, 11);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 35);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "修改";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Visible = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProdDescription);
            this.groupBox1.Controls.Add(this.Descriptionlabel);
            this.groupBox1.Controls.Add(this.ProdNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProdIdent);
            this.groupBox1.Controls.Add(this.Identlabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // ProdDescription
            // 
            this.ProdDescription.Location = new System.Drawing.Point(61, 49);
            this.ProdDescription.Multiline = true;
            this.ProdDescription.Name = "ProdDescription";
            this.ProdDescription.Size = new System.Drawing.Size(303, 21);
            this.ProdDescription.TabIndex = 5;
            this.ProdDescription.TextChanged += new System.EventHandler(this.ProdDescription_TextChanged);
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(7, 54);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(29, 12);
            this.Descriptionlabel.TabIndex = 4;
            this.Descriptionlabel.Text = "备注";
            // 
            // ProdNum
            // 
            this.ProdNum.Enabled = false;
            this.ProdNum.Location = new System.Drawing.Point(264, 16);
            this.ProdNum.Name = "ProdNum";
            this.ProdNum.Size = new System.Drawing.Size(100, 21);
            this.ProdNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "结余数量";
            // 
            // ProdIdent
            // 
            this.ProdIdent.Enabled = false;
            this.ProdIdent.Location = new System.Drawing.Point(61, 16);
            this.ProdIdent.Name = "ProdIdent";
            this.ProdIdent.Size = new System.Drawing.Size(100, 21);
            this.ProdIdent.TabIndex = 1;
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
            // MonthStatisticsPage
            // 
            this.MonthStatisticsPage.Controls.Add(this.StatisticsButton);
            this.MonthStatisticsPage.Controls.Add(this.ReceivalStatistic);
            this.MonthStatisticsPage.Controls.Add(this.DispatchStatistic);
            this.MonthStatisticsPage.Controls.Add(this.SelectedMonth);
            this.MonthStatisticsPage.Controls.Add(this.ReceivalStatisticLabel);
            this.MonthStatisticsPage.Controls.Add(this.StatisticProdIdentLabel);
            this.MonthStatisticsPage.Controls.Add(this.DispatchStatisticLabel);
            this.MonthStatisticsPage.Controls.Add(this.SelectedMonthLabel);
            this.MonthStatisticsPage.Controls.Add(this.MonthLabel);
            this.MonthStatisticsPage.Controls.Add(this.ProdcomboBox);
            this.MonthStatisticsPage.Controls.Add(this.MonthcomboBox);
            this.MonthStatisticsPage.Location = new System.Drawing.Point(4, 22);
            this.MonthStatisticsPage.Name = "MonthStatisticsPage";
            this.MonthStatisticsPage.Padding = new System.Windows.Forms.Padding(3);
            this.MonthStatisticsPage.Size = new System.Drawing.Size(515, 147);
            this.MonthStatisticsPage.TabIndex = 2;
            this.MonthStatisticsPage.Text = "月统计";
            this.MonthStatisticsPage.UseVisualStyleBackColor = true;
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Location = new System.Drawing.Point(416, 16);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(75, 36);
            this.StatisticsButton.TabIndex = 4;
            this.StatisticsButton.Text = "统计";
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // ReceivalStatistic
            // 
            this.ReceivalStatistic.Enabled = false;
            this.ReceivalStatistic.Location = new System.Drawing.Point(280, 48);
            this.ReceivalStatistic.Name = "ReceivalStatistic";
            this.ReceivalStatistic.Size = new System.Drawing.Size(100, 21);
            this.ReceivalStatistic.TabIndex = 3;
            // 
            // DispatchStatistic
            // 
            this.DispatchStatistic.Enabled = false;
            this.DispatchStatistic.Location = new System.Drawing.Point(280, 16);
            this.DispatchStatistic.Name = "DispatchStatistic";
            this.DispatchStatistic.Size = new System.Drawing.Size(100, 21);
            this.DispatchStatistic.TabIndex = 3;
            // 
            // SelectedMonth
            // 
            this.SelectedMonth.Enabled = false;
            this.SelectedMonth.Location = new System.Drawing.Point(280, 80);
            this.SelectedMonth.Name = "SelectedMonth";
            this.SelectedMonth.Size = new System.Drawing.Size(100, 21);
            this.SelectedMonth.TabIndex = 3;
            // 
            // ReceivalStatisticLabel
            // 
            this.ReceivalStatisticLabel.AutoSize = true;
            this.ReceivalStatisticLabel.Location = new System.Drawing.Point(212, 52);
            this.ReceivalStatisticLabel.Name = "ReceivalStatisticLabel";
            this.ReceivalStatisticLabel.Size = new System.Drawing.Size(53, 12);
            this.ReceivalStatisticLabel.TabIndex = 2;
            this.ReceivalStatisticLabel.Text = "收货统计";
            // 
            // StatisticProdIdentLabel
            // 
            this.StatisticProdIdentLabel.AutoSize = true;
            this.StatisticProdIdentLabel.Location = new System.Drawing.Point(8, 56);
            this.StatisticProdIdentLabel.Name = "StatisticProdIdentLabel";
            this.StatisticProdIdentLabel.Size = new System.Drawing.Size(53, 12);
            this.StatisticProdIdentLabel.TabIndex = 2;
            this.StatisticProdIdentLabel.Text = "物料代码";
            // 
            // DispatchStatisticLabel
            // 
            this.DispatchStatisticLabel.AutoSize = true;
            this.DispatchStatisticLabel.Location = new System.Drawing.Point(212, 20);
            this.DispatchStatisticLabel.Name = "DispatchStatisticLabel";
            this.DispatchStatisticLabel.Size = new System.Drawing.Size(53, 12);
            this.DispatchStatisticLabel.TabIndex = 2;
            this.DispatchStatisticLabel.Text = "发货统计";
            // 
            // SelectedMonthLabel
            // 
            this.SelectedMonthLabel.AutoSize = true;
            this.SelectedMonthLabel.Location = new System.Drawing.Point(212, 84);
            this.SelectedMonthLabel.Name = "SelectedMonthLabel";
            this.SelectedMonthLabel.Size = new System.Drawing.Size(53, 12);
            this.SelectedMonthLabel.TabIndex = 2;
            this.SelectedMonthLabel.Text = "选择月份";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(8, 20);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(53, 12);
            this.MonthLabel.TabIndex = 1;
            this.MonthLabel.Text = "月份选择";
            // 
            // ProdcomboBox
            // 
            this.ProdcomboBox.FormattingEnabled = true;
            this.ProdcomboBox.Location = new System.Drawing.Point(72, 52);
            this.ProdcomboBox.Name = "ProdcomboBox";
            this.ProdcomboBox.Size = new System.Drawing.Size(121, 20);
            this.ProdcomboBox.TabIndex = 0;
            // 
            // MonthcomboBox
            // 
            this.MonthcomboBox.FormattingEnabled = true;
            this.MonthcomboBox.Location = new System.Drawing.Point(72, 16);
            this.MonthcomboBox.Name = "MonthcomboBox";
            this.MonthcomboBox.Size = new System.Drawing.Size(121, 20);
            this.MonthcomboBox.TabIndex = 0;
            // 
            // HistoryPage
            // 
            this.HistoryPage.Controls.Add(this.groupBox2);
            this.HistoryPage.Location = new System.Drawing.Point(4, 22);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryPage.Size = new System.Drawing.Size(515, 147);
            this.HistoryPage.TabIndex = 1;
            this.HistoryPage.Text = "历史";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModifyUser);
            this.groupBox2.Controls.Add(this.ModifyUserlabel);
            this.groupBox2.Controls.Add(this.ModifyDate);
            this.groupBox2.Controls.Add(this.ModifyDatelabel);
            this.groupBox2.Controls.Add(this.CreationDate);
            this.groupBox2.Controls.Add(this.CreationDatelabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史";
            // 
            // ModifyUser
            // 
            this.ModifyUser.Location = new System.Drawing.Point(292, 12);
            this.ModifyUser.Name = "ModifyUser";
            this.ModifyUser.Size = new System.Drawing.Size(100, 21);
            this.ModifyUser.TabIndex = 1;
            // 
            // ModifyUserlabel
            // 
            this.ModifyUserlabel.AutoSize = true;
            this.ModifyUserlabel.Location = new System.Drawing.Point(214, 21);
            this.ModifyUserlabel.Name = "ModifyUserlabel";
            this.ModifyUserlabel.Size = new System.Drawing.Size(41, 12);
            this.ModifyUserlabel.TabIndex = 0;
            this.ModifyUserlabel.Text = "修改人";
            // 
            // ModifyDate
            // 
            this.ModifyDate.Location = new System.Drawing.Point(84, 40);
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.Size = new System.Drawing.Size(100, 21);
            this.ModifyDate.TabIndex = 1;
            // 
            // ModifyDatelabel
            // 
            this.ModifyDatelabel.AutoSize = true;
            this.ModifyDatelabel.Location = new System.Drawing.Point(6, 49);
            this.ModifyDatelabel.Name = "ModifyDatelabel";
            this.ModifyDatelabel.Size = new System.Drawing.Size(53, 12);
            this.ModifyDatelabel.TabIndex = 0;
            this.ModifyDatelabel.Text = "修改日期";
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(84, 11);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(100, 21);
            this.CreationDate.TabIndex = 1;
            // 
            // CreationDatelabel
            // 
            this.CreationDatelabel.AutoSize = true;
            this.CreationDatelabel.Location = new System.Drawing.Point(6, 20);
            this.CreationDatelabel.Name = "CreationDatelabel";
            this.CreationDatelabel.Size = new System.Drawing.Size(53, 12);
            this.CreationDatelabel.TabIndex = 0;
            this.CreationDatelabel.Text = "创建日期";
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
            this.ListgroupBox.Controls.Add(this.ExpectReceiptAccountGridView);
            this.ListgroupBox.Controls.Add(this.ButtonGroupBox);
            this.ListgroupBox.Location = new System.Drawing.Point(4, -3);
            this.ListgroupBox.Name = "ListgroupBox";
            this.ListgroupBox.Size = new System.Drawing.Size(529, 179);
            this.ListgroupBox.TabIndex = 6;
            this.ListgroupBox.TabStop = false;
            // 
            // ExpectReceiptAccountWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 367);
            this.Controls.Add(this.ListgroupBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExpectReceiptAccountWinForm";
            this.Text = "应收账款";
            ((System.ComponentModel.ISupportInitialize)(this.ExpectReceiptAccountGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.DetailPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MonthStatisticsPage.ResumeLayout(false);
            this.MonthStatisticsPage.PerformLayout();
            this.HistoryPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ListgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExpectReceiptAccountGridView;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DetailPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.GroupBox ListgroupBox;
        private System.Windows.Forms.TextBox ProdDescription;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.TextBox ProdNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdIdent;
        private System.Windows.Forms.Label Identlabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.TabPage HistoryPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CreationDate;
        private System.Windows.Forms.Label CreationDatelabel;
        //private System.Windows.Forms.TextBox ModifyDate;
        //private System.Windows.Forms.Label ModifyDatelabel;
        //private System.Windows.Forms.TextBox ModifyUser;
        //private System.Windows.Forms.Label ModifyUserlabel;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.TextBox ModifyUser;
        private System.Windows.Forms.Label ModifyUserlabel;
        private System.Windows.Forms.TextBox ModifyDate;
        private System.Windows.Forms.Label ModifyDatelabel;
        private System.Windows.Forms.TabPage MonthStatisticsPage;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.ComboBox MonthcomboBox;
        private System.Windows.Forms.TextBox SelectedMonth;
        private System.Windows.Forms.Label SelectedMonthLabel;
        private System.Windows.Forms.TextBox ReceivalStatistic;
        private System.Windows.Forms.TextBox DispatchStatistic;
        private System.Windows.Forms.Label ReceivalStatisticLabel;
        private System.Windows.Forms.Label DispatchStatisticLabel;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.Label StatisticProdIdentLabel;
        private System.Windows.Forms.ComboBox ProdcomboBox;
    }
}