using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_automation_application
{
    public partial class PatientDetail : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public PatientDetail()
        {
            InitializeComponent();
        }
        public string identityNumber;

        private void PatientDetail_Load(object sender, EventArgs e)
        {
            //Identification number, name and surname information
            labelIdentificationNumber.Text = identityNumber;
            SqlCommand sqlCommand = new SqlCommand("Select patient_name, patient_lastname from Patients where patient_tc=@p1", databaseConnection.connection());
            sqlCommand.Parameters.AddWithValue("@p1", labelIdentificationNumber.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                labelNameAndSurname.Text = reader[0] + " " + reader[1];
            }
            databaseConnection.connection().Close();

            // Appointment history
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Appointment where patient_tc = @patientTC", databaseConnection.connection());
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@patientTC", identityNumber);
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            //Branches Information
            SqlCommand sqlCommand1 = new SqlCommand("Select branch_name From Branches", databaseConnection.connection());
            SqlDataReader readerBranches = sqlCommand1.ExecuteReader();
            while (readerBranches.Read())
            {
                comboBoxBranch.Items.Add(readerBranches[0]);
            }
            databaseConnection.connection().Close();

            // Choosen branches to execute that form 
            comboBoxBranch.SelectedIndexChanged += new EventHandler(comboBoxBranch_SelectedIndexChanged);
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List doctors by selected branch
            comboBoxDoctor.Items.Clear();
            string selectedBranch = comboBoxBranch.SelectedItem.ToString();
            SqlCommand sqlDoctor = new SqlCommand("Select doctor_name, doctor_lastname From Doctors where doctor_major=@p1", databaseConnection.connection());
            sqlDoctor.Parameters.AddWithValue("@p1", selectedBranch);
            SqlDataReader sqlReaderDoctors = sqlDoctor.ExecuteReader();
            while (sqlReaderDoctors.Read())
            {
                comboBoxDoctor.Items.Add(sqlReaderDoctors["doctor_name"] + " " + sqlReaderDoctors["doctor_lastname"]);
            }
            databaseConnection.connection().Close();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tableDoctor = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Appointment where appointment_branch='"+comboBoxBranch.Text+"'" + " and appointment_doctor='" +comboBoxDoctor.Text + "' and appointment_status=0", databaseConnection.connection());
            sqlDataAdapter.Fill(tableDoctor);
            dataGridView2.DataSource = tableDoctor;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InformationUpdatePatientForm form = new InformationUpdatePatientForm();
            form.identificationNumber = identityNumber;
            form.ShowDialog();

        }

        private void PatientDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand commandCreateAppointment = new SqlCommand("update Appointment set  appointment_status=1,patient_tc=@p1,patient_complaint=@p2 where appointment_id=@p3 ", databaseConnection.connection());
            commandCreateAppointment.Parameters.AddWithValue("@p1", labelIdentificationNumber.Text);
            commandCreateAppointment.Parameters.AddWithValue("@p2",richTextBoxComplaint.Text);
            commandCreateAppointment.Parameters.AddWithValue("@p3",textBoxAppointmentId.Text);
            commandCreateAppointment.ExecuteNonQuery();
            databaseConnection.connection().Close();
            MessageBox.Show("Appointment created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int chosenIndex = e.RowIndex;
                textBoxAppointmentId.Text = dataGridView2.Rows[chosenIndex].Cells[0].Value.ToString();
                comboBoxBranch.Text = dataGridView2.Rows[chosenIndex].Cells[3].Value.ToString();
            }
        }

    }
}
