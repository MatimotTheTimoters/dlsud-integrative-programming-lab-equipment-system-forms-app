using DataHelper;
using System;
using System.Data;
using System.Windows.Forms;

namespace LabEquipmentSystemForms
{
    public partial class FormAdminProcessEquipmentRequests : Form
    {
        private string adminID;
        private string currentStatus = "";
        private BindingSource bs = new BindingSource();

        public FormAdminProcessEquipmentRequests(string adminID)
        {
            InitializeComponent();

            this.adminID = adminID;

            LoadEquipmentRequestsRecords(currentStatus);
            BindDataSourceToControls();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            // Get status from selected row
            string status = dataGridView.CurrentRow.Cells["Status"].Value.ToString();
            if (status.ToLower().Equals("completed")) // If completed, return
            {
                MessageBox.Show("Cannot approve a completed request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string requestID = dataGridView.CurrentRow.Cells["RequestID"].Value.ToString();
            string action = "approve";
            DateTime processDate = DateTime.Now;
            bool success = DataAccess.ProcessRequest(requestID, adminID, action, processDate);

            if (success)
            {
                MessageBox.Show("Equipment request approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEquipmentRequestsRecords(currentStatus);
            }
            else
            {
                MessageBox.Show("Failed to approve equipment request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            // Get status from selected row
            string status = dataGridView.CurrentRow.Cells["Status"].Value.ToString();
            if (status.ToLower().Equals("completed")) // If completed, return
            {
                MessageBox.Show("Cannot deny a completed request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string requestID = dataGridView.CurrentRow.Cells["RequestID"].Value.ToString();
            string action = "deny";
            DateTime processDate = DateTime.Now;
            bool success = DataAccess.ProcessRequest(requestID, adminID, action, processDate);

            if (success)
            {
                MessageBox.Show("Equipment request denied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEquipmentRequestsRecords(currentStatus);
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
            if (dataGridView.CurrentRow != null)
            {
                bs.Position = dataGridView.CurrentRow.Index;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbFilter.SelectedItem.ToString();

            currentStatus = (selected == "All") ? "" : selected;

            LoadEquipmentRequestsRecords(currentStatus);
        }
    }
}
