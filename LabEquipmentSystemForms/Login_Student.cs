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
    public partial class FormLoginStudent : Form
    {
        public FormLoginStudent()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = DataAccess.LoginAdmin(
                txtStudentId.Text.ToString(),
                txtPassword.Text.ToString());

            if (success)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormStudentHome studentHome = new FormStudentHome();
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
