using Microsoft.Reporting.WinForms;
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
    public partial class FormAdminReports : Form
    {
        string adminID;
        string rdlcPath = "C:\\Users\\Matthew\\source\\repos\\BIT34_StaAna_IntegProg_LabEquipmentSystem\\LabEquipmentSystemForms\\Admin_DataSetEditor.rdlc";

        public FormAdminReports(string adminID)
        {
            InitializeComponent();

            SetTime();
            this.adminID = adminID;
            welcomeMessageMenuItem.Text = "Welcome, " + adminID;
        }

        private void FormAdminReports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void SetTime()
        {
            timeMenuItem.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timeMenuItem_Click(object sender, EventArgs e)
        {
            SetTime();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetViewStudents", DataAccess.ViewStudents());
            reportViewer1.LocalReport.ReportPath = rdlcPath;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetViewEquipment", DataAccess.ViewEquipment());
            reportViewer1.LocalReport.ReportPath = rdlcPath;
            reportViewer1.LocalReport.DataSources.Add(rds);
        }

        private void equipmentRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("all");
        }

        private void pendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("pending");
        }

        private void approvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("approved");
        }

        private void deniedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("denied");
        }

        private void equipmentTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetViewEquipmentTransactions", DataAccess.ViewEquipmentTransactions());
            reportViewer1.LocalReport.ReportPath = rdlcPath;
            reportViewer1.LocalReport.DataSources.Add(rds);
        }

        private void DisplayEquipmentRequests(string status)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetViewEquipmentRequests", DataAccess.ViewEquipmentRequests(status));
            reportViewer1.LocalReport.ReportPath = rdlcPath;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
