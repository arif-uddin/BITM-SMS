using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{
    class UserManager
    {
        public int Login(User user)
        {
            UserRepository UserRepo = new UserRepository();
            string userType = UserRepo.Login(user);
            return Convert.ToInt32(userType);
            
        }
    }
}
