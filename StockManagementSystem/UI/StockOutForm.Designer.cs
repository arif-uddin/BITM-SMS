namespace StockManagementSystem.UI
{
    partial class StockOutForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lostButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.stockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.avialableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lostButton);
            this.groupBox1.Controls.Add(this.damageButton);
            this.groupBox1.Controls.Add(this.sellButton);
            this.groupBox1.Controls.Add(this.stockOutDataGridView);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemComboBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.reorderLevelTextBox);
            this.groupBox1.Controls.Add(this.avialableQuantityTextBox);
            this.groupBox1.Controls.Add(this.stockOutQuantityTextBox);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(77, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(908, 564);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lostButton
            // 
            this.lostButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostButton.Location = new System.Drawing.Point(757, 514);
            this.lostButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(96, 37);
            this.lostButton.TabIndex = 9;
            this.lostButton.Text = "Lost";
            this.lostButton.UseVisualStyleBackColor = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageButton.Location = new System.Drawing.Point(597, 514);
            this.damageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(117, 37);
            this.damageButton.TabIndex = 9;
            this.damageButton.Text = "Damage";
            this.damageButton.UseVisualStyleBackColor = true;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(459, 514);
            this.sellButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(96, 37);
            this.sellButton.TabIndex = 9;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // stockOutDataGridView
            // 
            this.stockOutDataGridView.AllowUserToAddRows = false;
            this.stockOutDataGridView.AllowUserToDeleteRows = false;
            this.stockOutDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGridView.Location = new System.Drawing.Point(57, 263);
            this.stockOutDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockOutDataGridView.Name = "stockOutDataGridView";
            this.stockOutDataGridView.ReadOnly = true;
            this.stockOutDataGridView.RowTemplate.Height = 24;
            this.stockOutDataGridView.Size = new System.Drawing.Size(796, 240);
            this.stockOutDataGridView.TabIndex = 8;
            this.stockOutDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.stockOutDataGridView_DataBindingComplete);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(353, 18);
            this.companyComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(287, 29);
            this.companyComboBox.TabIndex = 7;
            this.companyComboBox.Text = "     -------------Select-------------";
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            this.companyComboBox.Click += new System.EventHandler(this.companyComboBox_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystem.Models.Company);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reorder Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Out Quantity";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(353, 97);
            this.itemComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(287, 29);
            this.itemComboBox.TabIndex = 7;
            this.itemComboBox.Text = "     -------------Select-------------";
            this.itemComboBox.ValueMember = "Id";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(353, 58);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(287, 29);
            this.categoryComboBox.TabIndex = 7;
            this.categoryComboBox.Text = "     -------------Select-------------";
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Models.Category);
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(353, 135);
            this.reorderLevelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.ReadOnly = true;
            this.reorderLevelTextBox.Size = new System.Drawing.Size(287, 30);
            this.reorderLevelTextBox.TabIndex = 5;
            // 
            // avialableQuantityTextBox
            // 
            this.avialableQuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avialableQuantityTextBox.Location = new System.Drawing.Point(353, 176);
            this.avialableQuantityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avialableQuantityTextBox.Name = "avialableQuantityTextBox";
            this.avialableQuantityTextBox.ReadOnly = true;
            this.avialableQuantityTextBox.Size = new System.Drawing.Size(287, 30);
            this.avialableQuantityTextBox.TabIndex = 5;
            // 
            // stockOutQuantityTextBox
            // 
            this.stockOutQuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutQuantityTextBox.Location = new System.Drawing.Point(353, 217);
            this.stockOutQuantityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockOutQuantityTextBox.Name = "stockOutQuantityTextBox";
            this.stockOutQuantityTextBox.Size = new System.Drawing.Size(287, 30);
            this.stockOutQuantityTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(701, 58);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 135);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comapny";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stock Out";
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockOutForm";
            this.Text = "StockOut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox avialableQuantityTextBox;
        private System.Windows.Forms.TextBox stockOutQuantityTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stockOutDataGridView;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}