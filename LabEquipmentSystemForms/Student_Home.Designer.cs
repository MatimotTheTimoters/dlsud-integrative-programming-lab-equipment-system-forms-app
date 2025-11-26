namespace LabEquipmentSystemForms
{
    partial class FormStudentHome
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.welcomeMessageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.requestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewRequestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyRequestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyTransactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestsMenuItem,
            this.transactionsMenuItem,
            this.inventoryMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 537);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeMessageMenuItem,
            this.timeMenuItem,
            this.logoutMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(984, 24);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // requestsMenuItem
            // 
            this.requestsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNewRequestMenuItem,
            this.viewMyRequestsMenuItem});
            this.requestsMenuItem.Name = "requestsMenuItem";
            this.requestsMenuItem.Size = new System.Drawing.Size(113, 19);
            this.requestsMenuItem.Text = "Requests";
            // 
            // transactionsMenuItem
            // 
            this.transactionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyTransactionsMenuItem});
            this.transactionsMenuItem.Name = "transactionsMenuItem";
            this.transactionsMenuItem.Size = new System.Drawing.Size(113, 19);
            this.transactionsMenuItem.Text = "Transactions";
            // 
            // makeNewRequestMenuItem
            // 
            this.makeNewRequestMenuItem.Name = "makeNewRequestMenuItem";
            this.makeNewRequestMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeNewRequestMenuItem.Text = "Make New Request";
            this.makeNewRequestMenuItem.Click += new System.EventHandler(this.makeNewRequestMenuItem_Click);
            // 
            // viewMyRequestsMenuItem
            // 
            this.viewMyRequestsMenuItem.Name = "viewMyRequestsMenuItem";
            this.viewMyRequestsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewMyRequestsMenuItem.Text = "View My Requests";
            this.viewMyRequestsMenuItem.Click += new System.EventHandler(this.viewMyRequestsMenuItem_Click);
            // 
            // viewMyTransactionsMenuItem
            // 
            this.viewMyTransactionsMenuItem.Name = "viewMyTransactionsMenuItem";
            this.viewMyTransactionsMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewMyTransactionsMenuItem.Text = "View My Transactions";
            this.viewMyTransactionsMenuItem.Click += new System.EventHandler(this.viewMyTransactionsMenuItem_Click);
            // 
            // inventoryMenuItem
            // 
            this.inventoryMenuItem.Name = "inventoryMenuItem";
            this.inventoryMenuItem.Size = new System.Drawing.Size(113, 19);
            this.inventoryMenuItem.Text = "Inventory";
            this.inventoryMenuItem.Click += new System.EventHandler(this.inventoryMenuItem_Click);
            // 
            // FormStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home (Student)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem welcomeMessageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNewRequestMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyRequestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyTransactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryMenuItem;
    }
}