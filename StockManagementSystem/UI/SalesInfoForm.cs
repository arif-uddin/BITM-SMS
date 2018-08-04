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
    public partial class SalesInfoForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        private SqlConnection connection;
        public SalesInfoForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        FormCommon _common = new FormCommon();

        private void searchButton_Click(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(companyComboBox.SelectedValue);
            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);

            string searchQuery = " SELECT name,reorderlevel,Quantity FROM items INNER JOIN stockin ON items.Id=stockin.itemId where items.categoryid =" + categoryId + ""; //companyId="+companyId+"

            try
            {
                _common.FillGrid(searchQuery, connection, resultDataGridView);

                resultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exception)
            {
                string msg = "No Items found in selected Category for this Company.";
                MessageBox.Show(msg);
                connection.Close();
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
