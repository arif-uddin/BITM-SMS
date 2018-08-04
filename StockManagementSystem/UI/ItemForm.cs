using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem.UI
{
    public partial class ItemForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        private SqlConnection connection;
        public ItemForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }


        //Objects init
        Item _item = new Item();
        FormCommon _common = new FormCommon();


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (itemTextBox.Text.Length > 2)
            {
                try
                {
                    _item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                    _item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                    _item.Name = itemTextBox.Text;
                    _item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);

                    //search for same category
                    string search = "SELECT * FROM items WHERE Name=('" + _item.Name + "')";

                    bool result = _common.Reader(connection, search);

                    if (result == true)
                    {
                        warningLabel.Text = "Item already Exist!";
                        return;
                    }
                    else
                    {
                        string insert = @"INSERT INTO items VALUES('" + _item.Name + "','" + _item.ReorderLevel + "','" + _item.CategoryId + "','"+_item.CompanyId+"')";


                        bool isAdded = _common.QueryOperation(insert, connection);
                        if (isAdded)
                        {
                            MessageBox.Show("Item Added");
                            companyComboBox.ResetText();
                            categoryComboBox.ResetText();
                            itemTextBox.Clear();
                            reorderLevelTextBox.Clear();
                            string insert3 = @"SELECT TOP 1 * FROM items ORDER BY id DESC";

                            connection.Open();
                            SqlCommand command1 = new SqlCommand(insert3, connection);
                            int itemId = Convert.ToInt32(command1.ExecuteScalar());
                            connection.Close();
                            string insert2 = @"INSERT INTO stockin VALUES('" + _item.CategoryId + "','" + itemId + "',0,'"+_item.CompanyId+"')";
                            _common.QueryOperation(insert2, connection);
                        }
                    }
                }
                catch (Exception exception)
                {
                    connection.Close();
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                warningLabel.Text = "Name at least 3 characters.";
            }
      
        }

        private void reorderLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
             _common.ValidationNumberOnly(e,sender);
 
        }

        private void categoryComboBox_Click(object sender, EventArgs e)
        {
            // populate category comboBox
            string fetchCategory = @"SELECT * FROM categories";
            _common.FillComboBox(fetchCategory, connection, categoryComboBox);

        }

        private void companyComboBox_Click(object sender, EventArgs e)
        {
            //populate company comboBox
            string fetchCompany = @"SELECT * FROM companies";
            _common.FillComboBox(fetchCompany, connection, companyComboBox);
        }
    }
}

