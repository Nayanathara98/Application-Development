namespace ADAssignment
{
    partial class frmCustomerDashboard
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSearchCarDetails = new System.Windows.Forms.Button();
            this.btnSearchCarPartsDetails = new System.Windows.Forms.Button();
            this.btnOrderCarorParts = new System.Windows.Forms.Button();
            this.btnViewOrderStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer Dashboard";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(16, 64);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(281, 42);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSearchCarDetails
            // 
            this.btnSearchCarDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchCarDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCarDetails.Location = new System.Drawing.Point(16, 113);
            this.btnSearchCarDetails.Name = "btnSearchCarDetails";
            this.btnSearchCarDetails.Size = new System.Drawing.Size(281, 42);
            this.btnSearchCarDetails.TabIndex = 15;
            this.btnSearchCarDetails.Text = "Search Car Details";
            this.btnSearchCarDetails.UseVisualStyleBackColor = false;
            this.btnSearchCarDetails.Click += new System.EventHandler(this.btnSearchCarDetails_Click);
            // 
            // btnSearchCarPartsDetails
            // 
            this.btnSearchCarPartsDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchCarPartsDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCarPartsDetails.Location = new System.Drawing.Point(16, 161);
            this.btnSearchCarPartsDetails.Name = "btnSearchCarPartsDetails";
            this.btnSearchCarPartsDetails.Size = new System.Drawing.Size(281, 42);
            this.btnSearchCarPartsDetails.TabIndex = 16;
            this.btnSearchCarPartsDetails.Text = "Search Car Parts Details";
            this.btnSearchCarPartsDetails.UseVisualStyleBackColor = false;
            this.btnSearchCarPartsDetails.Click += new System.EventHandler(this.btnSearchCarPartsDetails_Click);
            // 
            // btnOrderCarorParts
            // 
            this.btnOrderCarorParts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderCarorParts.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCarorParts.Location = new System.Drawing.Point(16, 213);
            this.btnOrderCarorParts.Name = "btnOrderCarorParts";
            this.btnOrderCarorParts.Size = new System.Drawing.Size(280, 42);
            this.btnOrderCarorParts.TabIndex = 17;
            this.btnOrderCarorParts.Text = "Order Car/Car Parts";
            this.btnOrderCarorParts.UseVisualStyleBackColor = false;
            this.btnOrderCarorParts.Click += new System.EventHandler(this.btnOrderCarorParts_Click);
            // 
            // btnViewOrderStatus
            // 
            this.btnViewOrderStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewOrderStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrderStatus.Location = new System.Drawing.Point(16, 261);
            this.btnViewOrderStatus.Name = "btnViewOrderStatus";
            this.btnViewOrderStatus.Size = new System.Drawing.Size(280, 42);
            this.btnViewOrderStatus.TabIndex = 18;
            this.btnViewOrderStatus.Text = "View Order Status";
            this.btnViewOrderStatus.UseVisualStyleBackColor = false;
            this.btnViewOrderStatus.Click += new System.EventHandler(this.btnViewOrderStatus_Click);
            // 
            // frmCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(312, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSearchCarDetails);
            this.Controls.Add(this.btnSearchCarPartsDetails);
            this.Controls.Add(this.btnOrderCarorParts);
            this.Controls.Add(this.btnViewOrderStatus);
            this.Name = "frmCustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSearchCarDetails;
        private System.Windows.Forms.Button btnSearchCarPartsDetails;
        private System.Windows.Forms.Button btnOrderCarorParts;
        private System.Windows.Forms.Button btnViewOrderStatus;
    }
}