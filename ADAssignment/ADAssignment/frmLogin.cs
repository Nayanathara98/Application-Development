using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADAssignment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" || txtPassword.Text == "admin123")
            {
                frmAdminDashboard frm = new frmAdminDashboard();
                frm.Show();
                this.Hide();
            }
            else if (txtUserName.Text == "User" || txtPassword.Text == "user123")
            {
                frmCustomerDashboard frm = new frmCustomerDashboard();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please check your username & password....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
