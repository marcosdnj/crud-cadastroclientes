using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD_Clientes.CadastroClientes;
using static CRUD_Clientes.FormLogin;

namespace CRUD_Clientes
{
    public partial class FormPrincipal : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABFE7AQ\SQLEXPRESS;Initial Catalog=crudClientes;Integrated Security=True");

        string clientesCadastrados = "";
        string clientesDelete = "";
        string pesquisaClientes = "";
        string refreshClientes = "";
        string deleteClientes = "";
        string atualizarDelete = "";
        string editarClientes = "";
        string selecionarClientes = "";



        private void label11_Load(object sender, EventArgs e)
        {
            
        }


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            con.Open();
            
                Cadastro clientes = new Cadastro(textNome.Text, textCPF.Text, textEmail.Text, textTelefone.Text, textRua.Text, textComplemento.Text, textCidade.Text, textCep.Text);

                MessageBox.Show(clientes.mensagem);
                textNome.Clear();
                textCPF.Clear();
                textEmail.Clear();
                textTelefone.Clear();
                textRua.Clear();
                textComplemento.Clear();
                textCidade.Clear();
                textCep.Clear();

                textNome.Focus();
            con.Close();

        }

        private void tabCadastrarClientes_Click(object sender, EventArgs e)
        {

          

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            con.Open();

            //GRID DE PESQUISA
            clientesCadastrados = $"SELECT TOP (200) ID,Nome,CPF,email,Telefone,Rua,Complemento,Cidade,CEP FROM clientesCadastrados";
            SqlDataAdapter dp = new SqlDataAdapter(clientesCadastrados, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            dataGridClientes.DataSource = dt;

            //GRID DE EXCLUSÃO

            clientesDelete = $"SELECT TOP (200) ID,Nome,CPF,email,Telefone,Rua,Complemento,Cidade,CEP FROM clientesCadastrados";
            SqlDataAdapter dpDelete = new SqlDataAdapter(clientesDelete, con);
            DataTable dtDelete = new DataTable();
            dpDelete.Fill(dtDelete);

            dataGridDelete.DataSource = dtDelete;


            con.Close();
        }

        private void tabPesquisarCliente_Click(object sender, EventArgs e)
        {

        }

        private void tabPesquisarCliente_Load(object sender, EventArgs e)
        {

    


        }
        //SELECT TOP (200) ID,Nome,CPF,email,Telefone,Rua,Complemento,Cidade,CEP FROM clientesCadastrados

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            con.Open();
            pesquisaClientes = $"SELECT ID,Nome,CPF,email,Telefone,Rua,Complemento,Cidade,CEP FROM clientesCadastrados WHERE CPF = '{textCpfPesquisa.Text}'";
            SqlDataAdapter dp = new SqlDataAdapter(pesquisaClientes, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            dataGridClientes.DataSource = dt;
            con.Close();
        }

        private void textCpfPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            refreshClientes = $"SELECT TOP (200) ID,Nome,CPF,email,Telefone,Rua,Complemento,Cidade,CEP FROM clientesCadastrados";
            SqlDataAdapter dp = new SqlDataAdapter(refreshClientes, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            con.Close();
            dataGridClientes.DataSource = dt;
            
        }

        private void tabDeletarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            atualizarDelete = $"SELECT TOP (200) ID,Nome,CPF,email,Telefone,Rua,Complemento,Cidade,CEP FROM clientesCadastrados";
            SqlDataAdapter dp = new SqlDataAdapter(atualizarDelete, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            dataGridDelete.DataSource = dt;
            con.Close();
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            var res = MessageBox.Show("O Cliente será excluido\nTem certeza que deseja concluir esta ação?", "ATENÇÃO", MessageBoxButtons.YesNo);
             
            if(res == DialogResult.Yes)
            {
                deleteClientes = $"DELETE FROM clientesCadastrados WHERE CPF = '{textDeleteClientes.Text}'";

                SqlDataAdapter dp = new SqlDataAdapter(deleteClientes, con);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                dataGridClientes.DataSource = dt;
                
            }
           
            con.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void btnConsultaEditarCliente_Click(object sender, EventArgs e)
        {
         
            con.Open();

            selecionarClientes = $"SELECT ID,Nome,CPF,email,Telefone,Rua,Complemento,Cidade,CEP FROM clientesCadastrados WHERE CPF = '{textEditarCliente.Text}'";
            SqlDataAdapter dp = new SqlDataAdapter(selecionarClientes, con);
          //  DataTable dt = new DataTable()
            DataSet ds = new DataSet();
            dp.Fill(ds);
            

            cbEditarNome.DataSource = ds.Tables[0];
            cbEditarNome.DisplayMember = "Nome";
            cbEditarNome.ValueMember =  "Id"; 


            cbEditarCPF.DataSource = ds.Tables[0];
            cbEditarCPF.DisplayMember = "CPF";
            cbEditarCPF.ValueMember = "Id";



            con.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();



            editarClientes = $@"UPDATE dbo.clientesCadastrados 
                               SET email = '{txtEditarEmail.Text}',
                               Telefone =  '{txtEditarTelefone.Text}',
                               Rua = '{txtEditarRua.Text}',
                               Complemento = '{txtEditarComplemento.Text}',
                               Cidade = '{txtEditarCidade.Text}',
                               CEP = '{txtEditarCEP.Text}'
                            WHERE CPF = '{cbEditarCPF.Text}'";

            SqlDataAdapter dp = new SqlDataAdapter(editarClientes, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);

                     
            
            con.Close();


            textEditarCliente.Clear();
        }
    }
}
