using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hospital_automation_application
{
    internal class DatabaseConnection
    {
        public SqlConnection connection() { 
        
          SqlConnection sqlConnection = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True;TrustServerCertificate=True");
          sqlConnection.Open();
          return sqlConnection;
        }
    }
}
