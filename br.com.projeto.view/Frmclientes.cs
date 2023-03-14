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
    public partial class Frmclientes : Form
    {
        private object obj;

        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //receber dados dentro de um objeto cliente
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.cep = txtcep.Text;
            obj.complemento = txtcomp.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            //criar um objeto da classe ClienteDAO e chamar o metodo cadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //recarregar datagridview

            tabelaCliente.DataSource = dao.listarClientes();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.listarClientes();
   

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            if(tabelaCliente.Rows.Count == 0)
            {
                //recarregar o datagridview
                tabelaCliente.DataSource = dao.listarClientes();
            }

        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada
            txtcodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtcomp.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            //Alterar para guia de dados Pessoais
            tabClientes.SelectedTab = tabPage1;

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão excluir
            Cliente obj = new Cliente();


            //pegar o codigo
            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.excluirCliente(obj);
            
            //recarrega o datagridview
            tabelaCliente.DataSource = dao.listarClientes();


        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //receber dados dentro de um objeto cliente
            Cliente obj = new Cliente();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.endereco = txtendereco.Text;
            obj.cep = txtcep.Text;
            obj.complemento = txtcomp.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            obj.codigo = int.Parse(txtcodigo.Text);

            //criar um objeto da classe ClienteDAO e chamar o metodo alterar
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            //recarregar datagridview

            tabelaCliente.DataSource = dao.listarClientes();

        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.ListarClientePorNome(nome);

          
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //botao consultar Cep
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

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.") ;
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
