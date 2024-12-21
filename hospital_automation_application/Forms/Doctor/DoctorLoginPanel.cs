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
    public partial class DoctorLoginPanel : Form
    {
        public DoctorLoginPanel()
        {
            InitializeComponent();
        }
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand commandDoctorLogin = new SqlCommand("Select * From Doctors where doctor_tc=@d1 and doctor_password=@d2", databaseConnection.connection());
            commandDoctorLogin.Parameters.AddWithValue("@d1", maskedTextboxIdentificationNumber.Text);
            commandDoctorLogin.Parameters.AddWithValue("@d2", textBoxPassword.Text);
            SqlDataReader readerDoctor = commandDoctorLogin.ExecuteReader();
            if (readerDoctor.Read())
            {
                DoctorDetailPage doctorDetailPage = new DoctorDetailPage();
                doctorDetailPage.identificationNumber = maskedTextboxIdentificationNumber.Text;
                this.Hide();
                doctorDetailPage.ShowDialog();
                
            }
            databaseConnection.connection().Close();
        }

        private void DoctorLoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
