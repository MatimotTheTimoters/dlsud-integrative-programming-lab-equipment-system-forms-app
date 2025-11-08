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
    public partial class FormAdminAddEquipment : Form
    {
        public FormAdminAddEquipment()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool success = DataAccess.AddEquipment(
                txtEquipmentId.Text.ToString(),
                txtName.Text.ToString(),
                Convert.ToInt32(nudQuantity.Value),
                rtbDescription.Text.ToString()
            );

            if (success)
            {
                MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            } else
            {
                MessageBox.Show("Failed to create equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEquipmentId.Focus();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            txtEquipmentId.Clear();
            txtName.Clear();
            nudQuantity.Value = 10;
            rtbDescription.Clear();

            txtEquipmentId.Focus();
        }

    }
}
