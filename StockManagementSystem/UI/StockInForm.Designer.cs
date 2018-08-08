namespace StockManagementSystem.UI
{
    partial class StockInForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.avialableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.itemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.stockInQuantityTextBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(208, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 425);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource1;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(283, 54);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(286, 29);
            this.companyComboBox.TabIndex = 7;
            this.companyComboBox.Text = "        -----------Select-----------";
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            this.companyComboBox.Click += new System.EventHandler(this.companyComboBox_Click);
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataSource = typeof(StockManagementSystem.Models.Company);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reorder Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock In Quantity";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(283, 148);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(286, 29);
            this.itemComboBox.TabIndex = 7;
            this.itemComboBox.Text = "        -----------Select-----------";
            this.itemComboBox.ValueMember = "Id";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.companyBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(283, 101);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(286, 29);
            this.categoryComboBox.TabIndex = 7;
            this.categoryComboBox.Tag = "";
            this.categoryComboBox.Text = "        -----------Select-----------";
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystem.Models.Company);
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(283, 195);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.ReadOnly = true;
            this.reorderLevelTextBox.Size = new System.Drawing.Size(286, 30);
            this.reorderLevelTextBox.TabIndex = 5;
            // 
            // avialableQuantityTextBox
            // 
            this.avialableQuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avialableQuantityTextBox.Location = new System.Drawing.Point(283, 243);
            this.avialableQuantityTextBox.Name = "avialableQuantityTextBox";
            this.avialableQuantityTextBox.ReadOnly = true;
            this.avialableQuantityTextBox.Size = new System.Drawing.Size(286, 30);
            this.avialableQuantityTextBox.TabIndex = 5;
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(283, 291);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(286, 30);
            this.stockInQuantityTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(473, 339);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 37);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comapny";
            // 
            // itemBindingSource2
            // 
            this.itemBindingSource2.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Models.Category);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Stock In ";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // itemBindingSource3
            // 
            this.itemBindingSource3.DataSource = typeof(StockManagementSystem.Models.Item);
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockInForm";
            this.Text = "StockInForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox avialableQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.BindingSource itemBindingSource2;
        private System.Windows.Forms.BindingSource itemBindingSource3;
        private System.Windows.Forms.BindingSource companyBindingSource1;
    }
}