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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.avialableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sellButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.lostButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lostButton);
            this.groupBox1.Controls.Add(this.damageButton);
            this.groupBox1.Controls.Add(this.sellButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
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
            this.groupBox1.Location = new System.Drawing.Point(78, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 564);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // companyComboBox
            // 
            this.companyComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(353, 19);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(286, 29);
            this.companyComboBox.TabIndex = 7;
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
            this.label3.Location = new System.Drawing.Point(178, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reorder Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock In Quantity";
            // 
            // itemComboBox
            // 
            this.itemComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(353, 97);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(286, 29);
            this.itemComboBox.TabIndex = 7;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(353, 58);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(286, 29);
            this.categoryComboBox.TabIndex = 7;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(353, 136);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.ReadOnly = true;
            this.reorderLevelTextBox.Size = new System.Drawing.Size(286, 30);
            this.reorderLevelTextBox.TabIndex = 5;
            // 
            // avialableQuantityTextBox
            // 
            this.avialableQuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avialableQuantityTextBox.Location = new System.Drawing.Point(353, 176);
            this.avialableQuantityTextBox.Name = "avialableQuantityTextBox";
            this.avialableQuantityTextBox.ReadOnly = true;
            this.avialableQuantityTextBox.Size = new System.Drawing.Size(286, 30);
            this.avialableQuantityTextBox.TabIndex = 5;
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(353, 216);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(286, 30);
            this.stockInQuantityTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(701, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 136);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 21);
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
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 240);
            this.dataGridView1.TabIndex = 8;
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(459, 514);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(96, 37);
            this.sellButton.TabIndex = 9;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // damageButton
            // 
            this.damageButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageButton.Location = new System.Drawing.Point(597, 514);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(118, 37);
            this.damageButton.TabIndex = 9;
            this.damageButton.Text = "Damage";
            this.damageButton.UseVisualStyleBackColor = true;
            // 
            // lostButton
            // 
            this.lostButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostButton.Location = new System.Drawing.Point(757, 514);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(96, 37);
            this.lostButton.TabIndex = 9;
            this.lostButton.Text = "Lost";
            this.lostButton.UseVisualStyleBackColor = true;
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockOutForm";
            this.Text = "StockOut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.Button sellButton;
    }
}