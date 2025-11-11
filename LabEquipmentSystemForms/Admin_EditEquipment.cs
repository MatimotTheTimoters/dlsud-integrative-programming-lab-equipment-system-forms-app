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
    public partial class FormAdminEditEquipment : Form
    {
        string oldEquipmentID, oldName, oldDescription;
        int oldQuantity;
        BindingSource bs = new BindingSource();

        public FormAdminEditEquipment()
        {
            InitializeComponent();
            LoadEquipmentRecords();
            BindDataSourceToControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtEquipmentId.ReadOnly = false;
            txtName.ReadOnly = false;
            nudQuantity.ReadOnly = false;
            rtbDescription.ReadOnly = false;

            oldEquipmentID = txtEquipmentId.Text;
            oldName = txtName.Text;
            oldQuantity = Convert.ToInt32(nudQuantity.Value);
            oldDescription = rtbDescription.Text;

            btnSave.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input values
            string newEquipmentID = txtEquipmentId.Text;
            string newName = txtName.Text;
            int newQuantity = Convert.ToInt32(nudQuantity.Value);
            string newDescription = rtbDescription.Text;

            // Execute edit method and store result
            bool success = DataAccess.EditEquipment(
                oldEquipmentID, newEquipmentID,
                oldName, newName,
                oldQuantity, newQuantity,
                oldDescription, newDescription
            );

            // Validation
            if (success)
            {
                MessageBox.Show("Equipment details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEquipmentRecords();
                ResetButtonStates();
                ClearValues();
            }
            else
            {
                MessageBox.Show("Failed to update equipment details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetButtonStates();
            ClearValues();
            btnEdit.Focus();
        }

        private void ResetButtonStates()
        {
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtEquipmentId.ReadOnly = true;
            txtName.ReadOnly = true;
            nudQuantity.ReadOnly = true;
            rtbDescription.ReadOnly = true;
        }

        private void ClearValues()
        {
            oldEquipmentID = "";
            oldName = "";
            oldQuantity = 0;
            oldDescription = "";
        }

        private void LoadEquipmentRecords()
        {
            DataTable dt = DataAccess.ViewEquipment();
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
        }

        private void BindDataSourceToControls()
        {
            txtEquipmentId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            nudQuantity.DataBindings.Clear();
            rtbDescription.DataBindings.Clear();

            txtEquipmentId.DataBindings.Add("Text", bs, "EquipmentID");
            txtName.DataBindings.Add("Text", bs, "Name");
            nudQuantity.DataBindings.Add("Value", bs, "Quantity");
            rtbDescription.DataBindings.Add("Text", bs, "Description");
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

        private void FormAdminEditEquipment_Load(object sender, EventArgs e)
        {
            ResetButtonStates();
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }
    }
}
