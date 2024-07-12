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
    public partial class AppointmentList : Form
    {
        public AppointmentList()
        {
            InitializeComponent();
        }
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void AppointmentList_Load(object sender, EventArgs e)
        {
            DataTable tableAppointment = new DataTable();

            SqlDataAdapter commandAppointment = new SqlDataAdapter("Select appointment_id AS[ID],appointment_date AS [Date],appointment_time As  [Time],appointment_branch AS [Branch],appointment_doctor AS [Doctor],appointment_status AS [Status],patient_tc AS [Patient Tc]  From Appointment", databaseConnection.connection());
            commandAppointment.Fill(tableAppointment);
            dataGridView1.DataSource = tableAppointment;
            databaseConnection.connection().Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the announcement text from the clicked row
                string appointmentDate = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string appointmentTime = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string appointmentBranch = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string appointmentDoctor = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                string message = $"Date: {appointmentDate}\nTime: {appointmentTime}\nBranch: {appointmentBranch}\nDoctor: {appointmentDoctor}";
                // Display the announcement in a MessageBox
                MessageBox.Show(message, "Appointment Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
