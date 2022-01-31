using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_Clientes
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection();


        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-ABFE7AQ\SQLEXPRESS;Initial Catalog=crudClientes;Integrated Security=True";
        }


        //Método Conectar
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();

            return con;


        }

        //Metodo Desconectar
        public void Desconectar()
        {
            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
        }
    }
}
