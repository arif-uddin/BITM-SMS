using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{
    class CategoryManager
    {
        CategoryRepository categoryRepo = new CategoryRepository();
        public bool AddCategory(Category category)
        {
           bool isExist = categoryRepo.IsExist(category);

            if (isExist)
            {
                return true;
                
            }

            categoryRepo.Add(category);
            return false;
        }

        public void LoadCategory(DataGridView myGridView, string dataSourceTable)
        {
            categoryRepo.LoadData(myGridView,dataSourceTable);
        }

        public bool Delete(string thisdata)
        {
            
             bool isDeleted = categoryRepo.Delete(thisdata);
             return isDeleted;
         
        }
    }
}
