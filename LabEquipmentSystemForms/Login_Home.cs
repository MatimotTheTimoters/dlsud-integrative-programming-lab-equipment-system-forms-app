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
    public partial class FormLoginHome : Form
    {
        public FormLoginHome()
        {
            InitializeComponent();
        }

        private void studentLoginMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginStudent formLoginStudent = new FormLoginStudent();
            FormHelper.MDIHelper.LoadChildForm(formLoginStudent, this);
        }

        private void adminLoginMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginAdmin formLoginAdmin = new FormLoginAdmin();
            FormHelper.MDIHelper.LoadChildForm(formLoginAdmin, this);
        }
    }
}
