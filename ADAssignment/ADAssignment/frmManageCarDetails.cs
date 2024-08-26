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
    public partial class frmManageCarDetails : Form
    {
        public frmManageCarDetails()
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
            txtCarID.Text = "";
            txtCarType.Text = "";
            txtGiyerSystem.Text = "";
            txtColour.Text = "";
            txtPrice.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("delete ManageCarDetails where CarID=@CarID", con);
            command.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("update ManageCarDetails set CarType=@CarType, GiyerSystem=@GiyerSystem, Colour=@Colour, Price=@Price where CarID=@CarID", con);
            command.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            command.Parameters.AddWithValue("@CarType", (txtCarType.Text));
            command.Parameters.AddWithValue("@GiyerSystem", (txtGiyerSystem.Text));
            command.Parameters.AddWithValue("@Colour", (txtColour.Text));
            command.Parameters.AddWithValue("@Price", (txtPrice.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCarDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into ManageCarDetails values (@CarID, @CarType, @GiyerSystem, @Colour, @Price)", con);
            command.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            command.Parameters.AddWithValue("@CarType", (txtCarType.Text));
            command.Parameters.AddWithValue("@GiyerSystem", (txtGiyerSystem.Text));
            command.Parameters.AddWithValue("@Colour", (txtColour.Text));
            command.Parameters.AddWithValue("@Price", (txtPrice.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showDataGridData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCarDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void frmManageCarDetails_Load(object sender, EventArgs e)
        {
            showDataGridData();
        }
    }
}
