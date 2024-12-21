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
    public partial class SecretaryDetail : Form
    {
        public SecretaryDetail()
        {
            InitializeComponent();
        }
        public String identificationNumber;
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void SecretaryDetail_Load(object sender, EventArgs e)
        {
            //Personal information taking from identificationnumber
           labelIdentificationNumber.Text = identificationNumber;
           SqlCommand sqlCommand = new SqlCommand("Select secretary_firstname_lastname from Secretary where secretary_tc=@p1", databaseConnection.connection());
           sqlCommand.Parameters.AddWithValue("@p1",labelIdentificationNumber.Text);
           SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                labelNameSurname.Text = reader[0].ToString();
            }
            reader.Close();  

            // Doctor table information retrieval from database
            DataTable tableDoctors = new DataTable();
            SqlDataAdapter commandDoctors = new SqlDataAdapter(
                "SELECT (doctor_name + ' ' + doctor_lastname) AS 'Doctors Names', doctor_major FROM Doctors",
                databaseConnection.connection());
            commandDoctors.Fill(tableDoctors);
            dataGridViewDoctors.DataSource = tableDoctors;

            // Branch information retrieval from database
            SqlCommand commandBranch = new SqlCommand("Select branch_name From Branches", databaseConnection.connection());
            SqlDataReader readerBranch = commandBranch.ExecuteReader();
            while (readerBranch.Read())
            {
                comboBoxBranch.Items.Add(readerBranch[0]);
            }
            readerBranch.Close();

            DataTable tableBranches = new DataTable();
            SqlDataAdapter commandBranches = new SqlDataAdapter("Select branch_name From Branches", databaseConnection.connection());
            commandBranches.Fill(tableBranches);
            dataGridViewBranches.DataSource = tableBranches;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Appointment (appointment_date,appointment_time,appointment_branch,appointment_doctor,appointment_status,patient_tc) values (@a1,@a2,@a3,@a4,@a5,@a6)", databaseConnection.connection());
            sqlCommand.Parameters.AddWithValue("@a1",maskedTextBoxAppointmentDate.Text);
            sqlCommand.Parameters.AddWithValue("@a2",maskedTextBoxAppointmentTime.Text);
            sqlCommand.Parameters.AddWithValue("@a3", comboBoxBranch.Text);
            sqlCommand.Parameters.AddWithValue("@a4",comboBoxDoctor.Text);
            sqlCommand.Parameters.AddWithValue("@a5",checkBoxStatus.Checked);
            sqlCommand.Parameters.AddWithValue("@a6", maskedTextBoxPatientTcNumber.Text);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.connection().Close();
            MessageBox.Show("Appointment created successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoctor.Items.Clear();
            // Doctor information retrieval from database
            SqlCommand commandDoctor = new SqlCommand("Select doctor_name,doctor_lastname From Doctors where doctor_major=@d1", databaseConnection.connection());
            commandDoctor.Parameters.AddWithValue("@d1", comboBoxBranch.Text);
            SqlDataReader readerDoctor = commandDoctor.ExecuteReader();
            while (readerDoctor.Read())
            {
                comboBoxDoctor.Items.Add(readerDoctor[0] + " " + readerDoctor[1]);
            }
            readerDoctor.Close();
        }

        private void buttonCreateAnnouncement_Click(object sender, EventArgs e)
        {
            SqlCommand commandAnnouncement = new SqlCommand("insert into Announcements (announcement) values (@a1)", databaseConnection.connection());
            commandAnnouncement.Parameters.AddWithValue("@a1",richTextBoxAnnouncement.Text);
            commandAnnouncement.ExecuteNonQuery();
            databaseConnection.connection().Close();
            MessageBox.Show("Announcement created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoctorPanel_Click(object sender, EventArgs e)
        {
            DoctorPanel doctorPanel = new DoctorPanel();
            doctorPanel.ShowDialog();
        }

        private void buttonBranchPanel_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm();
            branchForm.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAppointmentList_Click(object sender, EventArgs e)
        {
            AppointmentList appointmentList = new AppointmentList();
            appointmentList.ShowDialog();

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAnnouncements_Click(object sender, EventArgs e)
        {
            AnnouncementsPage announcementsPage = new AnnouncementsPage();
            announcementsPage.ShowDialog();
        }
    }
}
