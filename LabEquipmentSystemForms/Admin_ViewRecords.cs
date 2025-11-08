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
    public partial class FormAdminViewRecords : Form
    {
        string formCmd;
        public FormAdminViewRecords(string cmd)
        {
            InitializeComponent();
            formCmd = cmd.ToLower();

            LoadSelectedRecords();
        }

        private void LoadStudentRecords()
        {
            dataGridView.DataSource = null;

            DataTable studentRecords = DataAccess.ViewStudents();
            dataGridView.DataSource = studentRecords;
        }

        private void LoadEquipmentRecords()
        {
            dataGridView.DataSource = null;

            DataTable equipmentRecords = DataAccess.ViewEquipment();
            dataGridView.DataSource = equipmentRecords;
        }

        private void LoadSelectedRecords()
        {
            if (formCmd.Equals("students")) {
                LoadStudentRecords();
            } else if (formCmd.Equals("equipment")) {
                LoadEquipmentRecords();
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            formCmd = cbGender.SelectedItem.ToString().ToLower();
            
            LoadSelectedRecords();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSelectedRecords();
        }

    }
}
