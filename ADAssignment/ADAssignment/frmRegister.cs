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
    public partial class frmRegister : Form
    {
        public frmRegister()
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNIC.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtContactNumber.Text = "";
            txtCarID.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into ManageCustomerDetails values (@CNIC, @CName, @CAddress,@CTP, @CarID)", con);
            command.Parameters.AddWithValue("@CNIC", (txtNIC.Text));
            command.Parameters.AddWithValue("@CName", (txtName.Text));
            command.Parameters.AddWithValue("@CAddress", (txtAddress.Text));
            command.Parameters.AddWithValue("@CTP", (txtContactNumber.Text));
            command.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCustomerDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("update ManageCustomerDetails set CName=@CName, CAddress=@CAddress, CTP=@CTP, CarID=@CarID where CNIC=@CNIC", con);
            command.Parameters.AddWithValue("@CNIC", (txtNIC.Text));
            command.Parameters.AddWithValue("@CName", (txtName.Text));
            command.Parameters.AddWithValue("@CAddress", (txtAddress.Text));
            command.Parameters.AddWithValue("@CTP", (txtContactNumber.Text));
            command.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("delete ManageCustomerDetails where CNIC=@CNIC", con);
            command.Parameters.AddWithValue("@CNIC", (txtNIC.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showDataGridData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCustomerDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }
        
        private void frmRegister_Load(object sender, EventArgs e)
        {
            showDataGridData();
        }
    }
}
