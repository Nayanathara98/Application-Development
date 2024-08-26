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
    public partial class frmCustomerDashboard : Form
    {
        public frmCustomerDashboard()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister Register = new frmRegister();
            Register.Show();
            this.Hide();
        }

        private void btnSearchCarDetails_Click(object sender, EventArgs e)
        {
            frmSearchCarDetails SearchCarDetails = new frmSearchCarDetails();
            SearchCarDetails.Show();
            this.Hide();
        }

        private void btnSearchCarPartsDetails_Click(object sender, EventArgs e)
        {
            frmSearchCarPartsDetails SearchCarPartsDetails = new frmSearchCarPartsDetails();
            SearchCarPartsDetails.Show();
            this.Hide();
        }

        private void btnOrderCarorParts_Click(object sender, EventArgs e)
        {
            frmOrderCarorCarParts OrderCarorCarParts = new frmOrderCarorCarParts();
            OrderCarorCarParts.Show();
            this.Hide();
        }

        private void btnViewOrderStatus_Click(object sender, EventArgs e)
        {
            frmViewOrderStatus ViewOrderStatus = new frmViewOrderStatus();
            ViewOrderStatus.Show();
            this.Hide();
        }
    }
}
