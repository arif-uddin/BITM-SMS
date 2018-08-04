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
    public partial class CompanyForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        private SqlConnection connection;
        public CompanyForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        //sql connection
        //SqlConnection connection = new SqlConnection(@"server=pc-301-21\sqlexpress; database=SMS_lazydevs; integrated security=true");

        Company _company = new Company();
        FormCommon _common = new FormCommon();

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text.Length > 2)
            {
                try
                {
                    _company.Name = nameTextBox.Text;
                    //search for same category
                    string search = "SELECT * FROM Companies WHERE Name=('" + _company.Name + "')";
                    bool result = _common.Reader(connection, search);
                    if (result == true)
                    {
                        warningLabel.Text = "Category already Exist!";
                        return;
                    }
                    else
                    {
                        //insert category name to db
                        string insert = "INSERT INTO Companies VALUES('" + _company.Name + "')";
                        bool isAdded = _common.QueryOperation(insert, connection);
                        if (!isAdded) return;
                        nameTextBox.Clear();
                        MessageBox.Show("Added Succesfully!");
                        CompanyForm_Load(this, null);
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

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            //fill gridView with data from db
            string fetch = "SELECT * FROM companies ORDER BY id DESC";
            _common.FillGrid(fetch,connection,companyGridView);


        }

        private void companyGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void companyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 1;

            if (companyGridView.CurrentCell.ColumnIndex.Equals(index) && e.RowIndex != -1)
            {
                try
                {
                    //Delete function
                    string deleteKeyWord = companyGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string deleteQuery = @"DELETE FROM companies WHERE Name='" + deleteKeyWord + "'";
                    bool isDeleted = _common.QueryOperation(deleteQuery, connection);
                    if (isDeleted)
                    {
                        MessageBox.Show("Deleted Succesfully");
                    }
                    //Update Function
                    string fetch = "SELECT * FROM companies";
                    _common.FillGrid(fetch, connection, companyGridView);

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Items are remaining of this Company.");
                    connection.Close();
                }
                

            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Text = "";
        }
    }
}
