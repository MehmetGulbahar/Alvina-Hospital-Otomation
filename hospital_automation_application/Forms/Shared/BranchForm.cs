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

namespace hospital_automation_application
{
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
        }

        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void BranchForm_Load(object sender, EventArgs e)
        {

            //Branches table information taking from database 
            DataTable tableBranches = new DataTable();
            SqlDataAdapter commandBranches = new SqlDataAdapter("Select branch_id, branch_name From Branches", databaseConnection.connection());
            commandBranches.Fill(tableBranches);
            dataGridView1.DataSource = tableBranches;

            databaseConnection.connection().Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxBranchId.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            textBoxBranchName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand commandAddBranch = new SqlCommand("insert into Branches (branch_name) values (@b1)", databaseConnection.connection());
            commandAddBranch.Parameters.AddWithValue("@b1", textBoxBranchName.Text);
            commandAddBranch.ExecuteNonQuery();
            MessageBox.Show("Branch created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdateBranch = new SqlCommand("UPDATE Branches SET branch_name=@b1 WHERE branch_id=@b2", databaseConnection.connection());
            commandUpdateBranch.Parameters.AddWithValue("@b1", textBoxBranchName.Text);
            commandUpdateBranch.Parameters.AddWithValue("@b2", textBoxBranchId.Text);
            commandUpdateBranch.ExecuteNonQuery();
            databaseConnection.connection().Close();
            MessageBox.Show(textBoxBranchName.Text + " Updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDeleteBranch = new SqlCommand("delete from Branches where branch_id = @b1", databaseConnection.connection());
            commandDeleteBranch.Parameters.AddWithValue("@b1", textBoxBranchId.Text);
            commandDeleteBranch.ExecuteNonQuery();
            databaseConnection.connection().Close();
            MessageBox.Show(textBoxBranchName.Text + " Deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
