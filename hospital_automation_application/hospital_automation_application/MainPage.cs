using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_automation_application
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientLoginForm patientLoginForm = new PatientLoginForm();
            patientLoginForm.Show();
            this.Hide();
        }

        private void buttonDoctorLogin_Click(object sender, EventArgs e)
        {
            DoctorLoginPanel doctorLoginPanel = new DoctorLoginPanel();
            doctorLoginPanel.Show();
            this.Hide();
        }

        private void buttonSecretaryLogin_Click(object sender, EventArgs e)
        {
            SecretaryLoginPanel secretaryLoginPanel = new SecretaryLoginPanel();
            secretaryLoginPanel.Show();
            this.Hide();
        }
    }
}
