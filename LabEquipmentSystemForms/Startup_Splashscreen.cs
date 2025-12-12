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
    public partial class FormStartupSplashScreen : Form
    {
        public FormStartupSplashScreen()
        {
            InitializeComponent();
        }

        private void FormStartupSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            lblLoadingValue.Text = progressBar1.Value.ToString() + "%";
            
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                FormLoginHome formLogin = new FormLoginHome();
                formLogin.Show();
                formLogin.Focus();
                this.Hide();
            }
        }
    }
}
