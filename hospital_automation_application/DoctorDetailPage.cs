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
    public partial class DoctorDetailPage : Form
    {
        public DoctorDetailPage()
        {
            InitializeComponent();
        }
        private void announcementsButton_Click(object sender, EventArgs e)
        {
            AnnouncementsPage announcementsPage = new AnnouncementsPage();
            announcementsPage.Show();
            
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoctorDetailPage_Load(object sender, EventArgs e)
        {

        }
    }
}
