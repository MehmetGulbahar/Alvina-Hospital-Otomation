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
using System.Security.Policy;

namespace hospital_automation_application
{
    public partial class DoctorDetailPage : Form
    {
        public DoctorDetailPage()
        {
            InitializeComponent();
        }
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public String identificationNumber;
        private void announcementsButton_Click(object sender, EventArgs e)
        {
            AnnouncementsPage announcementsPage = new AnnouncementsPage();
            announcementsPage.Show();

        }

        private void DoctorDetailPage_Load(object sender, EventArgs e)
        {
            labelIdentificationNumber.Text = identificationNumber;
            SqlCommand commandDoctor = new SqlCommand("Select doctor_name,doctor_lastname From Doctors where doctor_tc=@d1", databaseConnection.connection());
            commandDoctor.Parameters.AddWithValue("@d1", labelIdentificationNumber.Text);
            SqlDataReader readerDoctor = commandDoctor.ExecuteReader();
            while (readerDoctor.Read())
            {
                labelNameSurname.Text = (readerDoctor[0] + " " + readerDoctor[1]);
            }
            readerDoctor.Close();

            //Appointment detail to transfer datagridview
            DataTable tableAppointment = new DataTable();
            SqlDataAdapter commandAppointment = new SqlDataAdapter(
                "Select appointment_date, appointment_time, appointment_branch, appointment_status, patient_tc ,patient_complaint From Appointment where appointment_doctor = @doctorName",
                databaseConnection.connection());
            commandAppointment.SelectCommand.Parameters.AddWithValue("@doctorName", labelNameSurname.Text);
            commandAppointment.Fill(tableAppointment);
            dataGridView2.DataSource = tableAppointment;
            databaseConnection.connection().Close();
        }
        //
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editInformationButton_Click(object sender, EventArgs e)
        {
            InformationUpdateDoctorForm form = new InformationUpdateDoctorForm();
            form.identificationNumber = identificationNumber;
            form.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int chosenIndex = e.RowIndex;
                string patientTc = dataGridView2.Rows[chosenIndex].Cells[4].Value.ToString();
                richTextBoxComplaint.Text = dataGridView2.Rows[chosenIndex].Cells[5].Value.ToString();

                // Obtaining patient name and surname information from the database using the patient identification number.
                SqlCommand sqlCommand = new SqlCommand("Select patient_name, patient_lastname from Patients where patient_tc=@p1", databaseConnection.connection());
                sqlCommand.Parameters.AddWithValue("@p1", patientTc);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    labelPatientTcNumber.Text = reader["patient_name"] + " " + reader["patient_lastname"];
                }
                reader.Close();
                databaseConnection.connection().Close();
            }
        }


        private void DoctorDetailPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
  }
