using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class DataAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;


        public string SaveFile, Sql;

        public DataAccessLayer()
        {
            SaveFile = Sql = "";
            con = new SqlConnection(Properties.Settings.Default.conn);
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            cmd.Connection = con;
            da.SelectCommand = cmd;
        }
        public void connect()
        {

            con.Open();

        }
        public void Disconnect()
        {
            con.Close();
        }
        public DataTable select(string sql)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = sql;
            try
            {
                da.Fill(dt);
            }
            catch
            {
            }
            return dt;
        }
        public int docommand(string sql)
        {
            cmd.CommandText = sql;
            int num = cmd.ExecuteNonQuery();
            return num;
        }
    }
}
