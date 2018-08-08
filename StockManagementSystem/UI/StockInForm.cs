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
    public partial class StockInForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        private SqlConnection connection;
        public StockInForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }


        //objects init
        Category category = new Category();
        Company company = new Company();
        Item item = new Item();
        StockIn stockIn = new StockIn();

        FormCommon _common = new FormCommon();


        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //show reorderlevel 
                string fetchReorderLevel = @"SELECT ReOrderLevel FROM items WHERE Name ='" + itemComboBox.Text + "'";
                string fetchAvailableQty = @"SELECT quantity FROM stockin WHERE itemId =" + itemComboBox.SelectedValue + "";
                connection.Close();
                connection.Open();
                SqlCommand command1 = new SqlCommand(fetchReorderLevel, connection);
                reorderLevelTextBox.Text = command1.ExecuteScalar().ToString();

                SqlCommand command2 = new SqlCommand(fetchAvailableQty, connection);

                avialableQuantityTextBox.Text = command2.ExecuteScalar().ToString();

                connection.Close();
            }
            catch (Exception exception)
            {
                connection.Close();
                MessageBox.Show(exception.Message);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {
                stockIn.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                stockIn.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                stockIn.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
                stockIn.Quantity = Convert.ToInt32(avialableQuantityTextBox.Text);
                stockIn.Quantity += Convert.ToInt32(stockInQuantityTextBox.Text);


                string insert = @"IF EXISTS(select* from stockin where itemid=" + stockIn.ItemId + ") update stockin set quantity = " + stockIn.Quantity + ", categoryId='" + stockIn.CategoryId + "',CompanyId='" + stockIn.CompanyId + "' where itemid = " + stockIn.ItemId + " ELSE insert into stockin values(" + stockIn.CategoryId + "," + stockIn.ItemId + ", " + stockIn.Quantity + ", " + stockIn.CompanyId + ")";
                bool isAdded = _common.QueryOperation(insert, connection);
                if (isAdded)
                {
                    MessageBox.Show("Stock in successfully!!");
                    avialableQuantityTextBox.Text = stockIn.Quantity.ToString();
                    stockInQuantityTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("Something is WRONG!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something is WRONG!");
            }


        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(categoryComboBox.SelectedValue);
                // populate item comboBox
                string fetchItems = @"SELECT * FROM items where categoryid=" + value + "";
                connection.Close();
                _common.FillComboBox(fetchItems, connection, itemComboBox);
            }
            catch (Exception exception)
            {
                itemComboBox.ResetText();
                reorderLevelTextBox.ResetText();
                avialableQuantityTextBox.ResetText();
                MessageBox.Show("No items in this category.");
            }

        }

        private void companyComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                // populate company comboBox
                string fetchCompany = @"select distinct companies.id, companies.name from companies Inner Join items on companies.id=items.CompanyId";
                _common.FillComboBox(fetchCompany, connection, companyComboBox);
            }
            catch (Exception exception)
            {
                connection.Close();
                MessageBox.Show(exception.Message);
            }
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                // populate categories comboBox
                string fetchCategories = @"  select distinct categories.Id, categories.Name from categories inner join items on categories.Id=items.CategoryId where items.CompanyId="+companyComboBox.SelectedValue+"";
                _common.FillComboBox(fetchCategories, connection, categoryComboBox);
            }
            catch (Exception exception)
            {
                connection.Close();
                MessageBox.Show(exception.Message);
            }
        }
    }
}
