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
        
          SqlConnection sqlConnection = new SqlConnection("*******BLANK*****");
          sqlConnection.Open();
          return sqlConnection;
        }
    }
}
