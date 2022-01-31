namespace CRUD_Clientes
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCRUD = new System.Windows.Forms.TabControl();
            this.tabCadastrarClientes = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textCep = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.textRua = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPesquisarCliente = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textCpfPesquisa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.tabDeletarCliente = new System.Windows.Forms.TabPage();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dataGridDelete = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textDeleteClientes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEditarCEP = new System.Windows.Forms.TextBox();
            this.txtEditarCidade = new System.Windows.Forms.TextBox();
            this.txtEditarComplemento = new System.Windows.Forms.TextBox();
            this.txtEditarRua = new System.Windows.Forms.TextBox();
            this.txtEditarEmail = new System.Windows.Forms.TextBox();
            this.txtEditarTelefone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnConsultaEditarCliente = new System.Windows.Forms.Button();
            this.textEditarCliente = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbEditarNome = new System.Windows.Forms.ComboBox();
            this.cbEditarCPF = new System.Windows.Forms.ComboBox();
            this.tabCRUD.SuspendLayout();
            this.tabCadastrarClientes.SuspendLayout();
            this.tabPesquisarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.tabDeletarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCRUD
            // 
            this.tabCRUD.Controls.Add(this.tabCadastrarClientes);
            this.tabCRUD.Controls.Add(this.tabPesquisarCliente);
            this.tabCRUD.Controls.Add(this.tabDeletarCliente);
            this.tabCRUD.Controls.Add(this.tabPage1);
            this.tabCRUD.Location = new System.Drawing.Point(3, 1);
            this.tabCRUD.Name = "tabCRUD";
            this.tabCRUD.SelectedIndex = 0;
            this.tabCRUD.Size = new System.Drawing.Size(690, 376);
            this.tabCRUD.TabIndex = 0;
            // 
            // tabCadastrarClientes
            // 
            this.tabCadastrarClientes.Controls.Add(this.label11);
            this.tabCadastrarClientes.Controls.Add(this.label10);
            this.tabCadastrarClientes.Controls.Add(this.btnCadastrar);
            this.tabCadastrarClientes.Controls.Add(this.label9);
            this.tabCadastrarClientes.Controls.Add(this.textCep);
            this.tabCadastrarClientes.Controls.Add(this.textCidade);
            this.tabCadastrarClientes.Controls.Add(this.textComplemento);
            this.tabCadastrarClientes.Controls.Add(this.textRua);
            this.tabCadastrarClientes.Controls.Add(this.textEmail);
            this.tabCadastrarClientes.Controls.Add(this.textCPF);
            this.tabCadastrarClientes.Controls.Add(this.textTelefone);
            this.tabCadastrarClientes.Controls.Add(this.textNome);
            this.tabCadastrarClientes.Controls.Add(this.label8);
            this.tabCadastrarClientes.Controls.Add(this.label7);
            this.tabCadastrarClientes.Controls.Add(this.label6);
            this.tabCadastrarClientes.Controls.Add(this.label5);
            this.tabCadastrarClientes.Controls.Add(this.label4);
            this.tabCadastrarClientes.Controls.Add(this.label3);
            this.tabCadastrarClientes.Controls.Add(this.label2);
            this.tabCadastrarClientes.Controls.Add(this.label1);
            this.tabCadastrarClientes.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarClientes.Name = "tabCadastrarClientes";
            this.tabCadastrarClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarClientes.Size = new System.Drawing.Size(682, 350);
            this.tabCadastrarClientes.TabIndex = 0;
            this.tabCadastrarClientes.Text = "Cadastrar Clientes";
            this.tabCadastrarClientes.UseVisualStyleBackColor = true;
            this.tabCadastrarClientes.Click += new System.EventHandler(this.tabCadastrarClientes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "DEFAULT";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Logado como:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(251, 254);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(423, 31);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Inserir cliente ao Banco de Dados";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(372, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "CADASTRO DE CLIENTES";
            // 
            // textCep
            // 
            this.textCep.Location = new System.Drawing.Point(520, 201);
            this.textCep.Name = "textCep";
            this.textCep.Size = new System.Drawing.Size(154, 20);
            this.textCep.TabIndex = 15;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(251, 198);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(188, 20);
            this.textCidade.TabIndex = 14;
            // 
            // textComplemento
            // 
            this.textComplemento.Location = new System.Drawing.Point(600, 157);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(74, 20);
            this.textComplemento.TabIndex = 13;
            // 
            // textRua
            // 
            this.textRua.Location = new System.Drawing.Point(251, 157);
            this.textRua.Name = "textRua";
            this.textRua.Size = new System.Drawing.Size(223, 20);
            this.textRua.TabIndex = 12;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(445, 118);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(229, 20);
            this.textEmail.TabIndex = 11;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(251, 118);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(132, 20);
            this.textCPF.TabIndex = 10;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(564, 86);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(110, 20);
            this.textTelefone.TabIndex = 9;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(251, 84);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(223, 20);
            this.textNome.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(462, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Complemento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabPesquisarCliente
            // 
            this.tabPesquisarCliente.Controls.Add(this.btnRefresh);
            this.tabPesquisarCliente.Controls.Add(this.btnPesquisar);
            this.tabPesquisarCliente.Controls.Add(this.textCpfPesquisa);
            this.tabPesquisarCliente.Controls.Add(this.label13);
            this.tabPesquisarCliente.Controls.Add(this.label12);
            this.tabPesquisarCliente.Controls.Add(this.dataGridClientes);
            this.tabPesquisarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisarCliente.Name = "tabPesquisarCliente";
            this.tabPesquisarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisarCliente.Size = new System.Drawing.Size(682, 350);
            this.tabPesquisarCliente.TabIndex = 1;
            this.tabPesquisarCliente.Text = "Pesquisar Cliente";
            this.tabPesquisarCliente.UseVisualStyleBackColor = true;
            this.tabPesquisarCliente.Click += new System.EventHandler(this.tabPesquisarCliente_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(623, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(397, 59);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 34);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textCpfPesquisa
            // 
            this.textCpfPesquisa.Location = new System.Drawing.Point(207, 68);
            this.textCpfPesquisa.Name = "textCpfPesquisa";
            this.textCpfPesquisa.Size = new System.Drawing.Size(175, 20);
            this.textCpfPesquisa.TabIndex = 3;
            this.textCpfPesquisa.TextChanged += new System.EventHandler(this.textCpfPesquisa_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(163, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "CPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(165, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(332, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "PESQUISAR CLIENTES";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(6, 106);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Size = new System.Drawing.Size(673, 238);
            this.dataGridClientes.TabIndex = 0;
            this.dataGridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellContentClick);
            // 
            // tabDeletarCliente
            // 
            this.tabDeletarCliente.Controls.Add(this.btnAtualizar);
            this.tabDeletarCliente.Controls.Add(this.dataGridDelete);
            this.tabDeletarCliente.Controls.Add(this.button1);
            this.tabDeletarCliente.Controls.Add(this.textDeleteClientes);
            this.tabDeletarCliente.Controls.Add(this.label15);
            this.tabDeletarCliente.Controls.Add(this.label14);
            this.tabDeletarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabDeletarCliente.Name = "tabDeletarCliente";
            this.tabDeletarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeletarCliente.Size = new System.Drawing.Size(682, 350);
            this.tabDeletarCliente.TabIndex = 2;
            this.tabDeletarCliente.Text = "Deletar Cliente";
            this.tabDeletarCliente.UseVisualStyleBackColor = true;
            this.tabDeletarCliente.Click += new System.EventHandler(this.tabDeletarCliente_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(623, 77);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(52, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dataGridDelete
            // 
            this.dataGridDelete.AllowUserToAddRows = false;
            this.dataGridDelete.AllowUserToDeleteRows = false;
            this.dataGridDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDelete.Location = new System.Drawing.Point(6, 106);
            this.dataGridDelete.Name = "dataGridDelete";
            this.dataGridDelete.ReadOnly = true;
            this.dataGridDelete.Size = new System.Drawing.Size(673, 238);
            this.dataGridDelete.TabIndex = 6;
            this.dataGridDelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDelete_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "DELETAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDeleteClientes
            // 
            this.textDeleteClientes.Location = new System.Drawing.Point(207, 68);
            this.textDeleteClientes.Name = "textDeleteClientes";
            this.textDeleteClientes.Size = new System.Drawing.Size(175, 20);
            this.textDeleteClientes.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(163, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "CPF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(182, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 31);
            this.label14.TabIndex = 2;
            this.label14.Text = "DELETAR CLIENTES";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbEditarCPF);
            this.tabPage1.Controls.Add(this.cbEditarNome);
            this.tabPage1.Controls.Add(this.btnConsultaEditarCliente);
            this.tabPage1.Controls.Add(this.textEditarCliente);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtEditarCEP);
            this.tabPage1.Controls.Add(this.txtEditarCidade);
            this.tabPage1.Controls.Add(this.txtEditarComplemento);
            this.tabPage1.Controls.Add(this.txtEditarRua);
            this.tabPage1.Controls.Add(this.txtEditarEmail);
            this.tabPage1.Controls.Add(this.txtEditarTelefone);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 350);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Atualizar Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(251, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(423, 31);
            this.button2.TabIndex = 34;
            this.button2.Text = "EDITAR DADOS DO CLIENTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEditarCEP
            // 
            this.txtEditarCEP.Location = new System.Drawing.Point(520, 252);
            this.txtEditarCEP.Name = "txtEditarCEP";
            this.txtEditarCEP.Size = new System.Drawing.Size(154, 20);
            this.txtEditarCEP.TabIndex = 33;
            // 
            // txtEditarCidade
            // 
            this.txtEditarCidade.Location = new System.Drawing.Point(251, 249);
            this.txtEditarCidade.Name = "txtEditarCidade";
            this.txtEditarCidade.Size = new System.Drawing.Size(188, 20);
            this.txtEditarCidade.TabIndex = 32;
            // 
            // txtEditarComplemento
            // 
            this.txtEditarComplemento.Location = new System.Drawing.Point(600, 208);
            this.txtEditarComplemento.Name = "txtEditarComplemento";
            this.txtEditarComplemento.Size = new System.Drawing.Size(74, 20);
            this.txtEditarComplemento.TabIndex = 31;
            // 
            // txtEditarRua
            // 
            this.txtEditarRua.Location = new System.Drawing.Point(251, 208);
            this.txtEditarRua.Name = "txtEditarRua";
            this.txtEditarRua.Size = new System.Drawing.Size(223, 20);
            this.txtEditarRua.TabIndex = 30;
            // 
            // txtEditarEmail
            // 
            this.txtEditarEmail.Location = new System.Drawing.Point(445, 169);
            this.txtEditarEmail.Name = "txtEditarEmail";
            this.txtEditarEmail.Size = new System.Drawing.Size(229, 20);
            this.txtEditarEmail.TabIndex = 29;
            // 
            // txtEditarTelefone
            // 
            this.txtEditarTelefone.Location = new System.Drawing.Point(564, 137);
            this.txtEditarTelefone.Name = "txtEditarTelefone";
            this.txtEditarTelefone.Size = new System.Drawing.Size(110, 20);
            this.txtEditarTelefone.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(462, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 18);
            this.label16.TabIndex = 25;
            this.label16.Text = "CEP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(183, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 18);
            this.label17.TabIndex = 24;
            this.label17.Text = "Cidade";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(492, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 18);
            this.label18.TabIndex = 23;
            this.label18.Text = "Complemento";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(202, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 18);
            this.label19.TabIndex = 22;
            this.label19.Text = "Rua";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(492, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 18);
            this.label20.TabIndex = 21;
            this.label20.Text = "Telefone";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(389, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 18);
            this.label21.TabIndex = 20;
            this.label21.Text = "E-mail";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(199, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 18);
            this.label22.TabIndex = 19;
            this.label22.Text = "CPF";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(188, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 18);
            this.label23.TabIndex = 18;
            this.label23.Text = "Nome";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(128, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(429, 31);
            this.label24.TabIndex = 35;
            this.label24.Text = "EDITAR DADOS DE CLIENTES";
            // 
            // btnConsultaEditarCliente
            // 
            this.btnConsultaEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaEditarCliente.Location = new System.Drawing.Point(410, 70);
            this.btnConsultaEditarCliente.Name = "btnConsultaEditarCliente";
            this.btnConsultaEditarCliente.Size = new System.Drawing.Size(114, 34);
            this.btnConsultaEditarCliente.TabIndex = 38;
            this.btnConsultaEditarCliente.Text = "PESQUISAR";
            this.btnConsultaEditarCliente.UseVisualStyleBackColor = true;
            this.btnConsultaEditarCliente.Click += new System.EventHandler(this.btnConsultaEditarCliente_Click);
            // 
            // textEditarCliente
            // 
            this.textEditarCliente.Location = new System.Drawing.Point(220, 79);
            this.textEditarCliente.Name = "textEditarCliente";
            this.textEditarCliente.Size = new System.Drawing.Size(175, 20);
            this.textEditarCliente.TabIndex = 37;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(176, 79);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 18);
            this.label25.TabIndex = 36;
            this.label25.Text = "CPF";
            // 
            // cbEditarNome
            // 
            this.cbEditarNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditarNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEditarNome.FormattingEnabled = true;
            this.cbEditarNome.Location = new System.Drawing.Point(251, 136);
            this.cbEditarNome.Name = "cbEditarNome";
            this.cbEditarNome.Size = new System.Drawing.Size(223, 21);
            this.cbEditarNome.TabIndex = 39;
            // 
            // cbEditarCPF
            // 
            this.cbEditarCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEditarCPF.FormattingEnabled = true;
            this.cbEditarCPF.Location = new System.Drawing.Point(251, 170);
            this.cbEditarCPF.Name = "cbEditarCPF";
            this.cbEditarCPF.Size = new System.Drawing.Size(132, 21);
            this.cbEditarCPF.TabIndex = 40;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 374);
            this.Controls.Add(this.tabCRUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabCRUD.ResumeLayout(false);
            this.tabCadastrarClientes.ResumeLayout(false);
            this.tabCadastrarClientes.PerformLayout();
            this.tabPesquisarCliente.ResumeLayout(false);
            this.tabPesquisarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.tabDeletarCliente.ResumeLayout(false);
            this.tabDeletarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCRUD;
        private System.Windows.Forms.TabPage tabCadastrarClientes;
        private System.Windows.Forms.TabPage tabPesquisarCliente;
        private System.Windows.Forms.TabPage tabDeletarCliente;
        private System.Windows.Forms.TextBox textComplemento;
        private System.Windows.Forms.TextBox textRua;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textCep;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textCpfPesquisa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textDeleteClientes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dataGridDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConsultaEditarCliente;
        private System.Windows.Forms.TextBox textEditarCliente;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEditarCEP;
        private System.Windows.Forms.TextBox txtEditarCidade;
        private System.Windows.Forms.TextBox txtEditarComplemento;
        private System.Windows.Forms.TextBox txtEditarRua;
        private System.Windows.Forms.TextBox txtEditarEmail;
        private System.Windows.Forms.TextBox txtEditarTelefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbEditarCPF;
        public System.Windows.Forms.ComboBox cbEditarNome;
    }
}

