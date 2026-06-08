using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareShop
{
    internal class functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter Sda;

        public int SetData(string Query)
        {
            int Cnt;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }

        public functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=HardwareDb;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = Con.CreateCommand();
            Cmd.Connection = Con;
        }
    }
}
