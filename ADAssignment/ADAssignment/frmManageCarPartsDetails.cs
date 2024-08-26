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
    public partial class frmManageCarPartsDetails : Form
    {
        public frmManageCarPartsDetails()
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
            txtPartID.Text = "";
            txtPartName.Text = "";
            txtPrice.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into ManageCarPartsDetails values (@PartID, @PartName, @PartPrice)", con);
            command.Parameters.AddWithValue("@PartID", (txtPartID.Text));
            command.Parameters.AddWithValue("@PartName", (txtPartName.Text));
            command.Parameters.AddWithValue("@PartPrice", (txtPrice.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCarPartsDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("update ManageCarPartsDetails set PartName=@PartName, PartPrice=@PartPrice where PartID=@PartID", con);
            command.Parameters.AddWithValue("@PartID", (txtPartID.Text));
            command.Parameters.AddWithValue("@PartName", (txtPartName.Text));
            command.Parameters.AddWithValue("@PartPrice", (txtPrice.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("delete ManageCarPartsDetails where PartID=@PartID", con);
            command.Parameters.AddWithValue("@PartID", (txtPartID.Text));
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showDataGridData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Hansi\ESOFT\Assignments\Application Development\ADAssignment\ADAssignment\ADAssignmentDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from ManageCarPartsDetails", con);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void frmManageCarPartsDetails_Load(object sender, EventArgs e)
        {
            showDataGridData();
        }
    }
}
