using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;

namespace LabEquipmentSystemForms
{
    public partial class FormAdminAddStudent : Form
    {
        private string selectedImagePath = null;

        public FormAdminAddStudent()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files | *.jpg;*.jpeg;*.png;*.gif;*.bmp";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                pbProfilePicture.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = null;

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imageBytes = File.ReadAllBytes(selectedImagePath); // ✅ convert image to bytes
            }

            bool success = DataAccess.AddStudent(
                txtStudentId.Text.Trim(),
                txtPassword.Text.Trim(),
                imageBytes, // ✅ now accepts byte[]
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                cbGender.Text.Trim(),
                cbCourse.Text.Trim()
            );

            if (success)
            {
                MessageBox.Show("Student added successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            } else
            {
                MessageBox.Show("Failed to create student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentId.Focus();
            }

        }

        private void ClearInput()
        {
            txtStudentId.Clear();
            txtPassword.Clear();
            pbProfilePicture.Image = null;
            txtFirstName.Clear();
            txtLastName.Clear();
            cbGender.SelectedIndex = -1;
            cbCourse.SelectedIndex = -1;
            selectedImagePath = null;

            txtStudentId.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
