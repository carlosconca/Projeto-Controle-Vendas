
namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmfornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFornecedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaFornecedores = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabFornecedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 74);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.tabPage1);
            this.tabFornecedor.Controls.Add(this.tabPage2);
            this.tabFornecedor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFornecedor.Location = new System.Drawing.Point(12, 80);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.SelectedIndex = 0;
            this.tabFornecedor.Size = new System.Drawing.Size(1008, 385);
            this.tabFornecedor.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.cbuf);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtcomp);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtcnpj);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnbuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(591, 229);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(82, 29);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.Text = "Pesquisar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(662, 182);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(68, 31);
            this.cbuf.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(621, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "UF:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(411, 274);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(138, 29);
            this.txtcidade.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(331, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cidade";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(132, 277);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(165, 29);
            this.txtbairro.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(75, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bairro";
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(132, 232);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(273, 29);
            this.txtcomp.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Complemento";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(451, 185);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(128, 29);
            this.txtnumero.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(385, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Número";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(108, 182);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(273, 29);
            this.txtendereco.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(484, 229);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(95, 29);
            this.txtcep.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "CEP";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(679, 133);
            this.txtcelular.Mask = "(999) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(139, 29);
            this.txtcelular.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(607, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular";
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(484, 133);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(121, 29);
            this.txttelefone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefone";
            // 
            // txtcnpj
            // 
            this.txtcnpj.Location = new System.Drawing.Point(468, 86);
            this.txtcnpj.Mask = "##.###.###/####-##";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(161, 29);
            this.txtcnpj.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "CNPJ";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(108, 133);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(273, 29);
            this.txtemail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(108, 86);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(273, 29);
            this.txtnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(108, 42);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(128, 29);
            this.txtcodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelaFornecedores);
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.txtpesquisa);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaFornecedores
            // 
            this.tabelaFornecedores.AllowUserToAddRows = false;
            this.tabelaFornecedores.AllowUserToDeleteRows = false;
            this.tabelaFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFornecedores.Location = new System.Drawing.Point(-7, 70);
            this.tabelaFornecedores.Name = "tabelaFornecedores";
            this.tabelaFornecedores.ReadOnly = true;
            this.tabelaFornecedores.Size = new System.Drawing.Size(972, 265);
            this.tabelaFornecedores.TabIndex = 7;
            this.tabelaFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaFornecedores_CellClick);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnpesquisar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(398, 27);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 29);
            this.btnpesquisar.TabIndex = 6;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(105, 28);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(273, 26);
            this.txtpesquisa.TabIndex = 5;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btneditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(499, 485);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 29);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnexcluir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(382, 485);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 29);
            this.btnexcluir.TabIndex = 12;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnsalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(260, 485);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 29);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnnovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(150, 485);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 29);
            this.btnnovo.TabIndex = 10;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // Frmfornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 543);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabFornecedor);
            this.Controls.Add(this.panel1);
            this.Name = "Frmfornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.Frmfornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFornecedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabFornecedor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tabelaFornecedores;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
    }
}