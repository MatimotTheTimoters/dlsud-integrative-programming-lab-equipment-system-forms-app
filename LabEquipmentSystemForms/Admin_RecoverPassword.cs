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
    public partial class Admin_RecoverPassword : Form
    {
        BindingSource bs = new BindingSource();

        public Admin_RecoverPassword()
        {
            InitializeComponent();
            LoadStudentRecords();
            BindDataSourceToControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtStudentId.ReadOnly = false;
            txtPassword.ReadOnly = false;

            btnSave.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input values
            string newStudentId = txtStudentId.Text;
            string newPassword = txtPassword.Text;

            // Execute edit method and store result
            bool success = DataAccess.UpdateStudentPassword(newStudentId, newPassword);

            // Validation
            if (success)
            {
                MessageBox.Show("Student password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentRecords();
                ResetButtonStates();
            }
            else
            {
                MessageBox.Show("Failed to update student password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetButtonStates();
            btnEdit.Focus();
        }

        private void ResetButtonStates()
        {
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtStudentId.ReadOnly = true;
            txtPassword.ReadOnly = true;
        }

        private void LoadStudentRecords()
        {
            DataTable dt = DataAccess.ViewStudents();
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
        }

        private void BindDataSourceToControls()
        {
            txtStudentId.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtStudentId.DataBindings.Add("Text", bs, "StudentID");
            txtPassword.DataBindings.Add("Text", bs, "Password");
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
