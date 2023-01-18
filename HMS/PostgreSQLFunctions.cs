using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace HMS
{
    internal class PostgreSQLFunctions
    {
        protected NpgsqlConnection getConnection()
        {
            string conStr = "Server=127.0.0.1;User Id=postgres;Password=2009anshulab;Database=HMSDB";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            return conn;
        }

        public DataSet getDataset(string query)
        {
            DataSet ds = new DataSet();
            NpgsqlConnection con = getConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public void setData(string query,string message)
        {
            NpgsqlConnection con = getConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'"+message+"'","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public NpgsqlDataReader getReaderData(string query)
        {
            NpgsqlConnection con = getConnection();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new NpgsqlCommand(query, con);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
