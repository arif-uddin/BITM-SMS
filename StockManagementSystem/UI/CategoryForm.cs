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
using StockManagementSystem.BLL;
using StockManagementSystem.Models;

namespace StockManagementSystem.UI
{
    public partial class CategoryForm : Form
    {
      
        public CategoryForm()
        {
            InitializeComponent();
        }

        //Objects init
        FormCommon _common = new FormCommon();
        CategoryManager categoryManager = new CategoryManager();

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 2)
            {
                try
                {
                    Category category = new Category();
                    category.Name = nameTextBox.Text;


                    bool result =categoryManager.AddCategory(category);

                    if (result == true)
                    {
                        warningLabel.Text = "Category Already Exist!";
                        return;
                    }
                    else
                    {
                        nameTextBox.Clear();
                        MessageBox.Show("Added Succesfully!");
                        warningLabel.Text = "";
                        //Update Function
                        CategoryForm_Load(this, null);
                        return;
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
            categoryManager.LoadCategory(categoryGridView, "categories");

        }

        //serial numbering in gridView rowHeader
        private void categoryGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            _common.SerializeGrid(sender);
        }

        //Delete an Item(row) from Database
        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (categoryGridView.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
              {                
                //Delete function
                string deleteKeyWord = categoryGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                bool isDeleted = categoryManager.Delete(deleteKeyWord);
                if (isDeleted)
                {
                    MessageBox.Show("Deleted Succesfully");
                    CategoryForm_Load(this, null);
                    return;
                }
                MessageBox.Show("items remaining in this category");
              }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Text = "";
        }
    }
}
