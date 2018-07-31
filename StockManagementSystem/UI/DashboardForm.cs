using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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



        //Form Objects
        ItemForm _itemForm = new ItemForm();
        CategoryForm _categoryForm =new CategoryForm();
        CompanyForm _companyForm =new CompanyForm();
        StockInForm _stockInForm =new StockInForm();
        StockOutForm _stockOutForm =new StockOutForm();
        SalesInfoForm _salesInfoForm=new SalesInfoForm();
        SummaryForm _summaryForm=new SummaryForm();
        AboutForm _aboutForm=new AboutForm();


        public DashboardForm()
        {
            InitializeComponent();

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
            ButtonIndicatorMove(itemButton);
            ShowForm(_itemForm);
        }
        private void categoryButton_Click(object sender, EventArgs e)
        {
            ButtonIndicatorMove(categoryButton);
            ShowForm(_categoryForm);
        }

        private void companyButton_Click(object sender, EventArgs e)
        {
            ButtonIndicatorMove(companyButton);
            ShowForm(_companyForm);
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            ButtonIndicatorMove(stockInButton);
            ShowForm(_stockInForm);
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            ButtonIndicatorMove(stockOutButton);
            ShowForm(_stockOutForm);
        }

        private void salesInfoButton_Click(object sender, EventArgs e)
        {
            ButtonIndicatorMove(salesInfoButton);
            ShowForm(_salesInfoForm);
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            ButtonIndicatorMove(summaryButton);
            ShowForm(_summaryForm);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
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
            form.TopLevel = false;
            form.AutoScroll = true;
            formPanel.Controls.Add(form);
            CloseOtherForms();
            form.Show();
            if (form.Visible)
            {
                form.BringToFront();
            }
        }

        private void CloseOtherForms()
        {
            if (_itemForm.Visible || _companyForm.Visible || _categoryForm.Visible || _stockInForm.Visible || _stockOutForm.Visible)
            {
                if (_itemForm.Visible)
                {
                    _itemForm.Hide();
                }

                if (_companyForm.Visible)
                {
                    _companyForm.Hide();
                }

                if (_categoryForm.Visible)
                {
                    _categoryForm.Hide();
                }

                if (_stockInForm.Visible)
                {
                    _stockInForm.Hide();
                }

                if (_stockOutForm.Visible)
                {
                    _stockOutForm.Hide();
                }
            }
        }

        private void ButtonIndicatorMove(Button buttonName)
        {
            buttonIndicatorPanel.Height = buttonName.Height;
            buttonIndicatorPanel.Top = buttonName.Top;
        }

        //Methods End


    }
}
