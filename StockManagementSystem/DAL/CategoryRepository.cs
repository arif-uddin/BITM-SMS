using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models;

namespace StockManagementSystem.DAL
{
    class CategoryRepository
    {
        //sql connection
        private static string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;
        private SqlConnection connection = new SqlConnection(connectionString);

        FormCommon _common = new FormCommon();

        public bool IsExist(Category category)
        {
            string search = "SELECT * FROM Categories WHERE Name=('" + category.Name + "')";
            bool result = _common.Reader(connection, search);
            return result;

        }

        public void Add(Category category)
        {
            try
            {
                //insert category name to db
                string insert = "INSERT INTO Categories VALUES('" + category.Name + "')";
                _common.QueryOperation(insert, connection);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
            }

            
        }

        public void LoadData(DataGridView gridView, string table)
        {
            //grid fill with data from db
            string fetch = "SELECT * FROM "+table+" ORDER BY id DESC";
            _common.FillGrid(fetch, connection, gridView);
        }

        public bool Delete(string deleteKeyWord)
        {
            try
            {
                string deleteQuery = @"DELETE FROM categories WHERE Name='" + deleteKeyWord + "'";
                bool isDeleted = _common.QueryOperation(deleteQuery, connection);
                return isDeleted;
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }
            
        }

    }
}
