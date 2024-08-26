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
    public partial class frmManageCustomerOrderDetails : Form
    {
        public frmManageCustomerOrderDetails()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard admin = new frmAdminDashboard();
            admin.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtNIC.Text = "";
            txtOrderType.Text = "";
            txtPrice.Text = "";
            txtOrderStatus.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into ManageCustomerOrderDetails values (@OrderID, @CNIC, @OrderType, @Price, @OrderStatus)", con);
            command.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            command.Parameters.AddWithValue("@CNIC", (txtNIC.Text));
            command.Parameters.AddWithValue("@OrderType", (txtOrderType.Text));
            command.Parameters.AddWithValue("@Price", (txtPrice.Text));
            command.Parameters.AddWithValue("@OrderStatus", (txtOrderStatus.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCustomerOrderDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("update ManageCustomerOrderDetails set CNIC=@CNIC, OrderType=@OrderType, Price=@Price, OrderStatus=@OrderStatus where OrderID=@OrderID", con);
            command.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            command.Parameters.AddWithValue("@CNIC", (txtNIC.Text));
            command.Parameters.AddWithValue("@OrderType", (txtOrderType.Text));
            command.Parameters.AddWithValue("@Price", (txtPrice.Text));
            command.Parameters.AddWithValue("@OrderStatus", (txtOrderStatus.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("delete ManageCustomerOrderDetails where OrderID=@OrderID", con);
            command.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showDataGridData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCustomerOrderDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable; 
            
            SqlCommand command2 = new SqlCommand("select * from OrderCarorCarParts", con);
            SqlDataAdapter dataadapter2 = new SqlDataAdapter(command2);
            DataTable datatable2 = new DataTable();
            dataadapter2.Fill(datatable2);
            dataGridView2.DataSource = datatable2;
        }
        
        private void frmManageCustomerOrderDetails_Load(object sender, EventArgs e)
        {
            showDataGridData();
        }
    }
}
