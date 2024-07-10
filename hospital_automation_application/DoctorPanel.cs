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
                "SELECT (doctor_name + ' ' + doctor_lastname) AS 'Doctors Names', doctor_major FROM Doctors",
                databaseConnection.connection());
            commandDoctors.Fill(tableDoctors);
            dataGridView1.DataSource = tableDoctors;
            databaseConnection.connection().Close();
        }
    }
}
