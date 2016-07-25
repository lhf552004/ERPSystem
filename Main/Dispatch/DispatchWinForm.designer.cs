namespace ERP
{
    partial class DispatchWinForm
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
            this.DispatchGridView = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DetailPage = new System.Windows.Forms.TabPage();
            this.AuditButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DispatchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DispatchStateComBox = new System.Windows.Forms.ComboBox();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.AuditStateComBox = new System.Windows.Forms.ComboBox();
            this.DispatchDescriptionText = new System.Windows.Forms.TextBox();
            this.DispatchStateLabel = new System.Windows.Forms.Label();
            this.AgentComboBoxLabel = new System.Windows.Forms.Label();
            this.auditStateLabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.DispatchtotalPriceText = new System.Windows.Forms.TextBox();
            this.DispatchtotalPriceLabel = new System.Windows.Forms.Label();
            this.IdentText = new System.Windows.Forms.TextBox();
            this.Identlabel = new System.Windows.Forms.Label();
            this.Ingredient = new System.Windows.Forms.TabPage();
            this.SelectedProductComBox = new System.Windows.Forms.ComboBox();
            this.ProdNumText = new System.Windows.Forms.TextBox();
            this.SelectedProductLabel = new System.Windows.Forms.Label();
            this.ProdNumLabel = new System.Windows.Forms.Label();
            this.IngreListGridView = new System.Windows.Forms.DataGridView();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.AddIngreButton = new System.Windows.Forms.Button();
            this.RemoveIngreButton = new System.Windows.Forms.Button();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DispatchDateText = new System.Windows.Forms.TextBox();
            this.FinishReceiptDateLabel = new System.Windows.Forms.Label();
            this.OperatorText = new System.Windows.Forms.TextBox();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.AuditorText = new System.Windows.Forms.TextBox();
            this.AuditorLabel = new System.Windows.Forms.Label();
            this.CreationDateText = new System.Windows.Forms.TextBox();
            this.CreationDatelabel = new System.Windows.Forms.Label();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.ListgroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DispatchGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.DetailPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Ingredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngreListGridView)).BeginInit();
            this.HistoryPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ButtonGroupBox.SuspendLayout();
            this.ListgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DispatchGridView
            // 
            this.DispatchGridView.AllowUserToAddRows = false;
            this.DispatchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispatchGridView.Location = new System.Drawing.Point(6, 19);
            this.DispatchGridView.Name = "DispatchGridView";
            this.DispatchGridView.RowTemplate.Height = 23;
            this.DispatchGridView.Size = new System.Drawing.Size(396, 150);
            this.DispatchGridView.TabIndex = 0;
            this.DispatchGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecepitGridView_CellClick);
            this.DispatchGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RecepitGridView_KeyUp);
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
            this.tabControl1.Controls.Add(this.Ingredient);
            this.tabControl1.Controls.Add(this.HistoryPage);
            this.tabControl1.Location = new System.Drawing.Point(10, 182);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 186);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // DetailPage
            // 
            this.DetailPage.Controls.Add(this.AuditButton);
            this.DetailPage.Controls.Add(this.ModifyButton);
            this.DetailPage.Controls.Add(this.DispatchButton);
            this.DetailPage.Controls.Add(this.groupBox1);
            this.DetailPage.Location = new System.Drawing.Point(4, 22);
            this.DetailPage.Name = "DetailPage";
            this.DetailPage.Padding = new System.Windows.Forms.Padding(3);
            this.DetailPage.Size = new System.Drawing.Size(515, 160);
            this.DetailPage.TabIndex = 0;
            this.DetailPage.Text = "细节";
            this.DetailPage.UseVisualStyleBackColor = true;
            // 
            // AuditButton
            // 
            this.AuditButton.Enabled = false;
            this.AuditButton.Location = new System.Drawing.Point(415, 52);
            this.AuditButton.Name = "AuditButton";
            this.AuditButton.Size = new System.Drawing.Size(75, 35);
            this.AuditButton.TabIndex = 4;
            this.AuditButton.Text = "审核";
            this.AuditButton.UseVisualStyleBackColor = true;
            this.AuditButton.Click += new System.EventHandler(this.AuditButton_Click);
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
            // DispatchButton
            // 
            this.DispatchButton.Location = new System.Drawing.Point(415, 94);
            this.DispatchButton.Name = "DispatchButton";
            this.DispatchButton.Size = new System.Drawing.Size(75, 35);
            this.DispatchButton.TabIndex = 2;
            this.DispatchButton.Text = "发货";
            this.DispatchButton.UseVisualStyleBackColor = true;
            this.DispatchButton.Click += new System.EventHandler(this.DispatchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DispatchStateComBox);
            this.groupBox1.Controls.Add(this.AgentComboBox);
            this.groupBox1.Controls.Add(this.AuditStateComBox);
            this.groupBox1.Controls.Add(this.DispatchDescriptionText);
            this.groupBox1.Controls.Add(this.DispatchStateLabel);
            this.groupBox1.Controls.Add(this.AgentComboBoxLabel);
            this.groupBox1.Controls.Add(this.auditStateLabel);
            this.groupBox1.Controls.Add(this.Descriptionlabel);
            this.groupBox1.Controls.Add(this.DispatchtotalPriceText);
            this.groupBox1.Controls.Add(this.DispatchtotalPriceLabel);
            this.groupBox1.Controls.Add(this.IdentText);
            this.groupBox1.Controls.Add(this.Identlabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // DispatchStateComBox
            // 
            this.DispatchStateComBox.Enabled = false;
            this.DispatchStateComBox.FormattingEnabled = true;
            this.DispatchStateComBox.Location = new System.Drawing.Point(264, 74);
            this.DispatchStateComBox.Name = "DispatchStateComBox";
            this.DispatchStateComBox.Size = new System.Drawing.Size(100, 20);
            this.DispatchStateComBox.TabIndex = 10;
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(264, 16);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(100, 20);
            this.AgentComboBox.TabIndex = 10;
            this.AgentComboBox.SelectedIndexChanged += new System.EventHandler(this.AgentComboBox_SelectedIndexChanged);
            // 
            // AuditStateComBox
            // 
            this.AuditStateComBox.Enabled = false;
            this.AuditStateComBox.FormattingEnabled = true;
            this.AuditStateComBox.Location = new System.Drawing.Point(61, 74);
            this.AuditStateComBox.Name = "AuditStateComBox";
            this.AuditStateComBox.Size = new System.Drawing.Size(100, 20);
            this.AuditStateComBox.TabIndex = 10;
            // 
            // DispatchDescriptionText
            // 
            this.DispatchDescriptionText.Location = new System.Drawing.Point(61, 45);
            this.DispatchDescriptionText.Multiline = true;
            this.DispatchDescriptionText.Name = "DispatchDescriptionText";
            this.DispatchDescriptionText.Size = new System.Drawing.Size(303, 21);
            this.DispatchDescriptionText.TabIndex = 5;
            this.DispatchDescriptionText.TextChanged += new System.EventHandler(this.ProdDescription_TextChanged);
            this.DispatchDescriptionText.Enter += new System.EventHandler(this.ReceiptDescription_Enter);
            // 
            // DispatchStateLabel
            // 
            this.DispatchStateLabel.AutoSize = true;
            this.DispatchStateLabel.Location = new System.Drawing.Point(199, 79);
            this.DispatchStateLabel.Name = "DispatchStateLabel";
            this.DispatchStateLabel.Size = new System.Drawing.Size(53, 12);
            this.DispatchStateLabel.TabIndex = 4;
            this.DispatchStateLabel.Text = "发货状态";
            // 
            // AgentComboBoxLabel
            // 
            this.AgentComboBoxLabel.AutoSize = true;
            this.AgentComboBoxLabel.Location = new System.Drawing.Point(204, 21);
            this.AgentComboBoxLabel.Name = "AgentComboBoxLabel";
            this.AgentComboBoxLabel.Size = new System.Drawing.Size(41, 12);
            this.AgentComboBoxLabel.TabIndex = 4;
            this.AgentComboBoxLabel.Text = "代理商";
            // 
            // auditStateLabel
            // 
            this.auditStateLabel.AutoSize = true;
            this.auditStateLabel.Location = new System.Drawing.Point(7, 79);
            this.auditStateLabel.Name = "auditStateLabel";
            this.auditStateLabel.Size = new System.Drawing.Size(53, 12);
            this.auditStateLabel.TabIndex = 4;
            this.auditStateLabel.Text = "审核状态";
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
            // DispatchtotalPriceText
            // 
            this.DispatchtotalPriceText.Enabled = false;
            this.DispatchtotalPriceText.Location = new System.Drawing.Point(61, 102);
            this.DispatchtotalPriceText.Name = "DispatchtotalPriceText";
            this.DispatchtotalPriceText.Size = new System.Drawing.Size(100, 21);
            this.DispatchtotalPriceText.TabIndex = 3;
            // 
            // DispatchtotalPriceLabel
            // 
            this.DispatchtotalPriceLabel.AutoSize = true;
            this.DispatchtotalPriceLabel.Location = new System.Drawing.Point(7, 108);
            this.DispatchtotalPriceLabel.Name = "DispatchtotalPriceLabel";
            this.DispatchtotalPriceLabel.Size = new System.Drawing.Size(29, 12);
            this.DispatchtotalPriceLabel.TabIndex = 2;
            this.DispatchtotalPriceLabel.Text = "总价";
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
            // Ingredient
            // 
            this.Ingredient.Controls.Add(this.SelectedProductComBox);
            this.Ingredient.Controls.Add(this.ProdNumText);
            this.Ingredient.Controls.Add(this.SelectedProductLabel);
            this.Ingredient.Controls.Add(this.ProdNumLabel);
            this.Ingredient.Controls.Add(this.IngreListGridView);
            this.Ingredient.Controls.Add(this.ConfirmButton);
            this.Ingredient.Controls.Add(this.AddIngreButton);
            this.Ingredient.Controls.Add(this.RemoveIngreButton);
            this.Ingredient.Location = new System.Drawing.Point(4, 22);
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.Padding = new System.Windows.Forms.Padding(3);
            this.Ingredient.Size = new System.Drawing.Size(515, 160);
            this.Ingredient.TabIndex = 2;
            this.Ingredient.Text = "物料列表";
            this.Ingredient.UseVisualStyleBackColor = true;
            // 
            // SelectedProductComBox
            // 
            this.SelectedProductComBox.FormattingEnabled = true;
            this.SelectedProductComBox.Location = new System.Drawing.Point(96, 24);
            this.SelectedProductComBox.Name = "SelectedProductComBox";
            this.SelectedProductComBox.Size = new System.Drawing.Size(88, 20);
            this.SelectedProductComBox.TabIndex = 5;
            this.SelectedProductComBox.SelectedIndexChanged += new System.EventHandler(this.SelectedProduct_SelectedIndexChanged);
            // 
            // ProdNumText
            // 
            this.ProdNumText.Location = new System.Drawing.Point(256, 20);
            this.ProdNumText.Name = "ProdNumText";
            this.ProdNumText.Size = new System.Drawing.Size(100, 21);
            this.ProdNumText.TabIndex = 4;
            // 
            // SelectedProductLabel
            // 
            this.SelectedProductLabel.AutoSize = true;
            this.SelectedProductLabel.Location = new System.Drawing.Point(48, 28);
            this.SelectedProductLabel.Name = "SelectedProductLabel";
            this.SelectedProductLabel.Size = new System.Drawing.Size(29, 12);
            this.SelectedProductLabel.TabIndex = 3;
            this.SelectedProductLabel.Text = "物料";
            // 
            // ProdNumLabel
            // 
            this.ProdNumLabel.AutoSize = true;
            this.ProdNumLabel.Location = new System.Drawing.Point(212, 28);
            this.ProdNumLabel.Name = "ProdNumLabel";
            this.ProdNumLabel.Size = new System.Drawing.Size(29, 12);
            this.ProdNumLabel.TabIndex = 3;
            this.ProdNumLabel.Text = "数量";
            // 
            // IngreListGridView
            // 
            this.IngreListGridView.AllowUserToAddRows = false;
            this.IngreListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngreListGridView.Location = new System.Drawing.Point(4, 48);
            this.IngreListGridView.Name = "IngreListGridView";
            this.IngreListGridView.RowTemplate.Height = 23;
            this.IngreListGridView.Size = new System.Drawing.Size(388, 104);
            this.IngreListGridView.TabIndex = 0;
            this.IngreListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngreListGridView_CellClick);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Image = global::Main.Properties.Resources.Ok;
            this.ConfirmButton.Location = new System.Drawing.Point(414, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(38, 43);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AddIngreButton
            // 
            this.AddIngreButton.Image = global::Main.Properties.Resources.Add;
            this.AddIngreButton.Location = new System.Drawing.Point(414, 47);
            this.AddIngreButton.Name = "AddIngreButton";
            this.AddIngreButton.Size = new System.Drawing.Size(38, 39);
            this.AddIngreButton.TabIndex = 1;
            this.AddIngreButton.UseVisualStyleBackColor = true;
            this.AddIngreButton.Click += new System.EventHandler(this.AddIngre_Click);
            // 
            // RemoveIngreButton
            // 
            this.RemoveIngreButton.Image = global::Main.Properties.Resources.Remove;
            this.RemoveIngreButton.Location = new System.Drawing.Point(414, 86);
            this.RemoveIngreButton.Name = "RemoveIngreButton";
            this.RemoveIngreButton.Size = new System.Drawing.Size(38, 40);
            this.RemoveIngreButton.TabIndex = 2;
            this.RemoveIngreButton.UseVisualStyleBackColor = true;
            this.RemoveIngreButton.Click += new System.EventHandler(this.RemoveIngre_Click);
            // 
            // HistoryPage
            // 
            this.HistoryPage.Controls.Add(this.groupBox2);
            this.HistoryPage.Location = new System.Drawing.Point(4, 22);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryPage.Size = new System.Drawing.Size(515, 160);
            this.HistoryPage.TabIndex = 1;
            this.HistoryPage.Text = "历史";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DispatchDateText);
            this.groupBox2.Controls.Add(this.FinishReceiptDateLabel);
            this.groupBox2.Controls.Add(this.OperatorText);
            this.groupBox2.Controls.Add(this.OperatorLabel);
            this.groupBox2.Controls.Add(this.AuditorText);
            this.groupBox2.Controls.Add(this.AuditorLabel);
            this.groupBox2.Controls.Add(this.CreationDateText);
            this.groupBox2.Controls.Add(this.CreationDatelabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // DispatchDateText
            // 
            this.DispatchDateText.Enabled = false;
            this.DispatchDateText.Location = new System.Drawing.Point(292, 20);
            this.DispatchDateText.Name = "DispatchDateText";
            this.DispatchDateText.Size = new System.Drawing.Size(100, 21);
            this.DispatchDateText.TabIndex = 1;
            // 
            // FinishReceiptDateLabel
            // 
            this.FinishReceiptDateLabel.AutoSize = true;
            this.FinishReceiptDateLabel.Location = new System.Drawing.Point(214, 29);
            this.FinishReceiptDateLabel.Name = "FinishReceiptDateLabel";
            this.FinishReceiptDateLabel.Size = new System.Drawing.Size(77, 12);
            this.FinishReceiptDateLabel.TabIndex = 0;
            this.FinishReceiptDateLabel.Text = "完成收货日期";
            // 
            // OperatorText
            // 
            this.OperatorText.Enabled = false;
            this.OperatorText.Location = new System.Drawing.Point(292, 49);
            this.OperatorText.Name = "OperatorText";
            this.OperatorText.Size = new System.Drawing.Size(100, 21);
            this.OperatorText.TabIndex = 1;
            // 
            // OperatorLabel
            // 
            this.OperatorLabel.AutoSize = true;
            this.OperatorLabel.Location = new System.Drawing.Point(214, 49);
            this.OperatorLabel.Name = "OperatorLabel";
            this.OperatorLabel.Size = new System.Drawing.Size(41, 12);
            this.OperatorLabel.TabIndex = 0;
            this.OperatorLabel.Text = "操作员";
            // 
            // AuditorText
            // 
            this.AuditorText.Enabled = false;
            this.AuditorText.Location = new System.Drawing.Point(84, 49);
            this.AuditorText.Name = "AuditorText";
            this.AuditorText.Size = new System.Drawing.Size(100, 21);
            this.AuditorText.TabIndex = 1;
            // 
            // AuditorLabel
            // 
            this.AuditorLabel.AutoSize = true;
            this.AuditorLabel.Location = new System.Drawing.Point(6, 49);
            this.AuditorLabel.Name = "AuditorLabel";
            this.AuditorLabel.Size = new System.Drawing.Size(41, 12);
            this.AuditorLabel.TabIndex = 0;
            this.AuditorLabel.Text = "审核者";
            // 
            // CreationDateText
            // 
            this.CreationDateText.Enabled = false;
            this.CreationDateText.Location = new System.Drawing.Point(84, 19);
            this.CreationDateText.Name = "CreationDateText";
            this.CreationDateText.Size = new System.Drawing.Size(100, 21);
            this.CreationDateText.TabIndex = 1;
            // 
            // CreationDatelabel
            // 
            this.CreationDatelabel.AutoSize = true;
            this.CreationDatelabel.Location = new System.Drawing.Point(6, 28);
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
            this.ListgroupBox.Controls.Add(this.DispatchGridView);
            this.ListgroupBox.Controls.Add(this.ButtonGroupBox);
            this.ListgroupBox.Location = new System.Drawing.Point(4, -3);
            this.ListgroupBox.Name = "ListgroupBox";
            this.ListgroupBox.Size = new System.Drawing.Size(529, 179);
            this.ListgroupBox.TabIndex = 6;
            this.ListgroupBox.TabStop = false;
            // 
            // DispatchWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 380);
            this.Controls.Add(this.ListgroupBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "DispatchWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发货";
            this.Load += new System.EventHandler(this.DispatchWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DispatchGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.DetailPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Ingredient.ResumeLayout(false);
            this.Ingredient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngreListGridView)).EndInit();
            this.HistoryPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ButtonGroupBox.ResumeLayout(false);
            this.ListgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DispatchGridView;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DetailPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.GroupBox ListgroupBox;
        private System.Windows.Forms.TextBox DispatchDescriptionText;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.TextBox DispatchtotalPriceText;
        private System.Windows.Forms.Label DispatchtotalPriceLabel;
        private System.Windows.Forms.TextBox IdentText;
        private System.Windows.Forms.Label Identlabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.TabPage HistoryPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CreationDateText;
        private System.Windows.Forms.Label CreationDatelabel;
        //private System.Windows.Forms.TextBox ModifyDate;
        //private System.Windows.Forms.Label ModifyDatelabel;
        //private System.Windows.Forms.TextBox ModifyUser;
        //private System.Windows.Forms.Label ModifyUserlabel;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.ComboBox AuditStateComBox;
        private System.Windows.Forms.Label auditStateLabel;
        private System.Windows.Forms.TextBox DispatchDateText;
        private System.Windows.Forms.Label FinishReceiptDateLabel;
        private System.Windows.Forms.TextBox AuditorText;
        private System.Windows.Forms.Label AuditorLabel;
        private System.Windows.Forms.TabPage Ingredient;
        private System.Windows.Forms.ComboBox DispatchStateComBox;
        private System.Windows.Forms.Label DispatchStateLabel;
        private System.Windows.Forms.Button AddIngreButton;
        private System.Windows.Forms.DataGridView IngreListGridView;
        private System.Windows.Forms.Button RemoveIngreButton;
        private System.Windows.Forms.TextBox ProdNumText;
        private System.Windows.Forms.Label ProdNumLabel;
        private System.Windows.Forms.TextBox OperatorText;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.ComboBox SelectedProductComBox;
        private System.Windows.Forms.Label SelectedProductLabel;
        private System.Windows.Forms.Button AuditButton;
        private System.Windows.Forms.Button DispatchButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private System.Windows.Forms.Label AgentComboBoxLabel;
    }
}