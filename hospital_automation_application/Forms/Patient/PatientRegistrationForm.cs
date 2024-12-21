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
    public partial class PatientRegistrationForm : Form
    {
        public PatientRegistrationForm()
        {
            InitializeComponent();
        }
        DatabaseConnection connection = new DatabaseConnection();
        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Patients (patient_name,patient_lastname,patient_tc,patient_phone_number,patient_password,patient_gender) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection.connection());
            sqlCommand.Parameters.AddWithValue("@p1", textboxFirstName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", textBoxLastName.Text);
            sqlCommand.Parameters.AddWithValue("@p3", maskedTextboxIdentificationNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p4", maskedTextBoxPhoneNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p5", textBoxPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p6", comboBoxGender.Text);
            sqlCommand.ExecuteNonQuery();
            connection.connection().Close();
            MessageBox.Show("Patient Registiration Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
