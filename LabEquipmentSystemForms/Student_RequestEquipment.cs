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
    public partial class FormStudentRequestEquipment : Form
    {
        string studentID;
        BindingSource bs = new BindingSource();

        public FormStudentRequestEquipment(string studentID)
        {
            InitializeComponent();

            this.studentID = studentID;
            LoadEquipmentRecords();
            BindDataSourceToControls();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            // Get input values
            string equipmentID = txtEquipmentId.Text;
            int quantity = Convert.ToInt32(nudQuantity.Value);
            DateTime requestDate = DateTime.Today;
            string status = "Pending";

            // Execute request method
            bool success = DataAccess.RequestEquipment(studentID, equipmentID, quantity, requestDate, status);

            // Validation
            if (success)
            {
                MessageBox.Show("Equipment request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to submit equipment request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            txtEquipmentId.DataBindings.Add("Text", bs, "EquipmentID");
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

        private void FormStudentEquipmentRequests_Load(object sender, EventArgs e)
        {
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
        }
    }
}
