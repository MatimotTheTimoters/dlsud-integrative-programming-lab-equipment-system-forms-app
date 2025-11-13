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
            welcomeMessageMenuItem.Text = "Welcome, " + adminID;
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

        private void processRequestsMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminProcessEquipmentRequests formAdminProcessEquipmentRequests = new FormAdminProcessEquipmentRequests(adminID);
            FormHelper.MDIHelper.LoadChildForm(formAdminProcessEquipmentRequests, this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeMenuItem.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (response == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Logout cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
