using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botao excluir
            Fornecedor obj = new Fornecedor();


            obj.codigo = int.Parse(txtcodigo.Text);


            //Cria objeto da classe fornecedor

            FornecedorDAO dao = new FornecedorDAO();
            dao.excluirFornecedor(obj);

            //Carregar o daragridview fornecor
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            new Helpers().LimparTela(this);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomp.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }

    

    private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //botao Salvar
            Fornecedor obj = new Fornecedor();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            //Cria objeto da classe fornecedor

            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastrarFornecedor(obj);

            //Carregar o daragridview fornecor
            tabelaFornecedores.DataSource = dao.listarFornecedores();
            new Helpers().LimparTela(this);

        }



        private void Frmfornecedores_Load(object sender, EventArgs e)
        {
            //Listar todos os fornecedores
            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.listarFornecedores();
        }

        private void tabelaFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = tabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = tabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = tabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = tabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = tabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = tabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = tabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomp.Text = tabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = tabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = tabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = tabelaFornecedores.CurrentRow.Cells[12].Value.ToString();

            //Alterar para guia  Dados Pessoais
            tabFornecedor.SelectedTab = tabPage1;

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //botao alterar
            Fornecedor obj = new Fornecedor();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomp.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            obj.codigo = int.Parse(txtcodigo.Text);


            //Cria objeto da classe fornecedor

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterarFornecedor(obj);

            //Carregar o daragridview fornecor
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            new Helpers().LimparTela(this);

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedores.DataSource = dao.buscarFornecedorPorNome(nome);

            if (tabelaFornecedores.Rows.Count == 0)

            {
                MessageBox.Show("Nenhum Fornecedor encontrado com esse nome");
                //recarregar o datagridview
                tabelaFornecedores.DataSource = dao.listarFornecedores();
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.listarFornecedorPorNome(nome);
        }
    }
    }

