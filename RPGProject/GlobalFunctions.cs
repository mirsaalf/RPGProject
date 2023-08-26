using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject
{
    internal static class GlobalFunctions
    {
        public static SqlConnection ConnectToDatabase(string query)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return con;
        }

        public static SqlConnection ConnectToDatabase()
        {
            SqlConnection con = new SqlConnection(Program.connectionString);            
            con.Open();
            return con;
        }

    }
}
