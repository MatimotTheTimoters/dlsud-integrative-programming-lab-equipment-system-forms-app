using DataHelper;
using LabEquipmentSystemForms.FormHelper;
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
    public partial class FormStudentHome : Form
    {
        string studentID;

        public FormStudentHome(string studentID)
        {
            InitializeComponent();

            this.studentID = studentID;
            string fullName = DataAccess.GetStudentFullName(studentID);
            welcomeMessageMenuItem.Text = $"Welcome, {fullName}!";
        }

        private void makeNewRequestMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentRequestEquipment requestEquipmentForm = new FormStudentRequestEquipment(studentID);
            MDIHelper.LoadChildForm(requestEquipmentForm, this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeMenuItem.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        private void viewMyRequestsMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentMyEquipmentRequests myRequestsForm = new FormStudentMyEquipmentRequests(studentID);
            MDIHelper.LoadChildForm(myRequestsForm, this);
        }
        private void viewMyTransactionsMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentMyEquipmentTransactions myTransactionsForm = new FormStudentMyEquipmentTransactions(studentID);
            MDIHelper.LoadChildForm(myTransactionsForm, this);
        }
        private void inventoryMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentEquipmentInventory formStudentEquipmentInventory = new FormStudentEquipmentInventory(studentID);
            MDIHelper.LoadChildForm(formStudentEquipmentInventory, this);
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
