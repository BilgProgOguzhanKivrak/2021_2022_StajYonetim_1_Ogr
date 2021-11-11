using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace StayYonetimProg.AccessLayer
{
    public class DataAccessLayer
    {
        public string getConnection()
        {
            return "Server=localhost;Database=StajYonetimBirinciOgretim;Trusted_Connection=True;";
        }

        public SqlConnection openConnection()
        {
            SqlConnection conn = new SqlConnection(getConnection());
            conn.Open();
            return conn;
        }

        public void closeConnection(SqlConnection conn)
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
        }

        public void executeSql(string sql)
        {
            SqlConnection conn = openConnection();

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.ExecuteNonQuery();

            closeConnection(conn);
        }


        public DataTable getResultData(string sql)
        {
            SqlConnection conn = openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            closeConnection(conn);
            return dt; 
        }
    }
}