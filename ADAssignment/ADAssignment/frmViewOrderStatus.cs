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
    public partial class frmViewOrderStatus : Form
    {
        public frmViewOrderStatus()
        {
            InitializeComponent();
        }

        private void btnCustomerDashboard_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard customer = new frmCustomerDashboard();
            customer.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("Select CNIC, OrderType, Price, OrderStatus from ManageCustomerOrderDetails where CarID=@idcar", con);
            command.Parameters.AddWithValue("idcar", txtOrderID.Text.Trim());
            SqlDataReader datareader;
            datareader = command.ExecuteReader();
            if (datareader.Read())
            {
                txtNIC.Text = datareader["CNIC"].ToString();
                txtOrderType.Text = datareader["OrderType"].ToString();
                txtPrice.Text = datareader["Price"].ToString();
                txtOrderStatus.Text = datareader["OrderStatus"].ToString();
            }
            else
            {
                txtNIC.Text = "";
                txtOrderType.Text = "";
                txtPrice.Text = "";
                txtOrderStatus.Text = "";
                MessageBox.Show("No data found....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
