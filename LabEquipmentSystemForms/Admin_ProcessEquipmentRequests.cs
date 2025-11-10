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
using System.Xml.Linq;

namespace LabEquipmentSystemForms
{
    public partial class FormAdminProcessEquipmentRequests : Form
    {
        string adminID;
        BindingSource bs = new BindingSource();

        public FormAdminProcessEquipmentRequests(string adminID)
        {
            InitializeComponent();

            this.adminID = adminID;
            string status = "";
            LoadEquipmentRequestsRecords(status);
            BindDataSourceToControls();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // Get the selected RequestID from the DataGridView
            string requestID = dataGridView.CurrentRow.Cells["RequestID"].Value.ToString();

            // Execute method to approve request
            bool success = DataAccess.ApproveEquipmentRequest(requestID, adminID);

            // Validation
            if (success)
            {
                MessageBox.Show("Equipment request approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string status = "Approved";
                LoadEquipmentRequestsRecords(status); // Refresh records
            }
            else
            {
                MessageBox.Show("Failed to approve equipment request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            // Get the selected RequestID from the DataGridView
            string requestID = dataGridView.CurrentRow.Cells["RequestID"].Value.ToString();

            // Execute method to deny request
            bool success = DataAccess.DenyEquipmentRequest(requestID, adminID);

            // Validation
            if (success)
            {
                MessageBox.Show("Equipment request denied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string status = "Denied";
                LoadEquipmentRequestsRecords(status); // Refresh records
            }
            else
            {
                MessageBox.Show("Failed to deny equipment request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEquipmentRequestsRecords(string status)
        {
            DataTable dt = DataAccess.ViewEquipmentRequests(status);
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
        }

        private void BindDataSourceToControls()
        {
            txtEquipmentID.DataBindings.Clear();
            txtStudentID.DataBindings.Clear();
            nudQuantity.DataBindings.Clear();

            txtEquipmentID.DataBindings.Add("Text", bs, "EquipmentID");
            txtStudentID.DataBindings.Add("Text", bs, "StudentID");
            nudQuantity.DataBindings.Add("Value", bs, "Quantity");
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there is a current row selected
            if (dataGridView.CurrentRow != null)
            {
                // Update binding source position to match DataGridView selection
                bs.Position = dataGridView.CurrentRow.Index;
            }
        }
    }
}
