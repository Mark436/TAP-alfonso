using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    class SqlConnector
    {
        public DataTable consultar(string cadenaSQL)

        {
            String cadenaConex = "Data Source=Rickosa;Initial Catalog=LAEMPRESA;Integrated Security=True;";
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            da.SelectCommand = comando;
            conectar.Open();
            da.Fill(dt);
            conectar.Close();
            conectar.Dispose();
            comando.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }
        public int ejecutarNonQuery(string cadenaSQL)
        {
            String cadenaConex = "Data Source=Rickosa;Initial Catalog=LAEMPRESA;Integrated Security=True;";
            SqlConnection conectar = new SqlConnection(cadenaConex);
            SqlCommand comando = new SqlCommand(cadenaSQL, conectar);
            int filasAfectadas = 0;

            try
            {
                conectar.Open();
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(cadenaSQL + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conectar.Close();
                comando.Dispose();
                conectar.Dispose();
            }

            return filasAfectadas;
        }
    }
}

        
