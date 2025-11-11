using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEquipmentSystemForms
{
    public partial class FormAdminHome : Form
    {
        string adminID;

        public FormAdminHome(string adminID)
        {
            InitializeComponent();

            this.adminID = adminID;
        }

        private void addNewStudentMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminAddStudent formAdminAddStudent = new FormAdminAddStudent();
            FormHelper.MDIHelper.LoadChildForm(formAdminAddStudent, this);
        }

        private void viewStudentsMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminViewRecords formAdminViewRecords = new FormAdminViewRecords("Students");
            FormHelper.MDIHelper.LoadChildForm(formAdminViewRecords, this);
        }

        private void addNewEquipmentMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminAddEquipment formAdminAddEquipment = new FormAdminAddEquipment();
            FormHelper.MDIHelper.LoadChildForm(formAdminAddEquipment, this);
        }

        private void viewEquipmentMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminViewRecords formAdminViewRecords = new FormAdminViewRecords("Equipment");
            FormHelper.MDIHelper.LoadChildForm(formAdminViewRecords, this);
        }

        private void editEquipmentMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminEditEquipment formAdminEditEquipment = new FormAdminEditEquipment();
            FormHelper.MDIHelper.LoadChildForm(formAdminEditEquipment, this);
        }

        private void viewTransactionsMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminViewRecords formAdminViewRecords = new FormAdminViewRecords("Transactions");
            FormHelper.MDIHelper.LoadChildForm(formAdminViewRecords, this);
        }
    }
}
