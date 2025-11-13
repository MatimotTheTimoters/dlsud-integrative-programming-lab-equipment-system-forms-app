namespace LabEquipmentSystemForms
{
    partial class FormAdminHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEquipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEquipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEquipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processRequestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.welcomeMessageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentMenuItem,
            this.equipmentMenuItem,
            this.transactionsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(90, 533);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentMenuItem
            // 
            this.studentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentMenuItem,
            this.viewStudentsMenuItem});
            this.studentMenuItem.Name = "studentMenuItem";
            this.studentMenuItem.Size = new System.Drawing.Size(77, 19);
            this.studentMenuItem.Text = "Student";
            // 
            // addNewStudentMenuItem
            // 
            this.addNewStudentMenuItem.Name = "addNewStudentMenuItem";
            this.addNewStudentMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewStudentMenuItem.Text = "Add New Student";
            this.addNewStudentMenuItem.Click += new System.EventHandler(this.addNewStudentMenuItem_Click);
            // 
            // viewStudentsMenuItem
            // 
            this.viewStudentsMenuItem.Name = "viewStudentsMenuItem";
            this.viewStudentsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewStudentsMenuItem.Text = "View Students";
            this.viewStudentsMenuItem.Click += new System.EventHandler(this.viewStudentsMenuItem_Click);
            // 
            // equipmentMenuItem
            // 
            this.equipmentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEquipmentMenuItem,
            this.viewEquipmentMenuItem,
            this.editEquipmentMenuItem});
            this.equipmentMenuItem.Name = "equipmentMenuItem";
            this.equipmentMenuItem.Size = new System.Drawing.Size(77, 19);
            this.equipmentMenuItem.Text = "Equipment";
            // 
            // addNewEquipmentMenuItem
            // 
            this.addNewEquipmentMenuItem.Name = "addNewEquipmentMenuItem";
            this.addNewEquipmentMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addNewEquipmentMenuItem.Text = "Add New Equipment";
            this.addNewEquipmentMenuItem.Click += new System.EventHandler(this.addNewEquipmentMenuItem_Click);
            // 
            // viewEquipmentMenuItem
            // 
            this.viewEquipmentMenuItem.Name = "viewEquipmentMenuItem";
            this.viewEquipmentMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewEquipmentMenuItem.Text = "View Equipment";
            this.viewEquipmentMenuItem.Click += new System.EventHandler(this.viewEquipmentMenuItem_Click);
            // 
            // editEquipmentMenuItem
            // 
            this.editEquipmentMenuItem.Name = "editEquipmentMenuItem";
            this.editEquipmentMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editEquipmentMenuItem.Text = "Edit Equipment";
            this.editEquipmentMenuItem.Click += new System.EventHandler(this.editEquipmentMenuItem_Click);
            // 
            // transactionsMenuItem
            // 
            this.transactionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processRequestsMenuItem,
            this.viewTransactionsMenuItem});
            this.transactionsMenuItem.Name = "transactionsMenuItem";
            this.transactionsMenuItem.Size = new System.Drawing.Size(77, 19);
            this.transactionsMenuItem.Text = "Transactions";
            // 
            // processRequestsMenuItem
            // 
            this.processRequestsMenuItem.Name = "processRequestsMenuItem";
            this.processRequestsMenuItem.Size = new System.Drawing.Size(167, 22);
            this.processRequestsMenuItem.Text = "Process Requests";
            this.processRequestsMenuItem.Click += new System.EventHandler(this.processRequestsMenuItem_Click);
            // 
            // viewTransactionsMenuItem
            // 
            this.viewTransactionsMenuItem.Name = "viewTransactionsMenuItem";
            this.viewTransactionsMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewTransactionsMenuItem.Text = "View Transactions";
            this.viewTransactionsMenuItem.Click += new System.EventHandler(this.viewTransactionsMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeMessageMenuItem,
            this.timeMenuItem,
            this.logoutMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(980, 24);
            this.menuStrip2.TabIndex = 3;
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
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.logoutMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(68, 20);
            this.logoutMenuItem.Text = "LOGOUT";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home (Admin)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEquipmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEquipmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEquipmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processRequestsMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem welcomeMessageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
    }
}