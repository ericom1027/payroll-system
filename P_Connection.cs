using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Payroll_System
{
    class P_Connection
    {
        public static SqlConnection conn = null;

        public void Connection_P()
        {
            conn = new SqlConnection("Data Source=AUGUSTA;Initial Catalog=Payroll;Integrated Security=SSPI;User ID=admin;Password=sql_2014");
            conn.Open();
        
        }
    }
}
