using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem.UI
{
    public partial class CategoryForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        private SqlConnection connection;
        public CategoryForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }


        //sql connection
        //SqlConnection connection = new SqlConnection(@"server=pc-301-21\sqlexpress; database=SMS_lazydevs; integrated security=true");
    

        //Objects init
        Category _category = new Category();
        FormCommon _common = new FormCommon();
        List<Category> _categoryList = new List<Category>();



        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 2)
            {
                try
                {
                    _category.Name = nameTextBox.Text;

                    //search for same category
                    string search = "SELECT * FROM Categories WHERE Name=('" + _category.Name + "')";

                    bool result = _common.Reader(connection, search);

                    if (result == true)
                    {
                        warningLabel.Text = "Category already Exist!";
                        return;
                    }
                    else
                    {
                        //insert category name to db
                        string insert = "INSERT INTO Categories VALUES('" + _category.Name + "')";
                        bool isAdded = _common.QueryOperation(insert, connection);
                        if (!isAdded) return;
                        nameTextBox.Clear();
                        MessageBox.Show("Added Succesfully!");
                        warningLabel.Text = "";
                        //Update Function
                        CategoryForm_Load(this, null);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
   
            }
            else
            {
                warningLabel.Text = "Name at least 3 character!";
                return;
            }

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {   
            //grid fill with data from db
            string fetch = "SELECT * FROM Categories ORDER BY id DESC";
            _common.FillGrid(fetch,connection,categoryGridView);
        }

        //serial numbering in gridView rowHeader
        private void categoryGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DataGridView categoryGridViewView = sender as DataGridView;
            if (null != categoryGridViewView)
            {
                foreach (DataGridViewRow r in categoryGridViewView.Rows)
                {
                    categoryGridViewView.Rows[r.Index].HeaderCell.Value =
                        (r.Index + 1).ToString();
                }
            }
        }

        //Delete an Item(row) from Database
        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 1;

            if (categoryGridView.CurrentCell.ColumnIndex.Equals(index) && e.RowIndex != -1)
            {
                try
                {
                    //Delete function
                    string deleteKeyWord = categoryGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string deleteQuery = @"DELETE FROM categories WHERE Name='" + deleteKeyWord + "'";
                    bool isDeleted = _common.QueryOperation(deleteQuery, connection);
                    if (isDeleted)
                    {
                        MessageBox.Show("Deleted Succesfully");
                    }
                    //Reload form to update gridView
                    CategoryForm_Load(this, null);

                }
                catch (Exception exception)
                {
                    connection.Close();
                    MessageBox.Show("Items are remaining in this category.");

                }
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Text = "";
        }
    }
}
