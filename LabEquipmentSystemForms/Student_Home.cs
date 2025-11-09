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
        }

        private void makeNewRequestMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentRequestEquipment requestEquipmentForm = new FormStudentRequestEquipment(studentID);
            MDIHelper.LoadChildForm(requestEquipmentForm, this);
        }
    }
}
