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

        private void LoadMyEquipmentRequests()
        {
            dataGridView.DataSource = null;
            DataTable dt = DataAccess.ViewMyEquipmentRequests(studentID, currentStatus);
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
        }
    }
}
