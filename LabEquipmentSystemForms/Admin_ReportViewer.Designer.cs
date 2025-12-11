namespace LabEquipmentSystemForms
{
    partial class FormAdminReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.welcomeMessageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deniedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeMessageMenuItem,
            this.timeMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(984, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // welcomeMessageMenuItem
            // 
            this.welcomeMessageMenuItem.Name = "welcomeMessageMenuItem";
            this.welcomeMessageMenuItem.Size = new System.Drawing.Size(121, 20);
            this.welcomeMessageMenuItem.Text = "[welcomeMessage]";
            // 
            // timeMenuItem
            // 
            this.timeMenuItem.Name = "timeMenuItem";
            this.timeMenuItem.Size = new System.Drawing.Size(51, 20);
            this.timeMenuItem.Text = "[time]";
            this.timeMenuItem.Click += new System.EventHandler(this.timeMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.equipmentToolStripMenuItem,
            this.equipmentRequestsToolStripMenuItem,
            this.equipmentTransactionsToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            this.equipmentToolStripMenuItem.Click += new System.EventHandler(this.equipmentToolStripMenuItem_Click);
            // 
            // equipmentRequestsToolStripMenuItem
            // 
            this.equipmentRequestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingToolStripMenuItem,
            this.approvedToolStripMenuItem,
            this.deniedToolStripMenuItem});
            this.equipmentRequestsToolStripMenuItem.Name = "equipmentRequestsToolStripMenuItem";
            this.equipmentRequestsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.equipmentRequestsToolStripMenuItem.Text = "Equipment Requests";
            this.equipmentRequestsToolStripMenuItem.Click += new System.EventHandler(this.equipmentRequestsToolStripMenuItem_Click);
            // 
            // pendingToolStripMenuItem
            // 
            this.pendingToolStripMenuItem.Name = "pendingToolStripMenuItem";
            this.pendingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pendingToolStripMenuItem.Text = "Pending";
            this.pendingToolStripMenuItem.Click += new System.EventHandler(this.pendingToolStripMenuItem_Click);
            // 
            // approvedToolStripMenuItem
            // 
            this.approvedToolStripMenuItem.Name = "approvedToolStripMenuItem";
            this.approvedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.approvedToolStripMenuItem.Text = "Approved";
            this.approvedToolStripMenuItem.Click += new System.EventHandler(this.approvedToolStripMenuItem_Click);
            // 
            // deniedToolStripMenuItem
            // 
            this.deniedToolStripMenuItem.Name = "deniedToolStripMenuItem";
            this.deniedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deniedToolStripMenuItem.Text = "Denied";
            this.deniedToolStripMenuItem.Click += new System.EventHandler(this.deniedToolStripMenuItem_Click);
            // 
            // equipmentTransactionsToolStripMenuItem
            // 
            this.equipmentTransactionsToolStripMenuItem.Name = "equipmentTransactionsToolStripMenuItem";
            this.equipmentTransactionsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.equipmentTransactionsToolStripMenuItem.Text = "Equipment Transactions";
            this.equipmentTransactionsToolStripMenuItem.Click += new System.EventHandler(this.equipmentTransactionsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LabEquipmentSystemForms.Admin_DataSetEditor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 537);
            this.reportViewer1.TabIndex = 5;
            // 
            // FormAdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAdminReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FormAdminReports_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem welcomeMessageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deniedToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}