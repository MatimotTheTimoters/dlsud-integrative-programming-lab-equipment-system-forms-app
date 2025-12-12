namespace LabEquipmentSystemForms
{
    partial class FormStudentEquipmentInventory
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.lblEquipmentId = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(3, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(214, 45);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "FILTER BY";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReturnAmount.ForeColor = System.Drawing.Color.White;
            this.lblReturnAmount.Location = new System.Drawing.Point(3, 90);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(214, 45);
            this.lblReturnAmount.TabIndex = 13;
            this.lblReturnAmount.Text = "RETURN AMOUNT";
            this.lblReturnAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtReturnAmount.Location = new System.Drawing.Point(223, 96);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(434, 32);
            this.txtReturnAmount.TabIndex = 14;
            // 
            // cbFilter
            // 
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Open",
            "Closed"});
            this.cbFilter.Location = new System.Drawing.Point(223, 3);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(387, 33);
            this.cbFilter.TabIndex = 16;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtEquipmentID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEquipmentId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReturnAmount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblReturnAmount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 457);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipmentID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtEquipmentID.Location = new System.Drawing.Point(223, 51);
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.ReadOnly = true;
            this.txtEquipmentID.Size = new System.Drawing.Size(434, 32);
            this.txtEquipmentID.TabIndex = 21;
            // 
            // lblEquipmentId
            // 
            this.lblEquipmentId.AutoSize = true;
            this.lblEquipmentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEquipmentId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEquipmentId.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentId.Location = new System.Drawing.Point(3, 45);
            this.lblEquipmentId.Name = "lblEquipmentId";
            this.lblEquipmentId.Size = new System.Drawing.Size(214, 45);
            this.lblEquipmentId.TabIndex = 19;
            this.lblEquipmentId.Text = "EQUIPMENT ID";
            this.lblEquipmentId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel2.Controls.Add(this.btnReturn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(223, 138);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(434, 39);
            this.flowLayoutPanel2.TabIndex = 17;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 34);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(129, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 34);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "RETURN SELECTED";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView, 3);
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 183);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(874, 271);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // FormStudentEquipmentInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormStudentEquipmentInventory";
            this.Text = "Equipment Inventory";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.Label lblEquipmentId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReturn;
    }
}