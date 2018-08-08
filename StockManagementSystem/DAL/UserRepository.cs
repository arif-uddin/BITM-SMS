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
    class UserRepository
    {
        //sql connection
        private static string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;
        private SqlConnection connection = new SqlConnection(connectionString);


        public string Login(User user)
        {
            try
            {
                string loginInfo = @"SELECT UserType FROM Users WHERE UserName='" + user.userName + "'AND Password='" + user.PassWord + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(loginInfo, connection);
                string userType = command.ExecuteScalar().ToString();
                connection.Close();
                return userType;
            }
            catch (Exception e)
            {
                connection.Close();
                return "0";
            }

            
        }
    }
}
