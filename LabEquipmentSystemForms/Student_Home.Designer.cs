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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.equipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewRequestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyRequestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyTransactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipmentMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // equipmentMenuItem
            // 
            this.equipmentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestsMenuItem,
            this.transactionsMenuItem});
            this.equipmentMenuItem.Name = "equipmentMenuItem";
            this.equipmentMenuItem.Size = new System.Drawing.Size(77, 20);
            this.equipmentMenuItem.Text = "Equipment";
            // 
            // requestsMenuItem
            // 
            this.requestsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNewRequestMenuItem,
            this.viewMyRequestsMenuItem});
            this.requestsMenuItem.Name = "requestsMenuItem";
            this.requestsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requestsMenuItem.Text = "Requests";
            // 
            // transactionsMenuItem
            // 
            this.transactionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyTransactionsMenuItem});
            this.transactionsMenuItem.Name = "transactionsMenuItem";
            this.transactionsMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // 
            // viewMyTransactionsMenuItem
            // 
            this.viewMyTransactionsMenuItem.Name = "viewMyTransactionsMenuItem";
            this.viewMyTransactionsMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewMyTransactionsMenuItem.Text = "View My Transactions";
            // 
            // FormStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home (Student)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equipmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNewRequestMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyRequestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyTransactionsMenuItem;
    }
}