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

            //Appointment history 
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Appointment where patient_tc=" + identityNumber, databaseConnection.connection());
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
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Appointment where appointment_branch='"+comboBoxBranch.Text+"'",databaseConnection.connection());
            sqlDataAdapter.Fill(tableDoctor);
            dataGridView2.DataSource = tableDoctor;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InformationUpdatePatientForm form = new InformationUpdatePatientForm();
            form.identificationNumber = identityNumber;
            form.ShowDialog();

        }

      
    }
}
