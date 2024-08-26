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
    public partial class frmSearchCarPartsDetails : Form
    {
        public frmSearchCarPartsDetails()
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
            SqlCommand command = new SqlCommand("Select PartName, PartPrice from ManageCarPartsDetails where PartID=@idcar", con);
            command.Parameters.AddWithValue("idcar", txtPartID.Text.Trim());
            SqlDataReader datareader;
            datareader = command.ExecuteReader();
            if (datareader.Read())
            {
                txtPartName.Text = datareader["PartName"].ToString();
                txtPrice.Text = datareader["PartPrice"].ToString();
            }
            else
            {
                txtPartName.Text = "";
                txtPrice.Text = "";
                MessageBox.Show("No data found....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
