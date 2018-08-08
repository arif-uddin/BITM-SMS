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
    public partial class StockOutForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        private SqlConnection connection;
        public StockOutForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }


        FormCommon _common = new FormCommon();
        
        List<StockOut> stockOutList = new List<StockOut>();

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            // populate category comboBox
            string fetchCategories = @"SELECT * FROM categories";
            _common.FillComboBox(fetchCategories, connection, categoryComboBox);

            // populate company comboBox
            string fetchCompanies = @"SELECT * FROM companies";
            _common.FillComboBox(fetchCompanies, connection, companyComboBox);
 
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show reorderlevel 
            string fetchReorderLevel = @"SELECT ReOrderLevel FROM items WHERE Name ='" + itemComboBox.Text + "'";
            string fetchAvailableQty = @"SELECT quantity FROM stockin WHERE itemId =" + itemComboBox.SelectedValue + "";
            connection.Close();
            connection.Open();
            SqlCommand command1 = new SqlCommand(fetchReorderLevel, connection);
            reorderLevelTextBox.Text = command1.ExecuteScalar().ToString();
            connection.Close();
            SqlCommand command2 = new SqlCommand(fetchAvailableQty, connection);
            connection.Open();
            avialableQuantityTextBox.Text = command2.ExecuteScalar().ToString();
            connection.Close();
        }


        //Serialize stockout gridview
        private void stockOutDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView stockOutGridViewView = sender as DataGridView;
            if (null != stockOutGridViewView)
            {
                foreach (DataGridViewRow r in stockOutDataGridView.Rows)
                {
                    stockOutDataGridView.Rows[r.Index].HeaderCell.Value =
                        (r.Index + 1).ToString();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(avialableQuantityTextBox.Text) >= Convert.ToInt32(stockOutQuantityTextBox.Text))
                {
                    StockOut _stockOut = new StockOut();

                    _stockOut.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                    _stockOut.CategoryName = categoryComboBox.Text;

                    _stockOut.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                    _stockOut.CompanyName = companyComboBox.Text;

                    _stockOut.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
                    _stockOut.ItemName = itemComboBox.Text;

                    _stockOut.OutQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
                    avialableQuantityTextBox.Text = (Convert.ToInt32(avialableQuantityTextBox.Text) - _stockOut.OutQuantity).ToString();
                    _stockOut.Quantity = Convert.ToInt32(avialableQuantityTextBox.Text);
                    _stockOut.Date = DateTime.Today;
                    stockOutQuantityTextBox.ResetText();

                    stockOutList.Add(_stockOut);
                    stockOutDataGridView.DataSource = null;
                    stockOutDataGridView.DataSource = stockOutList;
                    stockOutDataGridView.Columns["CategoryId"].Visible = false;
                    stockOutDataGridView.Columns["CompanyId"].Visible = false;
                    stockOutDataGridView.Columns["ItemId"].Visible = false;
                    stockOutDataGridView.Columns["Date"].Visible = false;
                    stockOutDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (Convert.ToInt32(reorderLevelTextBox.Text) > _stockOut.Quantity)
                    {
                        MessageBox.Show("Product is going OUT OF STOCK", "WARNING!!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something is WRONG!!!");
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

        enum StockOutType
        {
            Sold,
            Damaged,
            Lost    
            
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            foreach (StockOut stockOut in stockOutList)
            {
                string stockoutQuery = "INSERT INTO stockout Values('" + stockOut.CompanyName + "','" + stockOut.CategoryName + "','" + stockOut.ItemName + "','" + stockOut.OutQuantity + "','" + stockOut.Date + "','" + (StockOutType.Sold) + "')";
                _common.QueryOperation(stockoutQuery, connection);
                string UpdateStock = "UPDATE stockin SET quantity=" + stockOut.Quantity + " where itemId=" + stockOut.ItemId + "";
                _common.QueryOperation(UpdateStock, connection);
               
            }
            MessageBox.Show("Item Sold!");
            stockOutDataGridView.DataSource = null;
            stockOutList.Clear();
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            foreach (StockOut stockOut in stockOutList)
            {
                string stockoutQuery = "INSERT INTO stockout Values('" + stockOut.CompanyName + "','" + stockOut.CategoryName + "','" + stockOut.ItemName + "','" + stockOut.OutQuantity + "','" + stockOut.Date + "','" + (StockOutType.Damaged) + "')";
                _common.QueryOperation(stockoutQuery, connection);
                string UpdateStock = "UPDATE stockin SET quantity=" + stockOut.Quantity + " where itemId=" + stockOut.ItemId + "";
                _common.QueryOperation(UpdateStock, connection);               
            }

            MessageBox.Show("Item added to damaged list");
            stockOutDataGridView.DataSource = null;
            stockOutList.Clear();
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            foreach (StockOut stockOut in stockOutList)
            {
                string stockoutQuery = "INSERT INTO stockout Values('" + stockOut.CompanyName + "','" + stockOut.CategoryName + "','" + stockOut.ItemName + "','" + stockOut.OutQuantity + "','" + stockOut.Date + "','" + (StockOutType.Lost) + "')";
                _common.QueryOperation(stockoutQuery, connection);
                string UpdateStock = "UPDATE stockin SET quantity=" + stockOut.Quantity + " where itemId=" + stockOut.ItemId + "";
                _common.QueryOperation(UpdateStock, connection);

            }

            MessageBox.Show("Item added to lost list!");
            stockOutDataGridView.DataSource = null;
            stockOutList.Clear();
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
                string fetchCategories = @"  select distinct categories.Id, categories.Name from categories inner join items on categories.Id=items.CategoryId where items.CompanyId=" + companyComboBox.SelectedValue + "";
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
