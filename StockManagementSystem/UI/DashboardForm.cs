using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using StockManagementSystem.BLL;
using StockManagementSystem.Models;

namespace StockManagementSystem.UI
{
    public partial class DashboardForm : Form
    {

        //From move with Movedawn start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //From move with Movedawn end

        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        //sql connection
        private SqlConnection connection;


        FormCommon _common = new FormCommon();

       

        public DashboardForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
           
        }
        
        
        //Begin of Button Mousehover color change
        private void categoryButton_MouseHover(object sender, EventArgs e)
        {
            categoryButton.BackColor = Color.DarkGreen;
        }

        private void categoryButton_MouseLeave(object sender, EventArgs e)
        {
            categoryButton.ResetBackColor();
        }

        private void companyButton_MouseHover(object sender, EventArgs e)
        {
            companyButton.BackColor = Color.DarkGreen;
        }

        private void itemButton_MouseHover(object sender, EventArgs e)
        {
            itemButton.BackColor = Color.DarkGreen;
        }

        private void stockOutButton_MouseHover(object sender, EventArgs e)
        {
            stockOutButton.BackColor = Color.DarkGreen;
        }

        private void aboutButton_MouseHover(object sender, EventArgs e)
        {
            aboutButton.BackColor = Color.DarkGreen;
        }

        private void companyButton_MouseLeave(object sender, EventArgs e)
        {
            companyButton.ResetBackColor();
        }

        private void itemButton_MouseLeave(object sender, EventArgs e)
        {
            itemButton.ResetBackColor();
        }

        private void stockOutButton_MouseLeave(object sender, EventArgs e)
        {
            stockOutButton.ResetBackColor();
        }

        private void aboutButton_MouseLeave(object sender, EventArgs e)
        {
            aboutButton.ResetBackColor();
        }

        private void stockInButton_MouseHover(object sender, EventArgs e)
        {
            stockInButton.BackColor = Color.DarkGreen;
        }

        private void stockInButton_MouseLeave(object sender, EventArgs e)
        {
            stockInButton.ResetBackColor();
        }

        private void itemButton_MouseDown(object sender, MouseEventArgs e)
        {
            itemButton.BackColor = Color.DarkGreen;
        }

        private void categoryButton_MouseDown(object sender, MouseEventArgs e)
        {
            categoryButton.BackColor = Color.DarkGreen;
        }

        private void companyButton_MouseDown(object sender, MouseEventArgs e)
        {
            companyButton.BackColor = Color.DarkGreen;
        }

        private void stockInButton_MouseDown(object sender, MouseEventArgs e)
        {
            stockInButton.BackColor = Color.DarkGreen;
        }

        private void stockOutButton_MouseDown(object sender, MouseEventArgs e)
        {
            stockOutButton.BackColor = Color.DarkGreen;
        }

        private void aboutButton_MouseDown(object sender, MouseEventArgs e)
        {
            aboutButton.BackColor = Color.DarkGreen;
        }


        private void salesInfoButton_MouseHover(object sender, EventArgs e)
        {
            salesInfoButton.BackColor = Color.DarkGreen;
        }

        private void salesInfoButton_MouseLeave(object sender, EventArgs e)
        {
            salesInfoButton.ResetBackColor();
        }

        private void salesInfoButton_MouseDown(object sender, MouseEventArgs e)
        {
            salesInfoButton.BackColor = Color.DarkGreen;
        }

        private void summaryButton_MouseHover(object sender, EventArgs e)
        {
            summaryButton.BackColor = Color.DarkGreen;
        }

        private void summaryButton_MouseLeave(object sender, EventArgs e)
        {
            summaryButton.ResetBackColor();
        }

        private void summaryButton_MouseDown(object sender, MouseEventArgs e)
        {
            summaryButton.BackColor = Color.DarkGreen;
        }
        //End of Button Mousehover color change


        //button indicator move ,Form appear
        public void itemButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;

            ItemForm _itemForm = new ItemForm();
            ButtonIndicatorMove(itemButton);
            ShowForm(_itemForm);

        }
        private void categoryButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;

            CategoryForm _categoryForm = new CategoryForm();
            ButtonIndicatorMove(categoryButton);
            ShowForm(_categoryForm);
        }

        private void companyButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;
            CompanyForm _companyForm = new CompanyForm();
            ButtonIndicatorMove(companyButton);
            ShowForm(_companyForm);
           
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;
            StockInForm _stockInForm = new StockInForm();
            ButtonIndicatorMove(stockInButton);
            ShowForm(_stockInForm);
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;
            StockOutForm _stockOutForm = new StockOutForm();
            ButtonIndicatorMove(stockOutButton);
            ShowForm(_stockOutForm);
        }

        private void salesInfoButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;
            SalesInfoForm _salesInfoForm = new SalesInfoForm();
            ButtonIndicatorMove(salesInfoButton);
            ShowForm(_salesInfoForm);
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;
            SummaryForm _summaryForm = new SummaryForm();
            ButtonIndicatorMove(summaryButton);
            ShowForm(_summaryForm);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Visible = true;
            AboutForm _aboutForm = new AboutForm();
            ButtonIndicatorMove(aboutButton);
            ShowForm(_aboutForm);
        }


        //Close Button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //bodyMove with mousedown

        private void headerTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        //Methods
        private void ShowForm(Form form)
        {
            CloseAlreadyOpenedForms();
            form.TopLevel = false;

            form.AutoScroll = true;
            formPanel.Controls.Add(form);
            
            form.Show();
            if (form.Visible)
            {
                form.BringToFront();
            }

        }

        private void CloseAlreadyOpenedForms()
        {
            var openforms = Application.OpenForms;
            List<Form> forms = new List<Form>();

            foreach (Form f in openforms )
            {
                if (f.Name != this.Name)
                {
                    forms.Add(f);
                }
            }

            foreach (var form in forms)
            {
                form.Close();
            }
        }

        private void ButtonIndicatorMove(Button buttonName)
        {
            buttonIndicatorPanel.Height = buttonName.Height;
            buttonIndicatorPanel.Top = buttonName.Top;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
                User user = new User();
                user.userName = userNameTextBox.Text;
                user.PassWord = passwordTextBox.Text;

                UserManager UserMan = new UserManager();
                int userType = UserMan.Login(user);

                if (userType == 1)
                {
                    categoryButton.Enabled = true;
                    companyButton.Enabled = true;
                    itemButton.Enabled = true;
                    stockInButton.Enabled = true;
                    stockOutButton.Enabled = true;
                    salesInfoButton.Enabled = true;
                    summaryButton.Enabled = true;
                    aboutButton.Enabled = true;
                    homeButton.Visible = true;
                    LoggedInUi();
                
                }
                else if (userType == 2)
                {
                    stockOutButton.Enabled = true;
                    salesInfoButton.Enabled = true;
                    summaryButton.Enabled = true;
                    LoggedInUi();
                }
                else
                {
                    MessageBox.Show("invalid Username or Password");
                }

        }

        private void LoggedInUi()
        {
            userNameTextBox.Hide();
            passwordTextBox.Hide();
            loginButton.Hide();

            logOutButton.Show();
            userIdentityLabel.Show();
            userIdentityLabel.Text = userNameTextBox.Text;
            formPanel.Show();

            userNameTextBox.ResetText();
            passwordTextBox.ResetText();

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            logOutButton.Hide();
            buttonIndicatorPanel.Hide();
            homeButton.Hide();
            userIdentityLabel.Hide();

            categoryButton.Enabled = false;
            companyButton.Enabled = false;
            itemButton.Enabled = false;
            stockInButton.Enabled = false;
            stockOutButton.Enabled = false;
            salesInfoButton.Enabled = false;
            summaryButton.Enabled = false;
            aboutButton.Enabled = false;

            userNameTextBox.ForeColor = Color.Gray;
            userNameTextBox.Text = "<username>";
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.Text = "<password>";
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            categoryButton.Enabled = false;
            companyButton.Enabled = false;
            itemButton.Enabled = false;
            stockInButton.Enabled = false;
            stockOutButton.Enabled = false;
            salesInfoButton.Enabled = false;
            summaryButton.Enabled = false;
            aboutButton.Enabled = false;

            userNameTextBox.ForeColor = Color.Gray;
            userNameTextBox.Text = "<username>";
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.PasswordChar='\0';
            passwordTextBox.Text = "<password>";

            welcomeLabel.Show();
            smsLabel.Show();
            companyNameLabel.Show();
            userNameTextBox.Show();
            passwordTextBox.Show();
            loginButton.Show();

            homeButton.Hide();
            logOutButton.Hide();
            userIdentityLabel.Hide();
            buttonIndicatorPanel.Hide();
            CloseAlreadyOpenedForms();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            CloseAlreadyOpenedForms();
            UserForm _userForm = new UserForm();
            ShowForm(_userForm);
        }

        private void userNameTextBox_Click(object sender, EventArgs e)
        {
            userNameTextBox.ForeColor = Color.Black;
            userNameTextBox.ResetText();
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.ResetText();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.ResetText();
        }

        private void userNameTextBox_Enter(object sender, EventArgs e)
        {
            userNameTextBox.ForeColor = Color.Black;
            userNameTextBox.ResetText();
        }

    }
}
