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
    public partial class FormAdminReports : Form
    {
        public FormAdminReports()
        {
            InitializeComponent();

            SetTime();
        }

        private void FormAdminReports_Load(object sender, EventArgs e)
        {

        }

        private void SetTime()
        {
            timeMenuItem.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timeMenuItem_Click(object sender, EventArgs e)
        {
            SetTime();
        }
    }
}
