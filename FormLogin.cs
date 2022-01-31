using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Clientes
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABFE7AQ\SQLEXPRESS;Initial Catalog=crudClientes;Integrated Security=True");




        public FormLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {



            con.Open();
            string query = $"SELECT * FROM LoginFuncionario WHERE Usuario = '{textLogin.Text}' and Senha = '{textSenha.Text}'";
            Console.WriteLine(query);
            SqlDataAdapter dp = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);


            try 
            { 
                if(dt.Rows.Count == 1)
                {
                    
                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();
                    this.Hide();
                    con.Close();
                }
            }
            catch(Exception erroLogin)
            {
                MessageBox.Show("Usuario ou senha incorretos", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            textLogin.Clear();
            textSenha.Clear();
            textLogin.Focus();
            con.Close();

             
            
        }
    }
}
