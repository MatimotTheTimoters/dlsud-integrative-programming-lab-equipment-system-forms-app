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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEquipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEquipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEquipmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentMenuItem,
            this.equipmentMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentMenuItem
            // 
            this.studentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentMenuItem,
            this.viewStudentsMenuItem});
            this.studentMenuItem.Name = "studentMenuItem";
            this.studentMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentMenuItem.Text = "Student";
            // 
            // addNewStudentMenuItem
            // 
            this.addNewStudentMenuItem.Name = "addNewStudentMenuItem";
            this.addNewStudentMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewStudentMenuItem.Text = "Add New Student";
            // 
            // viewStudentsMenuItem
            // 
            this.viewStudentsMenuItem.Name = "viewStudentsMenuItem";
            this.viewStudentsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewStudentsMenuItem.Text = "View Students";
            // 
            // equipmentMenuItem
            // 
            this.equipmentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEquipmentMenuItem,
            this.viewEquipmentMenuItem,
            this.editEquipmentMenuItem});
            this.equipmentMenuItem.Name = "equipmentMenuItem";
            this.equipmentMenuItem.Size = new System.Drawing.Size(77, 20);
            this.equipmentMenuItem.Text = "Equipment";
            // 
            // addNewEquipmentMenuItem
            // 
            this.addNewEquipmentMenuItem.Name = "addNewEquipmentMenuItem";
            this.addNewEquipmentMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addNewEquipmentMenuItem.Text = "Add New Equipment";
            // 
            // viewEquipmentMenuItem
            // 
            this.viewEquipmentMenuItem.Name = "viewEquipmentMenuItem";
            this.viewEquipmentMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewEquipmentMenuItem.Text = "View Equipment";
            // 
            // editEquipmentMenuItem
            // 
            this.editEquipmentMenuItem.Name = "editEquipmentMenuItem";
            this.editEquipmentMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editEquipmentMenuItem.Text = "Edit Equipment";
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home (Admin)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}