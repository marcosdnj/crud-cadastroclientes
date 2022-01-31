namespace CRUD_Clientes
{
    partial class Form1
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
            this.tabPesquisarCliente = new System.Windows.Forms.TabPage();
            this.tabDeletarCliente = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textRua = new System.Windows.Forms.TextBox();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textCep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabCRUD.SuspendLayout();
            this.tabCadastrarClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCRUD
            // 
            this.tabCRUD.Controls.Add(this.tabCadastrarClientes);
            this.tabCRUD.Controls.Add(this.tabPesquisarCliente);
            this.tabCRUD.Controls.Add(this.tabDeletarCliente);
            this.tabCRUD.Location = new System.Drawing.Point(2, 1);
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
            // 
            // tabPesquisarCliente
            // 
            this.tabPesquisarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisarCliente.Name = "tabPesquisarCliente";
            this.tabPesquisarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisarCliente.Size = new System.Drawing.Size(682, 350);
            this.tabPesquisarCliente.TabIndex = 1;
            this.tabPesquisarCliente.Text = "Pesquisar Cliente";
            this.tabPesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // tabDeletarCliente
            // 
            this.tabDeletarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabDeletarCliente.Name = "tabDeletarCliente";
            this.tabDeletarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeletarCliente.Size = new System.Drawing.Size(682, 350);
            this.tabDeletarCliente.TabIndex = 2;
            this.tabDeletarCliente.Text = "Deletar Cliente";
            this.tabDeletarCliente.UseVisualStyleBackColor = true;
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
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(251, 84);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(223, 20);
            this.textNome.TabIndex = 8;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(564, 86);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(110, 20);
            this.textTelefone.TabIndex = 9;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(251, 118);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(132, 20);
            this.textCPF.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(445, 118);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(229, 20);
            this.textEmail.TabIndex = 11;
            // 
            // textRua
            // 
            this.textRua.Location = new System.Drawing.Point(251, 157);
            this.textRua.Name = "textRua";
            this.textRua.Size = new System.Drawing.Size(223, 20);
            this.textRua.TabIndex = 12;
            // 
            // textComplemento
            // 
            this.textComplemento.Location = new System.Drawing.Point(600, 157);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(74, 20);
            this.textComplemento.TabIndex = 13;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(251, 198);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(188, 20);
            this.textCidade.TabIndex = 14;
            // 
            // textCep
            // 
            this.textCep.Location = new System.Drawing.Point(520, 201);
            this.textCep.Name = "textCep";
            this.textCep.Size = new System.Drawing.Size(154, 20);
            this.textCep.TabIndex = 15;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 374);
            this.Controls.Add(this.tabCRUD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCRUD.ResumeLayout(false);
            this.tabCadastrarClientes.ResumeLayout(false);
            this.tabCadastrarClientes.PerformLayout();
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
    }
}

