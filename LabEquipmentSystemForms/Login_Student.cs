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
using System.Web;

namespace LabEquipmentSystemForms
{
    public partial class FormLoginStudent : Form
    {
        public FormLoginStudent()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentId.Text.ToString();
            string password = txtPassword.Text.ToString();

            bool success = DataAccess.LoginStudent(
                studentID,
                password);

            if (success)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormStudentHome studentHome = new FormStudentHome(studentID);
                studentHome.Show();
                this.Close();
                studentHome.Focus();
            }
            else
            {
                MessageBox.Show("Login Failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentId.Focus();
            }
        }
    }
}
