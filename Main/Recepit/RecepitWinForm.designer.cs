namespace ERP
{
    partial class RecepitWinForm
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
            this.RecepitGridView = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DetailPage = new System.Windows.Forms.TabPage();
            this.AuditButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.ReceiveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReceivalStateComBox = new System.Windows.Forms.ComboBox();
            this.auditStateComBox = new System.Windows.Forms.ComboBox();
            this.ReceiptDescription = new System.Windows.Forms.TextBox();
            this.ReceivalStateLabel = new System.Windows.Forms.Label();
            this.auditStateLabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.ReceiptName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ReceiptIdent = new System.Windows.Forms.TextBox();
            this.Identlabel = new System.Windows.Forms.Label();
            this.Ingredient = new System.Windows.Forms.TabPage();
            this.SelectedProduct = new System.Windows.Forms.ComboBox();
            this.ProdNum = new System.Windows.Forms.TextBox();
            this.SelectedProductLabel = new System.Windows.Forms.Label();
            this.ProdNumLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.AddIngre = new System.Windows.Forms.Button();
            this.IngreListGridView = new System.Windows.Forms.DataGridView();
            this.RemoveIngre = new System.Windows.Forms.Button();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FinishReceiptDate = new System.Windows.Forms.TextBox();
            this.FinishReceiptDateLabel = new System.Windows.Forms.Label();
            this.Operator = new System.Windows.Forms.TextBox();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.Auditor = new System.Windows.Forms.TextBox();
            this.AuditorLabel = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.TextBox();
            this.CreationDatelabel = new System.Windows.Forms.Label();
            this.ButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.ListgroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecepitGridView)).BeginInit();
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
            // RecepitGridView
            // 
            this.RecepitGridView.AllowUserToAddRows = false;
            this.RecepitGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecepitGridView.Location = new System.Drawing.Point(6, 19);
            this.RecepitGridView.Name = "RecepitGridView";
            this.RecepitGridView.RowTemplate.Height = 23;
            this.RecepitGridView.Size = new System.Drawing.Size(396, 150);
            this.RecepitGridView.TabIndex = 0;
            this.RecepitGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecepitGridView_CellClick);
            this.RecepitGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RecepitGridView_KeyUp);
            this.RecepitGridView.CursorChanged += new System.EventHandler(this.RecepitGridView_CursorChanged);
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
            this.DetailPage.Controls.Add(this.ReceiveButton);
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
            // ReceiveButton
            // 
            this.ReceiveButton.Location = new System.Drawing.Point(415, 94);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(75, 35);
            this.ReceiveButton.TabIndex = 2;
            this.ReceiveButton.Text = "收货";
            this.ReceiveButton.UseVisualStyleBackColor = true;
            this.ReceiveButton.Click += new System.EventHandler(this.ReceiveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReceivalStateComBox);
            this.groupBox1.Controls.Add(this.auditStateComBox);
            this.groupBox1.Controls.Add(this.ReceiptDescription);
            this.groupBox1.Controls.Add(this.ReceivalStateLabel);
            this.groupBox1.Controls.Add(this.auditStateLabel);
            this.groupBox1.Controls.Add(this.Descriptionlabel);
            this.groupBox1.Controls.Add(this.ReceiptName);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.ReceiptIdent);
            this.groupBox1.Controls.Add(this.Identlabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // ReceivalStateComBox
            // 
            this.ReceivalStateComBox.Enabled = false;
            this.ReceivalStateComBox.FormattingEnabled = true;
            this.ReceivalStateComBox.Location = new System.Drawing.Point(264, 85);
            this.ReceivalStateComBox.Name = "ReceivalStateComBox";
            this.ReceivalStateComBox.Size = new System.Drawing.Size(100, 20);
            this.ReceivalStateComBox.TabIndex = 10;
            // 
            // auditStateComBox
            // 
            this.auditStateComBox.Enabled = false;
            this.auditStateComBox.FormattingEnabled = true;
            this.auditStateComBox.Location = new System.Drawing.Point(61, 84);
            this.auditStateComBox.Name = "auditStateComBox";
            this.auditStateComBox.Size = new System.Drawing.Size(100, 20);
            this.auditStateComBox.TabIndex = 10;
            // 
            // ReceiptDescription
            // 
            this.ReceiptDescription.Location = new System.Drawing.Point(61, 49);
            this.ReceiptDescription.Multiline = true;
            this.ReceiptDescription.Name = "ReceiptDescription";
            this.ReceiptDescription.Size = new System.Drawing.Size(303, 21);
            this.ReceiptDescription.TabIndex = 5;
            this.ReceiptDescription.TextChanged += new System.EventHandler(this.ProdDescription_TextChanged);
            this.ReceiptDescription.Enter += new System.EventHandler(this.ReceiptDescription_Enter);
            // 
            // ReceivalStateLabel
            // 
            this.ReceivalStateLabel.AutoSize = true;
            this.ReceivalStateLabel.Location = new System.Drawing.Point(199, 88);
            this.ReceivalStateLabel.Name = "ReceivalStateLabel";
            this.ReceivalStateLabel.Size = new System.Drawing.Size(53, 12);
            this.ReceivalStateLabel.TabIndex = 4;
            this.ReceivalStateLabel.Text = "收货状态";
            // 
            // auditStateLabel
            // 
            this.auditStateLabel.AutoSize = true;
            this.auditStateLabel.Location = new System.Drawing.Point(7, 87);
            this.auditStateLabel.Name = "auditStateLabel";
            this.auditStateLabel.Size = new System.Drawing.Size(53, 12);
            this.auditStateLabel.TabIndex = 4;
            this.auditStateLabel.Text = "审核状态";
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
            // ReceiptName
            // 
            this.ReceiptName.Location = new System.Drawing.Point(264, 16);
            this.ReceiptName.Name = "ReceiptName";
            this.ReceiptName.Size = new System.Drawing.Size(100, 21);
            this.ReceiptName.TabIndex = 3;
            this.ReceiptName.TextChanged += new System.EventHandler(this.ProdName_TextChanged);
            this.ReceiptName.Enter += new System.EventHandler(this.ReceiptName_Enter);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(199, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "名称";
            // 
            // ReceiptIdent
            // 
            this.ReceiptIdent.Location = new System.Drawing.Point(61, 16);
            this.ReceiptIdent.Name = "ReceiptIdent";
            this.ReceiptIdent.Size = new System.Drawing.Size(100, 21);
            this.ReceiptIdent.TabIndex = 1;
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
            this.Ingredient.Controls.Add(this.SelectedProduct);
            this.Ingredient.Controls.Add(this.ProdNum);
            this.Ingredient.Controls.Add(this.SelectedProductLabel);
            this.Ingredient.Controls.Add(this.ProdNumLabel);
            this.Ingredient.Controls.Add(this.ConfirmButton);
            this.Ingredient.Controls.Add(this.AddIngre);
            this.Ingredient.Controls.Add(this.IngreListGridView);
            this.Ingredient.Controls.Add(this.RemoveIngre);
            this.Ingredient.Location = new System.Drawing.Point(4, 22);
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.Padding = new System.Windows.Forms.Padding(3);
            this.Ingredient.Size = new System.Drawing.Size(515, 160);
            this.Ingredient.TabIndex = 2;
            this.Ingredient.Text = "物料列表";
            this.Ingredient.UseVisualStyleBackColor = true;
            // 
            // SelectedProduct
            // 
            this.SelectedProduct.FormattingEnabled = true;
            this.SelectedProduct.Location = new System.Drawing.Point(96, 24);
            this.SelectedProduct.Name = "SelectedProduct";
            this.SelectedProduct.Size = new System.Drawing.Size(88, 20);
            this.SelectedProduct.TabIndex = 5;
            this.SelectedProduct.SelectedIndexChanged += new System.EventHandler(this.SelectedProduct_SelectedIndexChanged);
            // 
            // ProdNum
            // 
            this.ProdNum.Location = new System.Drawing.Point(256, 20);
            this.ProdNum.Name = "ProdNum";
            this.ProdNum.Size = new System.Drawing.Size(100, 21);
            this.ProdNum.TabIndex = 4;
            this.ProdNum.TextChanged += new System.EventHandler(this.ProdNum_TextChanged);
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
            // AddIngre
            // 
            this.AddIngre.Image = global::Main.Properties.Resources.Add;
            this.AddIngre.Location = new System.Drawing.Point(414, 47);
            this.AddIngre.Name = "AddIngre";
            this.AddIngre.Size = new System.Drawing.Size(38, 39);
            this.AddIngre.TabIndex = 1;
            this.AddIngre.UseVisualStyleBackColor = true;
            this.AddIngre.Click += new System.EventHandler(this.AddIngre_Click);
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
            // RemoveIngre
            // 
            this.RemoveIngre.Image = global::Main.Properties.Resources.Remove;
            this.RemoveIngre.Location = new System.Drawing.Point(414, 86);
            this.RemoveIngre.Name = "RemoveIngre";
            this.RemoveIngre.Size = new System.Drawing.Size(38, 40);
            this.RemoveIngre.TabIndex = 2;
            this.RemoveIngre.UseVisualStyleBackColor = true;
            this.RemoveIngre.Click += new System.EventHandler(this.RemoveIngre_Click);
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
            this.groupBox2.Controls.Add(this.FinishReceiptDate);
            this.groupBox2.Controls.Add(this.FinishReceiptDateLabel);
            this.groupBox2.Controls.Add(this.Operator);
            this.groupBox2.Controls.Add(this.OperatorLabel);
            this.groupBox2.Controls.Add(this.Auditor);
            this.groupBox2.Controls.Add(this.AuditorLabel);
            this.groupBox2.Controls.Add(this.CreationDate);
            this.groupBox2.Controls.Add(this.CreationDatelabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // FinishReceiptDate
            // 
            this.FinishReceiptDate.Enabled = false;
            this.FinishReceiptDate.Location = new System.Drawing.Point(292, 12);
            this.FinishReceiptDate.Name = "FinishReceiptDate";
            this.FinishReceiptDate.Size = new System.Drawing.Size(100, 21);
            this.FinishReceiptDate.TabIndex = 1;
            // 
            // FinishReceiptDateLabel
            // 
            this.FinishReceiptDateLabel.AutoSize = true;
            this.FinishReceiptDateLabel.Location = new System.Drawing.Point(214, 21);
            this.FinishReceiptDateLabel.Name = "FinishReceiptDateLabel";
            this.FinishReceiptDateLabel.Size = new System.Drawing.Size(77, 12);
            this.FinishReceiptDateLabel.TabIndex = 0;
            this.FinishReceiptDateLabel.Text = "完成收货日期";
            // 
            // Operator
            // 
            this.Operator.Enabled = false;
            this.Operator.Location = new System.Drawing.Point(292, 49);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(100, 21);
            this.Operator.TabIndex = 1;
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
            // Auditor
            // 
            this.Auditor.Enabled = false;
            this.Auditor.Location = new System.Drawing.Point(84, 49);
            this.Auditor.Name = "Auditor";
            this.Auditor.Size = new System.Drawing.Size(100, 21);
            this.Auditor.TabIndex = 1;
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
            // CreationDate
            // 
            this.CreationDate.Enabled = false;
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
            this.ListgroupBox.Controls.Add(this.RecepitGridView);
            this.ListgroupBox.Controls.Add(this.ButtonGroupBox);
            this.ListgroupBox.Location = new System.Drawing.Point(4, -3);
            this.ListgroupBox.Name = "ListgroupBox";
            this.ListgroupBox.Size = new System.Drawing.Size(529, 179);
            this.ListgroupBox.TabIndex = 6;
            this.ListgroupBox.TabStop = false;
            // 
            // RecepitWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 380);
            this.Controls.Add(this.ListgroupBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "RecepitWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收货";
            this.Load += new System.EventHandler(this.RecepitWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecepitGridView)).EndInit();
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

        private System.Windows.Forms.DataGridView RecepitGridView;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DetailPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ButtonGroupBox;
        private System.Windows.Forms.GroupBox ListgroupBox;
        private System.Windows.Forms.TextBox ReceiptDescription;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.TextBox ReceiptName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ReceiptIdent;
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
        private System.Windows.Forms.ComboBox auditStateComBox;
        private System.Windows.Forms.Label auditStateLabel;
        private System.Windows.Forms.TextBox FinishReceiptDate;
        private System.Windows.Forms.Label FinishReceiptDateLabel;
        private System.Windows.Forms.TextBox Auditor;
        private System.Windows.Forms.Label AuditorLabel;
        private System.Windows.Forms.TabPage Ingredient;
        private System.Windows.Forms.ComboBox ReceivalStateComBox;
        private System.Windows.Forms.Label ReceivalStateLabel;
        private System.Windows.Forms.Button AddIngre;
        private System.Windows.Forms.DataGridView IngreListGridView;
        private System.Windows.Forms.Button RemoveIngre;
        private System.Windows.Forms.TextBox ProdNum;
        private System.Windows.Forms.Label ProdNumLabel;
        private System.Windows.Forms.TextBox Operator;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.ComboBox SelectedProduct;
        private System.Windows.Forms.Label SelectedProductLabel;
        private System.Windows.Forms.Button AuditButton;
        private System.Windows.Forms.Button ReceiveButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}