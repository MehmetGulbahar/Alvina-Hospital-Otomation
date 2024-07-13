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
    public partial class InformationUpdateDoctorForm : Form
    {
        public InformationUpdateDoctorForm()
        {
            InitializeComponent();
        }

        DatabaseConnection databaseConnection = new DatabaseConnection();
        public String identificationNumber;
        private void InformationUpdateDoctorForm_Load(object sender, EventArgs e)
        {
            maskedTextboxIdentificationNumber.Text = identificationNumber;
            SqlCommand commandDoctor = new SqlCommand("Select * From Doctors where doctor_tc=@d1", databaseConnection.connection());
            commandDoctor.Parameters.AddWithValue("@d1",maskedTextboxIdentificationNumber.Text);
            SqlDataReader readerDoctor = commandDoctor.ExecuteReader();
            if(readerDoctor.Read())
            {
                textboxFirstName.Text = readerDoctor[1].ToString();
                textBoxLastName.Text = readerDoctor[2].ToString();
                comboBoxBranch.Text = readerDoctor[3].ToString();
                maskedTextboxIdentificationNumber.Text = readerDoctor[4].ToString();
                textBoxPassword.Text = readerDoctor[5].ToString();

            }
            databaseConnection.connection().Close();


        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlCommand commandUpdateInfoDoctor = new SqlCommand("update Doctors set doctor_name=@d1,doctor_lastname=@d2,doctor_major=@d3,doctor_password=@d4 where doctor_tc=@d5", databaseConnection.connection());
            commandUpdateInfoDoctor.Parameters.AddWithValue("@d1",textboxFirstName.Text);
            commandUpdateInfoDoctor.Parameters.AddWithValue("@d2",textBoxLastName.Text);
            commandUpdateInfoDoctor.Parameters.AddWithValue("@d3",comboBoxBranch.Text);
            commandUpdateInfoDoctor.Parameters.AddWithValue("@d4", textBoxPassword.Text);
            commandUpdateInfoDoctor.Parameters.AddWithValue("@d5", maskedTextboxIdentificationNumber.Text);
            commandUpdateInfoDoctor.ExecuteNonQuery();
            MessageBox.Show("Doctor information updated succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
