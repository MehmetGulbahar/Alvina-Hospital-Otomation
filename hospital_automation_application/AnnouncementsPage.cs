using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital_automation_application
{
    public partial class AnnouncementsPage : Form
    {
        public AnnouncementsPage()
        {
            InitializeComponent();
        }

        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void AnnouncementsPage_Load(object sender, EventArgs e)
        {
            DataTable tableAnnouncements = new DataTable();
            SqlDataAdapter commandAnnouncements = new SqlDataAdapter("Select announcement From Announcements", databaseConnection.connection());
            commandAnnouncements.Fill(tableAnnouncements);
            dataGridView1.DataSource = tableAnnouncements;

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the announcement text from the clicked row
                string announcement = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                // Display the announcement in a MessageBox
                MessageBox.Show(announcement, "Announcement Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
