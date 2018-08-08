namespace StockManagementSystem.UI
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.buttonIndicatorPanel = new System.Windows.Forms.Panel();
            this.salesInfoButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.stockOutButton = new System.Windows.Forms.Button();
            this.stockInButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.companyButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.headerTopPanel = new System.Windows.Forms.Panel();
            this.userIdentityLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.smsLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.headerTopPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.buttonIndicatorPanel);
            this.menuPanel.Controls.Add(this.salesInfoButton);
            this.menuPanel.Controls.Add(this.summaryButton);
            this.menuPanel.Controls.Add(this.aboutButton);
            this.menuPanel.Controls.Add(this.stockOutButton);
            this.menuPanel.Controls.Add(this.stockInButton);
            this.menuPanel.Controls.Add(this.itemButton);
            this.menuPanel.Controls.Add(this.companyButton);
            this.menuPanel.Controls.Add(this.categoryButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(207, 720);
            this.menuPanel.TabIndex = 1;
            // 
            // buttonIndicatorPanel
            // 
            this.buttonIndicatorPanel.BackColor = System.Drawing.Color.Tomato;
            this.buttonIndicatorPanel.Location = new System.Drawing.Point(0, 111);
            this.buttonIndicatorPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIndicatorPanel.Name = "buttonIndicatorPanel";
            this.buttonIndicatorPanel.Size = new System.Drawing.Size(11, 55);
            this.buttonIndicatorPanel.TabIndex = 1;
            // 
            // salesInfoButton
            // 
            this.salesInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesInfoButton.FlatAppearance.BorderSize = 0;
            this.salesInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesInfoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesInfoButton.ForeColor = System.Drawing.Color.White;
            this.salesInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("salesInfoButton.Image")));
            this.salesInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesInfoButton.Location = new System.Drawing.Point(21, 450);
            this.salesInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesInfoButton.Name = "salesInfoButton";
            this.salesInfoButton.Size = new System.Drawing.Size(183, 55);
            this.salesInfoButton.TabIndex = 6;
            this.salesInfoButton.Text = "  Sales Info";
            this.salesInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesInfoButton.UseVisualStyleBackColor = true;
            this.salesInfoButton.Click += new System.EventHandler(this.salesInfoButton_Click);
            this.salesInfoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.salesInfoButton_MouseDown);
            this.salesInfoButton.MouseLeave += new System.EventHandler(this.salesInfoButton_MouseLeave);
            this.salesInfoButton.MouseHover += new System.EventHandler(this.salesInfoButton_MouseHover);
            // 
            // summaryButton
            // 
            this.summaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.summaryButton.FlatAppearance.BorderSize = 0;
            this.summaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summaryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.ForeColor = System.Drawing.Color.White;
            this.summaryButton.Image = ((System.Drawing.Image)(resources.GetObject("summaryButton.Image")));
            this.summaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.summaryButton.Location = new System.Drawing.Point(21, 519);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(183, 55);
            this.summaryButton.TabIndex = 7;
            this.summaryButton.Text = "  Summary";
            this.summaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            this.summaryButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.summaryButton_MouseDown);
            this.summaryButton.MouseLeave += new System.EventHandler(this.summaryButton_MouseLeave);
            this.summaryButton.MouseHover += new System.EventHandler(this.summaryButton_MouseHover);
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(21, 587);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(183, 55);
            this.aboutButton.TabIndex = 8;
<<<<<<< HEAD
            this.aboutButton.Text = "  About Us";
=======
            this.aboutButton.Text = "  About";
>>>>>>> 77e4f1da0cbd62bfe7f1e0f83f913f45a0c75714
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            this.aboutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aboutButton_MouseDown);
            this.aboutButton.MouseLeave += new System.EventHandler(this.aboutButton_MouseLeave);
            this.aboutButton.MouseHover += new System.EventHandler(this.aboutButton_MouseHover);
            // 
            // stockOutButton
            // 
            this.stockOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockOutButton.FlatAppearance.BorderSize = 0;
            this.stockOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutButton.ForeColor = System.Drawing.Color.White;
            this.stockOutButton.Image = ((System.Drawing.Image)(resources.GetObject("stockOutButton.Image")));
            this.stockOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockOutButton.Location = new System.Drawing.Point(21, 383);
            this.stockOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockOutButton.Name = "stockOutButton";
            this.stockOutButton.Size = new System.Drawing.Size(183, 55);
            this.stockOutButton.TabIndex = 5;
            this.stockOutButton.Text = "  Stock Out";
            this.stockOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockOutButton.UseVisualStyleBackColor = true;
            this.stockOutButton.Click += new System.EventHandler(this.stockOutButton_Click);
            this.stockOutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stockOutButton_MouseDown);
            this.stockOutButton.MouseLeave += new System.EventHandler(this.stockOutButton_MouseLeave);
            this.stockOutButton.MouseHover += new System.EventHandler(this.stockOutButton_MouseHover);
            // 
            // stockInButton
            // 
            this.stockInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockInButton.FlatAppearance.BorderSize = 0;
            this.stockInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInButton.ForeColor = System.Drawing.Color.White;
            this.stockInButton.Image = ((System.Drawing.Image)(resources.GetObject("stockInButton.Image")));
            this.stockInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockInButton.Location = new System.Drawing.Point(21, 315);
            this.stockInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Size = new System.Drawing.Size(183, 55);
            this.stockInButton.TabIndex = 4;
            this.stockInButton.Text = "  Stock In";
            this.stockInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockInButton.UseVisualStyleBackColor = true;
            this.stockInButton.Click += new System.EventHandler(this.stockInButton_Click);
            this.stockInButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stockInButton_MouseDown);
            this.stockInButton.MouseLeave += new System.EventHandler(this.stockInButton_MouseLeave);
            this.stockInButton.MouseHover += new System.EventHandler(this.stockInButton_MouseHover);
            // 
            // itemButton
            // 
            this.itemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemButton.FlatAppearance.BorderSize = 0;
            this.itemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemButton.ForeColor = System.Drawing.Color.White;
            this.itemButton.Image = ((System.Drawing.Image)(resources.GetObject("itemButton.Image")));
            this.itemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemButton.Location = new System.Drawing.Point(21, 247);
            this.itemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(183, 55);
            this.itemButton.TabIndex = 3;
            this.itemButton.Text = "  Item";
            this.itemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            this.itemButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itemButton_MouseDown);
            this.itemButton.MouseLeave += new System.EventHandler(this.itemButton_MouseLeave);
            this.itemButton.MouseHover += new System.EventHandler(this.itemButton_MouseHover);
            // 
            // companyButton
            // 
            this.companyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.companyButton.FlatAppearance.BorderSize = 0;
            this.companyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyButton.ForeColor = System.Drawing.Color.White;
            this.companyButton.Image = ((System.Drawing.Image)(resources.GetObject("companyButton.Image")));
            this.companyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.companyButton.Location = new System.Drawing.Point(21, 178);
            this.companyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyButton.Name = "companyButton";
            this.companyButton.Size = new System.Drawing.Size(183, 55);
            this.companyButton.TabIndex = 2;
            this.companyButton.Text = "  Company";
            this.companyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.companyButton.UseVisualStyleBackColor = true;
            this.companyButton.Click += new System.EventHandler(this.companyButton_Click);
            this.companyButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.companyButton_MouseDown);
            this.companyButton.MouseLeave += new System.EventHandler(this.companyButton_MouseLeave);
            this.companyButton.MouseHover += new System.EventHandler(this.companyButton_MouseHover);
            // 
            // categoryButton
            // 
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Image = ((System.Drawing.Image)(resources.GetObject("categoryButton.Image")));
            this.categoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryButton.Location = new System.Drawing.Point(21, 111);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(183, 55);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "  Category ";
            this.categoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            this.categoryButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.categoryButton_MouseDown);
            this.categoryButton.MouseLeave += new System.EventHandler(this.categoryButton_MouseLeave);
            this.categoryButton.MouseHover += new System.EventHandler(this.categoryButton_MouseHover);
            // 
            // headerTopPanel
            // 
            this.headerTopPanel.BackColor = System.Drawing.Color.Tomato;
            this.headerTopPanel.Controls.Add(this.userIdentityLabel);
            this.headerTopPanel.Controls.Add(this.logOutButton);
            this.headerTopPanel.Controls.Add(this.minimizeButton);
            this.headerTopPanel.Controls.Add(this.homeButton);
            this.headerTopPanel.Controls.Add(this.closeButton);
            this.headerTopPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headerTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTopPanel.Location = new System.Drawing.Point(207, 0);
            this.headerTopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerTopPanel.Name = "headerTopPanel";
            this.headerTopPanel.Size = new System.Drawing.Size(1073, 52);
            this.headerTopPanel.TabIndex = 2;
            this.headerTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerTopPanel_MouseMove);
            // 
            // userIdentityLabel
            // 
            this.userIdentityLabel.AutoSize = true;
            this.userIdentityLabel.BackColor = System.Drawing.Color.Transparent;
            this.userIdentityLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdentityLabel.Location = new System.Drawing.Point(801, 5);
            this.userIdentityLabel.Name = "userIdentityLabel";
            this.userIdentityLabel.Size = new System.Drawing.Size(52, 17);
            this.userIdentityLabel.TabIndex = 5;
            this.userIdentityLabel.Text = "admin";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(861, -4);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(80, 34);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(973, 1);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(41, 46);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeButton.Location = new System.Drawing.Point(6, 9);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(34, 34);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(1020, 1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 46);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.formPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formPanel.Controls.Add(this.loginButton);
            this.formPanel.Controls.Add(this.passwordTextBox);
            this.formPanel.Controls.Add(this.userNameTextBox);
            this.formPanel.Controls.Add(this.companyNameLabel);
            this.formPanel.Controls.Add(this.smsLabel);
            this.formPanel.Controls.Add(this.welcomeLabel);
            this.formPanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPanel.Location = new System.Drawing.Point(207, 49);
            this.formPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1073, 672);
            this.formPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(962, 86);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(88, 28);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordTextBox.Location = new System.Drawing.Point(857, 55);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(193, 24);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userNameTextBox.Location = new System.Drawing.Point(857, 23);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(193, 24);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameTextBox.Click += new System.EventHandler(this.userNameTextBox_Click);
            this.userNameTextBox.Enter += new System.EventHandler(this.userNameTextBox_Enter);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyNameLabel.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.Black;
            this.companyNameLabel.Location = new System.Drawing.Point(347, 515);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(396, 57);
            this.companyNameLabel.TabIndex = 16;
            this.companyNameLabel.Text = "অমুক  Company Ltd.";
            // 
            // smsLabel
            // 
            this.smsLabel.AutoSize = true;
            this.smsLabel.BackColor = System.Drawing.Color.Transparent;
            this.smsLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsLabel.ForeColor = System.Drawing.Color.Black;
            this.smsLabel.Location = new System.Drawing.Point(227, 171);
            this.smsLabel.Name = "smsLabel";
            this.smsLabel.Size = new System.Drawing.Size(595, 52);
            this.smsLabel.TabIndex = 17;
            this.smsLabel.Text = "Stock Management System";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(395, 79);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(306, 70);
            this.welcomeLabel.TabIndex = 18;
            this.welcomeLabel.Text = "Welcome";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerTopPanel);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.headerTopPanel.ResumeLayout(false);
            this.headerTopPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel headerTopPanel;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button stockOutButton;
        private System.Windows.Forms.Button stockInButton;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Button companyButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Panel buttonIndicatorPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button salesInfoButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label userIdentityLabel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label smsLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}