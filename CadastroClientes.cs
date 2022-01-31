using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Clientes
{
    internal class CadastroClientes
    {
        public class Cadastro
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();

            public string mensagem = "";


            public Cadastro(string nome, string cpf, string email, string telefone, string rua, string complemento, string cidade, string cep)
            {
                
                //Comandos SQL
                cmd.CommandText = "INSERT INTO clientesCadastrados(Nome, CPF, email, Telefone, Rua, Complemento, Cidade, CEP) VALUES (@nome, @cpf, @email, @telefone, @rua, @complemento, @cidade, @cep)";
                


                //Parametros
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@complemento", complemento);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@cep", cep);




                cmd.Connection = con.Conectar();
                //Executar Comando
                cmd.ExecuteNonQuery();
                //Desconectar
                con.Desconectar();
                //Mostrar mensagem de erro ou sucesso
                this.mensagem = "Pedido cadastrado com sucesso no banco de dados";

            }
            
        }

    }
}