using DataHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;

namespace LabEquipmentSystemForms
{
    public partial class FormStudentMyEquipmentTransactions : Form
    {
        private string studentID;
        private string currentStatus = "";
        private BindingSource bs = new BindingSource();

        public FormStudentMyEquipmentTransactions(string studentID)
        {
            InitializeComponent();

            this.studentID = studentID;
        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbFilter.SelectedItem.ToString();

            currentStatus = (selected == "All") ? "" : selected;

            LoadMyEquipmentTransactions();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyEquipmentTransactions();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Check if row is selected
            if (dataGridView.CurrentRow == null) return;

            // Get Status field from currently selected row
            string status = dataGridView.CurrentRow.Cells["Status"].Value.ToString().ToLower();

            // Check Status field
            if (status.Equals("borrowed"))
            {
                // If borrowed, execute ReturnEquipment method
                string requestID = dataGridView.CurrentRow.Cells["RequestID"].Value.ToString();
                DateTime dateTimeBorrowed = DateTime.Now;

                bool success = DataAccess.BorrowEquipment(
                    requestID,
                    studentID,
                    dateTimeBorrowed
                );

                MessageBox.Show("Equipment returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                // Else show MessageBox indicating cannot return
                MessageBox.Show("Only borrowed requests can be returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadMyEquipmentTransactions()
        {
            dataGridView.DataSource = null;
            DataTable dt = DataAccess.ViewMyEquipmentTransactions(studentID, currentStatus);
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
        }
    }
}
