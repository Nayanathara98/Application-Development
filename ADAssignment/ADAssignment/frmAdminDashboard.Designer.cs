namespace ADAssignment
{
    partial class frmAdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageCarDetails = new System.Windows.Forms.Button();
            this.btnManageCarPartsDetails = new System.Windows.Forms.Button();
            this.btnManageCustomerDetails = new System.Windows.Forms.Button();
            this.btnManageCustomerOrderDetails = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Admin Dashboard";
            // 
            // btnManageCarDetails
            // 
            this.btnManageCarDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCarDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCarDetails.Location = new System.Drawing.Point(20, 79);
            this.btnManageCarDetails.Name = "btnManageCarDetails";
            this.btnManageCarDetails.Size = new System.Drawing.Size(281, 42);
            this.btnManageCarDetails.TabIndex = 8;
            this.btnManageCarDetails.Text = "Manage Car Details";
            this.btnManageCarDetails.UseVisualStyleBackColor = false;
            this.btnManageCarDetails.Click += new System.EventHandler(this.btnManageCarDetails_Click);
            // 
            // btnManageCarPartsDetails
            // 
            this.btnManageCarPartsDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCarPartsDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCarPartsDetails.Location = new System.Drawing.Point(20, 128);
            this.btnManageCarPartsDetails.Name = "btnManageCarPartsDetails";
            this.btnManageCarPartsDetails.Size = new System.Drawing.Size(281, 42);
            this.btnManageCarPartsDetails.TabIndex = 9;
            this.btnManageCarPartsDetails.Text = "Manage Car Parts Details";
            this.btnManageCarPartsDetails.UseVisualStyleBackColor = false;
            this.btnManageCarPartsDetails.Click += new System.EventHandler(this.btnManageCarPartsDetails_Click);
            // 
            // btnManageCustomerDetails
            // 
            this.btnManageCustomerDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCustomerDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomerDetails.Location = new System.Drawing.Point(20, 176);
            this.btnManageCustomerDetails.Name = "btnManageCustomerDetails";
            this.btnManageCustomerDetails.Size = new System.Drawing.Size(281, 42);
            this.btnManageCustomerDetails.TabIndex = 10;
            this.btnManageCustomerDetails.Text = "Manage Customer Details";
            this.btnManageCustomerDetails.UseVisualStyleBackColor = false;
            this.btnManageCustomerDetails.Click += new System.EventHandler(this.btnManageCustomerDetails_Click);
            // 
            // btnManageCustomerOrderDetails
            // 
            this.btnManageCustomerOrderDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCustomerOrderDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomerOrderDetails.Location = new System.Drawing.Point(20, 228);
            this.btnManageCustomerOrderDetails.Name = "btnManageCustomerOrderDetails";
            this.btnManageCustomerOrderDetails.Size = new System.Drawing.Size(280, 42);
            this.btnManageCustomerOrderDetails.TabIndex = 11;
            this.btnManageCustomerOrderDetails.Text = "Manage Customer Order Details";
            this.btnManageCustomerOrderDetails.UseVisualStyleBackColor = false;
            this.btnManageCustomerOrderDetails.Click += new System.EventHandler(this.btnManageCustomerOrderDetails_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerateReports.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReports.Location = new System.Drawing.Point(20, 276);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(280, 42);
            this.btnGenerateReports.TabIndex = 12;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(315, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageCarDetails);
            this.Controls.Add(this.btnManageCarPartsDetails);
            this.Controls.Add(this.btnManageCustomerDetails);
            this.Controls.Add(this.btnManageCustomerOrderDetails);
            this.Controls.Add(this.btnGenerateReports);
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageCarDetails;
        private System.Windows.Forms.Button btnManageCarPartsDetails;
        private System.Windows.Forms.Button btnManageCustomerDetails;
        private System.Windows.Forms.Button btnManageCustomerOrderDetails;
        private System.Windows.Forms.Button btnGenerateReports;
    }
}