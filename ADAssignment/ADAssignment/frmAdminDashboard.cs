using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAssignment
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnManageCarDetails_Click(object sender, EventArgs e)
        {
            frmManageCarDetails ManageCarDetails = new frmManageCarDetails();
            ManageCarDetails.Show();
            this.Hide();
        }

        private void btnManageCarPartsDetails_Click(object sender, EventArgs e)
        {
            frmManageCarPartsDetails ManageCarPartsDetails = new frmManageCarPartsDetails();
            ManageCarPartsDetails.Show();
            this.Hide();
        }

        private void btnManageCustomerDetails_Click(object sender, EventArgs e)
        {
            frmManageCustomerDetails ManageCustomerDetails = new frmManageCustomerDetails();
            ManageCustomerDetails.Show();
            this.Hide();
        }

        private void btnManageCustomerOrderDetails_Click(object sender, EventArgs e)
        {
            frmManageCustomerOrderDetails ManageCustomerOrderDetails = new frmManageCustomerOrderDetails();
            ManageCustomerOrderDetails.Show();
            this.Hide();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            frmGenerateReports GenerateReports = new frmGenerateReports();
            GenerateReports.Show();
            this.Hide();
        }
    }
}
