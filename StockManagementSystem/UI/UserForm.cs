using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem.UI
{
    public partial class UserForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;
        private SqlConnection connection;

        FormCommon _common=new FormCommon();

        public UserForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User();


            if (adminRadioButton.Checked)
            {
                user.userType = 1;
            }

            else if (userRadioButton.Checked)
            {
                user.userType = 2;
            }

            if (userNameSetTextBox.Text!="" && passwordSetTextBox.Text!="" && RadioButtonValidation()==true )
            {
                user.userName = userNameSetTextBox.Text;
                user.PassWord = passwordSetTextBox.Text;

                try
                {
                    //search for same category
                    string search = "SELECT * FROM Users WHERE UserName='"+user.userName+"' AND PassWord='"+user.PassWord+"' ";
                    bool result = _common.Reader(connection, search);
                    if (result == true)
                    {
                        warningLabel.Text = "User already Exist!";
                        return;
                    }
                    else
                    {
                        //insert
                        string userAddQuery = @"INSERT INTO Users VALUES('" + user.userName + "', '" + user.PassWord + "', '" + user.userType + "')";
                        _common.QueryOperation(userAddQuery, connection);

                        MessageBox.Show("Added Successfully!!");

                        userNameSetTextBox.ResetText();
                        passwordSetTextBox.ResetText();
                    }
                    //Update Function
                    string fetch = "SELECT * FROM Users ORDER BY Id DESC";
                    _common.FillGrid(fetch, connection, userGridView);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Please Fill properly!!");
                return;
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            string loadUser = @"SELECT * FROM Users ORDER BY id DESC";
            _common.FillGrid(loadUser,connection,userGridView);
        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 3;

            if (userGridView.CurrentCell.ColumnIndex.Equals(index) && e.RowIndex != -1)
            {
                try
                {
                    //Delete function
                    string deleteUserName = userGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string deletePassWord = userGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

                     string fixedPassWord= Regex.Replace(deletePassWord, @"\s+", "");

                    if (deleteUserName=="admin" && fixedPassWord=="admin")
                    {
                        MessageBox.Show("Can not DELETE ADMIN!!");
                        return;
                    }

                    else
                    {
                        string deleteQuery = @"DELETE FROM Users WHERE UserName='" + deleteUserName + "' AND PassWord='" + deletePassWord + "'";
                        bool isDeleted = _common.QueryOperation(deleteQuery, connection);
                        if (isDeleted)
                        {
                            MessageBox.Show("Deleted Succesfully");
                        }
                    }

                    //Update Function
                    string fetch = "SELECT * FROM Users ORDER BY Id DESC";
                    _common.FillGrid(fetch, connection, userGridView);

                }
                catch (Exception exception)
                {
                    connection.Close();
                    MessageBox.Show("Something is WRONG!!");
                    
                }


            }
        }

        private void userGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Serialize the gridview    
            DataGridView companyGridViewView = sender as DataGridView;
            if (null != companyGridViewView)
            {
                foreach (DataGridViewRow r in companyGridViewView.Rows)
                {
                    companyGridViewView.Rows[r.Index].HeaderCell.Value =
                        (r.Index + 1).ToString();
                }
            }
        }


        //method
        private bool RadioButtonValidation()
        {
            if (adminRadioButton.Checked || userRadioButton.Checked)
            {
                return true;
            }

            return false;
        }

        private void userNameSetTextBox_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Text = "";
        }
    }
}
