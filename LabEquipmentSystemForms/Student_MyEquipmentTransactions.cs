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
        private string currentType = "";
        private BindingSource bs = new BindingSource();

        public FormStudentMyEquipmentTransactions(string studentID)
        {
            InitializeComponent();

            this.studentID = studentID;
            LoadMyEquipmentTransactions();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbFilter.SelectedItem.ToString();

            currentType = (selected == "All") ? "" : selected;

            LoadMyEquipmentTransactions();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyEquipmentTransactions();
        }

        private void LoadMyEquipmentTransactions()
        {
            dataGridView.DataSource = null;
            DataTable dt = DataAccess.ViewMyEquipmentTransactions(studentID, currentType);
            bs.DataSource = dt;
            dataGridView.DataSource = bs;
        }
    }
}
