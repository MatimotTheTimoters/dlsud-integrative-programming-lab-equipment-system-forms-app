namespace LabEquipmentSystemForms
{
    partial class FormAdminAddEquipment
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
            this.txtEquipmentId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipmentId.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtEquipmentId.Location = new System.Drawing.Point(178, 12);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.Size = new System.Drawing.Size(519, 36);
            this.txtEquipmentId.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEquipmentID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEquipmentId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudQuantity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(90, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 300);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(3, 180);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(169, 60);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "DESCRIPTION";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(3, 120);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(169, 60);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "QUANTITY";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtName.Location = new System.Drawing.Point(178, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(519, 36);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(3, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 60);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquipmentID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEquipmentID.Location = new System.Drawing.Point(3, 0);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(169, 60);
            this.lblEquipmentID.TabIndex = 0;
            this.lblEquipmentID.Text = "EQUIPMENT ID";
            this.lblEquipmentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCreate);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(519, 54);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 39);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(129, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.nudQuantity.Location = new System.Drawing.Point(178, 132);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(519, 36);
            this.nudQuantity.TabIndex = 6;
            this.nudQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rtbDescription
            // 
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.rtbDescription.Location = new System.Drawing.Point(178, 183);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(519, 54);
            this.rtbDescription.TabIndex = 8;
            this.rtbDescription.Text = "";
            // 
            // FormAdminAddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAdminAddEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Equipment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEquipmentId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}