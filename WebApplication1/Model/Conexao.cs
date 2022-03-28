using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.Model
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = "SERVER=backendaap.ddns.net; DATABASE=aapv; UID=geral; PWD=aapv; PORT=3306";

        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection desconectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            return con;
        }
    }
}