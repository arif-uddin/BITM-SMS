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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.headerTopPanel.SuspendLayout();
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
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(207, 720);
            this.menuPanel.TabIndex = 0;
            // 
            // buttonIndicatorPanel
            // 
            this.buttonIndicatorPanel.BackColor = System.Drawing.Color.Tomato;
            this.buttonIndicatorPanel.Location = new System.Drawing.Point(0, 111);
            this.buttonIndicatorPanel.Name = "buttonIndicatorPanel";
            this.buttonIndicatorPanel.Size = new System.Drawing.Size(11, 55);
            this.buttonIndicatorPanel.TabIndex = 2;
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
            this.salesInfoButton.Location = new System.Drawing.Point(21, 456);
            this.salesInfoButton.Name = "salesInfoButton";
            this.salesInfoButton.Size = new System.Drawing.Size(183, 55);
            this.salesInfoButton.TabIndex = 2;
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
            this.summaryButton.Location = new System.Drawing.Point(21, 525);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(183, 55);
            this.summaryButton.TabIndex = 2;
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
            this.aboutButton.Location = new System.Drawing.Point(21, 594);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(183, 55);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "  About";
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
            this.stockOutButton.Location = new System.Drawing.Point(21, 387);
            this.stockOutButton.Name = "stockOutButton";
            this.stockOutButton.Size = new System.Drawing.Size(183, 55);
            this.stockOutButton.TabIndex = 2;
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
            this.stockInButton.Location = new System.Drawing.Point(21, 318);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Size = new System.Drawing.Size(183, 55);
            this.stockInButton.TabIndex = 2;
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
            this.itemButton.Location = new System.Drawing.Point(21, 111);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(183, 55);
            this.itemButton.TabIndex = 2;
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
            this.companyButton.Location = new System.Drawing.Point(21, 249);
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
            this.categoryButton.Location = new System.Drawing.Point(21, 180);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(183, 55);
            this.categoryButton.TabIndex = 2;
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
            this.headerTopPanel.Controls.Add(this.minimizeButton);
            this.headerTopPanel.Controls.Add(this.closeButton);
            this.headerTopPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headerTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTopPanel.Location = new System.Drawing.Point(207, 0);
            this.headerTopPanel.Name = "headerTopPanel";
            this.headerTopPanel.Size = new System.Drawing.Size(1073, 52);
            this.headerTopPanel.TabIndex = 1;
            this.headerTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerTopPanel_MouseMove);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(973, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(41, 45);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(1020, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 45);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.Silver;
            this.formPanel.Location = new System.Drawing.Point(207, 52);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1073, 672);
            this.formPanel.TabIndex = 2;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerTopPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.menuPanel.ResumeLayout(false);
            this.headerTopPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button salesInfoButton;
        private System.Windows.Forms.Button summaryButton;
    }
}