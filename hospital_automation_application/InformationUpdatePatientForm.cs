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
    public partial class InformationUpdatePatientForm : Form
    {
        public InformationUpdatePatientForm()
        {
            InitializeComponent();
        }
        public String identificationNumber;
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void InformationUpdatePatientForm_Load(object sender, EventArgs e)
        {

            maskedTextboxIdentificationNumber.Text = identificationNumber;
            SqlCommand sqlCommand = new SqlCommand("Select * From Patients where patient_tc=@p1", databaseConnection.connection());
            sqlCommand.Parameters.AddWithValue("@p1", maskedTextboxIdentificationNumber.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                textboxFirstName.Text = reader[1].ToString();
                textBoxLastName.Text = reader[2].ToString();
                maskedTextBoxPhoneNumber.Text = reader[4].ToString();
                textBoxPassword.Text = reader[5].ToString();
                comboBoxGender.Text = reader[6].ToString();

            }
            databaseConnection.connection().Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdateInfo= new SqlCommand("update patients set patient_name=@p1,patient_lastname=@p2,patient_phone_number=@p3,patient_password=@p4,patient_gender=@p5 where patient_tc=@p6", databaseConnection.connection());
            commandUpdateInfo.Parameters.AddWithValue("@p1",textboxFirstName.Text);
            commandUpdateInfo.Parameters.AddWithValue("@p2",textBoxLastName.Text);
            commandUpdateInfo.Parameters.AddWithValue("@p3", maskedTextBoxPhoneNumber.Text);
            commandUpdateInfo.Parameters.AddWithValue("@p4",textBoxPassword.Text);
            commandUpdateInfo.Parameters.AddWithValue("@p5",comboBoxGender.Text);
            commandUpdateInfo.Parameters.AddWithValue("@p6", maskedTextboxIdentificationNumber.Text);
            commandUpdateInfo.ExecuteNonQuery();
            MessageBox.Show("User information updated succesfully!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
