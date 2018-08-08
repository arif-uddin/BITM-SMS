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
    public partial class SummaryForm : Form
    {
        private string connectionString =
        ConfigurationManager.ConnectionStrings["StockConnectionString"].ConnectionString;

        private SqlConnection connection;
        public SummaryForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        
        FormCommon _common=new FormCommon();

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (RadioButtonValidation() == true)
            {
                string fromDate = fromDatePicker.Value.Date.ToShortDateString();
                string toDate = toDatePicker.Value.Date.ToShortDateString();
                string type;
                string query;
                if (soldRadioButton.Checked)
                {
                    type = "sold";
                }
                else if (damagedRadioButton.Checked)
                {
                    type = "damaged";

                }
                else if (lostRadioButton.Checked)
                {
                    type = "lost";
                }
                else
                {
                    type = "";
                }

                if (allRadioButton.Checked)
                {
                    query = "  SELECT * FROM stockout where date BETWEEN '" + fromDate + "'AND '" + toDate + "'";
                }
                else
                {
                    query = " SELECT * FROM stockout WHERE stockouttype = '" + type + "' And date  BETWEEN '" + fromDate + "'AND '" + toDate + "'";
                }


                try
                {
                    _common.FillGrid(query, connection, summaryGridView);
                    summaryGridView.Columns["Id"].Visible = false;
                    summaryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check type of StockOut");
            }
        }

        private bool RadioButtonValidation()
        {
            if (soldRadioButton.Checked || damagedRadioButton.Checked || lostRadioButton.Checked || allRadioButton.Checked)
            {
                return true;
            }

            return false;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            fromDatePicker.MaxDate = DateTime.Today;
            toDatePicker.MaxDate = DateTime.Today;
            toDatePicker.Value = DateTime.Today;
            fromDatePicker.Value = DateTime.Today;
        }

        private void summaryGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView stockOutGridViewView = sender as DataGridView;
            if (null != stockOutGridViewView)
            {
                foreach (DataGridViewRow r in summaryGridView.Rows)
                {
                    summaryGridView.Rows[r.Index].HeaderCell.Value =
                        (r.Index + 1).ToString();
                }
            }
        }
    }
}
