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
    public partial class PatientLoginForm : Form
    {
        public PatientLoginForm()
        {
            InitializeComponent();
        }

        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegistrationForm form = new PatientRegistrationForm();
            form.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Patients where patient_tc=@p1 and patient_password=@p2", databaseConnection.connection());
            sqlCommand.Parameters.AddWithValue("@p1", maskedTextboxIdentificationNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p2",textBoxPassword.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if(sqlDataReader.Read())
            {
                PatientDetail patientDetail = new PatientDetail();
                patientDetail.identityNumber = maskedTextboxIdentificationNumber.Text;
                this.Hide();
                patientDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            databaseConnection.connection().Close();

        }

       
    }
}
