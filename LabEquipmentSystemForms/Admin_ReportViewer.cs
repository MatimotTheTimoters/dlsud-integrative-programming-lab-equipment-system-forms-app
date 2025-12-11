using DataHelper;
using Microsoft.Reporting.WinForms;
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

namespace LabEquipmentSystemForms
{
    public partial class FormAdminReports : Form
    {
        string adminID;
        string pathToFormsProject = "PathToFormsProject"; // Sample: C:\Users\Default\source\repos\project\...

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
            reportViewer1.LocalReport.ReportPath = $@"{pathToFormsProject}\Admin_Report_Students.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetViewEquipment", DataAccess.ViewEquipment());
            reportViewer1.LocalReport.ReportPath = $@"{pathToFormsProject}\Admin_Report_Equipment.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void equipmentRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests();
        }

        private void pendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("PENDING");
        }

        private void approvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("APPROVED");
        }

        private void deniedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("DENIED");
        }
        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentRequests("COMPLETED");
        }

        private void equipmentTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentTransactions();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentTransactions("BORROW");
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEquipmentTransactions("RETURN");
        }
        private void returnToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminHome homeForm = new FormAdminHome(adminID);
            homeForm.Show();
            this.Close();
            homeForm.Focus();
        }

        private void DisplayEquipmentRequests(string status = "")
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetViewEquipmentRequests", DataAccess.ViewEquipmentRequests(status));
            reportViewer1.LocalReport.ReportPath = $@"{pathToFormsProject}\Admin_Report_EquipmentRequests.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void DisplayEquipmentTransactions(string type = "")
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSetViewEquipmentTransactions", DataAccess.ViewEquipmentTransactions(type));
            reportViewer1.LocalReport.ReportPath = $@"{pathToFormsProject}\Admin_Report_EquipmentTransactions.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

    }
}
