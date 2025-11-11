namespace LabEquipmentSystemForms
{
    partial class FormAdminProcessEquipmentRequests
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFilter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStudentID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEquipmentID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEquipmentID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudQuantity, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbFilter);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(224, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(657, 40);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // cbFilter
            // 
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Denied"});
            this.cbFilter.Location = new System.Drawing.Point(3, 3);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(215, 33);
            this.cbFilter.TabIndex = 16;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(271, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "APPROVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(389, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "DENY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(3, 138);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(215, 46);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "FILTER BY";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(3, 92);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(215, 46);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "QUANTITY";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(224, 49);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(657, 43);
            this.txtStudentID.TabIndex = 4;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(3, 46);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(215, 46);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "STUDENT ID";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipmentID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentID.Location = new System.Drawing.Point(224, 3);
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.ReadOnly = true;
            this.txtEquipmentID.Size = new System.Drawing.Size(657, 43);
            this.txtEquipmentID.TabIndex = 2;
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquipmentID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentID.Location = new System.Drawing.Point(3, 0);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(215, 46);
            this.lblEquipmentID.TabIndex = 1;
            this.lblEquipmentID.Text = "EQUIPMENT ID";
            this.lblEquipmentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView, 2);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 187);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(878, 271);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.nudQuantity.Location = new System.Drawing.Point(224, 95);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ReadOnly = true;
            this.nudQuantity.Size = new System.Drawing.Size(657, 43);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FormAdminProcessEquipmentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAdminProcessEquipmentRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Requests";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}