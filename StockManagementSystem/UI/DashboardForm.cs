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
        //From move with Movedawn
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public DashboardForm()
        {
            InitializeComponent();
            buttonIndicatorPanel.Height = itemButton.Height;
            buttonIndicatorPanel.Top = itemButton.Top;

        }
        
        
        //Begin of Button Mousehover color change
        private void categoryButton_MouseHover(object sender, EventArgs e)
        {
            categoryButton.BackColor = Color.DarkGreen;
        }

        private void categoryButton_MouseLeave(object sender, EventArgs e)
        {
            categoryButton.BackColor = Color.Transparent;
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
            companyButton.BackColor = Color.Transparent;
        }

        private void itemButton_MouseLeave(object sender, EventArgs e)
        {
            itemButton.BackColor = Color.Transparent;
        }

        private void stockOutButton_MouseLeave(object sender, EventArgs e)
        {
            stockOutButton.BackColor = Color.Transparent;
        }

        private void aboutButton_MouseLeave(object sender, EventArgs e)
        {
            aboutButton.BackColor = Color.Transparent;
        }

        private void stockInButton_MouseHover(object sender, EventArgs e)
        {
            stockInButton.BackColor = Color.DarkGreen;
        }

        private void stockInButton_MouseLeave(object sender, EventArgs e)
        {
            stockInButton.BackColor = Color.Transparent;
        }

        //End of Button Mousehover color change
           
       
        //bodyMove with mousedown

        private void headerTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            //button Indicator Panel move
            buttonIndicatorPanel.Height = itemButton.Height;
            buttonIndicatorPanel.Top = itemButton.Top;

            ItemForm itemForm = new ItemForm();
            itemForm.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            buttonIndicatorPanel.Height = itemButton.Height;
            buttonIndicatorPanel.Top = itemButton.Top;
        }
    }
}
