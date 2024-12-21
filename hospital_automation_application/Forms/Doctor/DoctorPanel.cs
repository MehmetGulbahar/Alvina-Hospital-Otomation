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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel()
        {
            InitializeComponent();
        }
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            // Doctor table information retrieval from database
            DataTable tableDoctors = new DataTable();
            SqlDataAdapter commandDoctors = new SqlDataAdapter(
                "SELECT doctor_id AS[ID], doctor_name AS [Doctor Name], doctor_lastname AS [Doctor Lastname], doctor_major AS [Doctor Major],doctor_tc AS [Doctor TC],doctor_password AS [Password] FROM Doctors",
                databaseConnection.connection());
            commandDoctors.Fill(tableDoctors);
            dataGridView1.DataSource = tableDoctors;
            databaseConnection.connection().Close();

            // Branch information retrieval from database
            SqlCommand commandBranch = new SqlCommand("Select branch_name From Branches", databaseConnection.connection());
            SqlDataReader readerBranch = commandBranch.ExecuteReader();
            while (readerBranch.Read())
            {
                comboBoxBranch.Items.Add(readerBranch[0]);
            }
            readerBranch.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            comboBoxBranch.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            maskedTextBoxIdentityNum.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            textBoxPassword.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand commandAddDoctor = new SqlCommand("insert into Doctors (doctor_name,doctor_lastname,doctor_major,doctor_tc,doctor_password) values (@d1,@d2,@d3,@d4,@d5)", databaseConnection.connection());
            commandAddDoctor.Parameters.AddWithValue("@d1", textBoxName.Text);
            commandAddDoctor.Parameters.AddWithValue("@d2",textBoxSurname.Text);
            commandAddDoctor.Parameters.AddWithValue("@d3", comboBoxBranch.Text);
            commandAddDoctor.Parameters.AddWithValue("@d4",maskedTextBoxIdentityNum.Text);
            commandAddDoctor.Parameters.AddWithValue("@d5",textBoxPassword.Text);
            commandAddDoctor.ExecuteNonQuery();
            databaseConnection.connection().Close();
            MessageBox.Show(textBoxName.Text + " Doctor saved successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteDoctor = new SqlCommand("Delete From Doctors where doctor_tc=@d1", databaseConnection.connection());
            deleteDoctor.Parameters.AddWithValue("@d1", maskedTextBoxIdentityNum.Text);
            deleteDoctor.ExecuteNonQuery ();
            databaseConnection.connection().Close();
            MessageBox.Show(textBoxName.Text + " " + textBoxSurname.Text + " Doctor has been deleted", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdateDoctor = new SqlCommand(
                "update Doctors SET doctor_name=@d1, doctor_lastname=@d2, doctor_major=@d3, doctor_password=@d5 WHERE doctor_tc=@d4",
                databaseConnection.connection()
            );
            commandUpdateDoctor.Parameters.AddWithValue("@d1", textBoxName.Text);
            commandUpdateDoctor.Parameters.AddWithValue("@d2", textBoxSurname.Text);
            commandUpdateDoctor.Parameters.AddWithValue("@d3", comboBoxBranch.Text);
            commandUpdateDoctor.Parameters.AddWithValue("@d4", maskedTextBoxIdentityNum.Text);
            commandUpdateDoctor.Parameters.AddWithValue("@d5", textBoxPassword.Text);
            commandUpdateDoctor.ExecuteNonQuery();
            databaseConnection.connection().Close();
            MessageBox.Show(textBoxName.Text + " Doctor updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
