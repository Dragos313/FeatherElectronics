using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FeatherElectronics
{
    internal class DBConnect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DVMI7TK\SQLEXPRESS;Initial Catalog=FeatherElectronics;Integrated Security=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
