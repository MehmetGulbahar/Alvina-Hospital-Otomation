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
    public partial class SecretaryLoginPanel : Form
    {
        public SecretaryLoginPanel()
        {
            InitializeComponent();
        }
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand commandSecretary = new SqlCommand("Select * From Secretary where secretary_tc=@p1 and secretary_password=@p2", databaseConnection.connection());
            commandSecretary.Parameters.AddWithValue("@p1", maskedTextboxIdentificationNumber.Text);
            commandSecretary.Parameters.AddWithValue("@p2", textBoxPassword.Text);
            SqlDataReader sqlDataReader = commandSecretary.ExecuteReader();
            if (sqlDataReader.Read())
            {

                SecretaryDetail detail = new SecretaryDetail();
                detail.identificationNumber = maskedTextboxIdentificationNumber.Text;
                this.Hide();
                detail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password might be wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SecretaryLoginPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
