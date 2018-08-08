namespace StockManagementSystem.UI
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.userSetGroupBox = new System.Windows.Forms.GroupBox();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.passwordSetTextBox = new System.Windows.Forms.TextBox();
            this.userNameSetTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.userSetupLabel = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.userSetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userSetGroupBox
            // 
            this.userSetGroupBox.Controls.Add(this.userRadioButton);
            this.userSetGroupBox.Controls.Add(this.adminRadioButton);
            this.userSetGroupBox.Controls.Add(this.warningLabel);
            this.userSetGroupBox.Controls.Add(this.label3);
            this.userSetGroupBox.Controls.Add(this.label2);
            this.userSetGroupBox.Controls.Add(this.userGridView);
            this.userSetGroupBox.Controls.Add(this.passwordSetTextBox);
            this.userSetGroupBox.Controls.Add(this.userNameSetTextBox);
            this.userSetGroupBox.Controls.Add(this.addButton);
            this.userSetGroupBox.Location = new System.Drawing.Point(148, 110);
            this.userSetGroupBox.Name = "userSetGroupBox";
            this.userSetGroupBox.Size = new System.Drawing.Size(776, 511);
            this.userSetGroupBox.TabIndex = 8;
            this.userSetGroupBox.TabStop = false;
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRadioButton.ForeColor = System.Drawing.Color.Black;
            this.userRadioButton.Location = new System.Drawing.Point(377, 107);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(60, 22);
            this.userRadioButton.TabIndex = 5;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadioButton.ForeColor = System.Drawing.Color.Black;
            this.adminRadioButton.Location = new System.Drawing.Point(293, 107);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(77, 22);
            this.adminRadioButton.TabIndex = 4;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(295, 151);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 18);
            this.warningLabel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(186, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(179, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.AllowUserToDeleteRows = false;
            this.userGridView.AutoGenerateColumns = false;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.passWordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.Delete});
            this.userGridView.DataSource = this.userBindingSource;
            this.userGridView.Location = new System.Drawing.Point(48, 222);
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            this.userGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(677, 247);
            this.userGridView.TabIndex = 3;
            this.userGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellContentClick);
            this.userGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.userGridView_DataBindingComplete);
            // 
            // passwordSetTextBox
            // 
            this.passwordSetTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSetTextBox.Location = new System.Drawing.Point(293, 64);
            this.passwordSetTextBox.Name = "passwordSetTextBox";
            this.passwordSetTextBox.Size = new System.Drawing.Size(286, 30);
            this.passwordSetTextBox.TabIndex = 1;
            // 
            // userNameSetTextBox
            // 
            this.userNameSetTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameSetTextBox.Location = new System.Drawing.Point(293, 25);
            this.userNameSetTextBox.Name = "userNameSetTextBox";
            this.userNameSetTextBox.Size = new System.Drawing.Size(286, 30);
            this.userNameSetTextBox.TabIndex = 1;
            this.userNameSetTextBox.TextChanged += new System.EventHandler(this.userNameSetTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(483, 141);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 37);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userSetupLabel
            // 
            this.userSetupLabel.AutoSize = true;
            this.userSetupLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSetupLabel.ForeColor = System.Drawing.Color.Black;
            this.userSetupLabel.Location = new System.Drawing.Point(439, 52);
            this.userSetupLabel.Name = "userSetupLabel";
            this.userSetupLabel.Size = new System.Drawing.Size(168, 37);
            this.userSetupLabel.TabIndex = 7;
            this.userSetupLabel.Text = "User Setup";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(StockManagementSystem.Models.User);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.userNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.userNameDataGridViewTextBoxColumn.FillWeight = 100.7618F;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // passWordDataGridViewTextBoxColumn
            // 
            this.passWordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passWordDataGridViewTextBoxColumn.DataPropertyName = "PassWord";
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.passWordDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.passWordDataGridViewTextBoxColumn.FillWeight = 5.660782F;
            this.passWordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passWordDataGridViewTextBoxColumn.Name = "passWordDataGridViewTextBoxColumn";
            this.passWordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.userTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Width = 103;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delete.HeaderText = "      ";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 34;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 672);
            this.Controls.Add(this.userSetGroupBox);
            this.Controls.Add(this.userSetupLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.userSetGroupBox.ResumeLayout(false);
            this.userSetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox userSetGroupBox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.TextBox passwordSetTextBox;
        private System.Windows.Forms.TextBox userNameSetTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label userSetupLabel;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}