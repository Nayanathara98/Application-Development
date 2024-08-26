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
    public partial class frmSearchCarDetails : Form
    {
        public frmSearchCarDetails()
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
            SqlCommand command = new SqlCommand("Select CarType, GiyerSystem, Colour, Price from ManageCarDetails where CarID=@idcar", con);
            command.Parameters.AddWithValue("idcar", txtCarID.Text.Trim());
            SqlDataReader datareader;
            datareader = command.ExecuteReader();
            if (datareader.Read())
            {
                txtCarType.Text = datareader["CarType"].ToString();
                txtGiyerSystem.Text = datareader["GiyerSystem"].ToString();
                txtColour.Text = datareader["Colour"].ToString();
                txtPrice.Text = datareader["Price"].ToString();
            }
            else
            {
                txtCarType.Text = "";
                txtGiyerSystem.Text = "";
                txtColour.Text = "";
                txtPrice.Text = "";
                MessageBox.Show("No data found....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
