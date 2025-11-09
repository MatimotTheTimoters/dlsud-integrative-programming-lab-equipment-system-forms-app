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
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminID = txtAdminId.Text.ToString();
            string password = txtPassword.Text.ToString();

            bool success = DataAccess.LoginAdmin(
                adminID, 
                password);

            if (success)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormAdminHome adminHome = new FormAdminHome(adminID);
                adminHome.Show();
                this.Close();
                adminHome.Focus();
            } else
            {
                MessageBox.Show("Login Failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdminId.Focus();
            }
        }
    }
}
