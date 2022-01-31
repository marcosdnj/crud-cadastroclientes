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

        public string nomeUsuario = "";
        public string usuario = "";

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
            nomeUsuario = $"SELECT Nome FROM LoginFuncionario WHERE Usuario = '{textLogin.Text}' and Senha = '{textSenha.Text}'";
            SqlDataAdapter dp = new SqlDataAdapter(nomeUsuario, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);



         


           

        }

    }
}
