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
    public partial class FormAdminAddStudent : Form
    {
        public FormAdminAddStudent()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataAccess.AddStudent(
                    txtStudentId.Text.ToString(),
                    txtPassword.Text.ToString(),
                    //pbProfilePicture.Image.ImageToByteArray(),
                    txtFirstName.Text.ToString(),
                    txtLastName.Text.ToString(),
                    cbGender.Text.ToString(),
                    cbCourse.Text.ToString()
                );
        }
    }
}
