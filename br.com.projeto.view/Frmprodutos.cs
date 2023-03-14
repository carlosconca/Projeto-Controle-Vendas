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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void Frmproduto_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbfornecedor.DataSource = f_dao.listarFornecedores();
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProdutos.DataSource = dao.listarProdutos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor do combobox:" + cbfornecedor.SelectedValue);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdesc.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            //Criar o objeto dao

            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastraProduto(obj);

            new Helpers().LimparTela(this);

            //recarregar o datavideview com dados do produto


        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);

        }

        private void tabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegando os dados de um produto selecionado
            txtcodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtqtd.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();

            cbfornecedor.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

           // tabelaProdutos.SelectedTab = tabPage1;

        }
    

        private void btneditar_Click(object sender, EventArgs e)
        {

        }
    }
}
