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
    public partial class FormStudentMyEquipmentRequests : Form
    {
        private string studentID;
        private string currentStatus = "";
        private BindingSource bs = new BindingSource();

        public FormStudentMyEquipmentRequests(string studentID)
        {
            InitializeComponent();

            this.studentID = studentID;
            LoadMyEquipmentRequests();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbFilter.SelectedItem.ToString();

            currentStatus = (selected == "All") ? "" : selected;

            LoadMyEquipmentRequests();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyEquipmentRequests();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Check if row is selected
            if (dataGridView.CurrentRow == null) return;

            // Get Status field from currently selected row
            string status = dataGridView.CurrentRow.Cells["Status"].Value.ToString().ToLower();

            // Check Status field
            if (status.Equals("approved"))
            {
                // If approved, execute method
                string requestID = dataGridView.CurrentRow.Cells["RequestID"].Value.ToString();
                string equipmentID = dataGridView.CurrentRow.Cells["EquipmentID"].Value.ToString();
                int borrowedQuantity = Convert.ToInt32(dataGridView.CurrentRow.Cells["Quantity"].Value);
                DateTime dateTimeBorrowed = DateTime.Now;

                bool success = DataAccess.CreateInventory(
                    studentID,
                    requestID,
                    equipmentID,
                    borrowedQuantity
                );

                MessageBox.Show("Request opened successfully. Entry added to inventory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMyEquipmentRequests();
                return;
            }
            else
            {
                // Else show MessageBox indicating cannot borrow
                MessageBox.Show("Only approved requests can be opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadMyEquipmentRequests()
        {
            dataGridView.DataSource = null;
            DataTable dt = DataAccess.ViewMyEquipmentRequests(studentID, currentStatus);
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
        }
    }
}
