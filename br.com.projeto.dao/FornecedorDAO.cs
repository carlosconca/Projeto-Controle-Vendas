using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class FornecedorDAO
    {
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }

        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                //definir o comando cmd - insert into
                string sql = @"insert into tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                               values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
              
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.celular);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecdor cadastrado com sucesso");
                //fechar a conexao com o BD
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);

            }

        }

        public DataTable listarFornecedores()
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelafornecedor;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }

        public DataTable listarFornecedorPorNome(string nome)
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelafornecedor;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }

        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
              
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelafornecedor;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }


        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                //definir o comando cmd - insert into
                string sql = @"update tb_fornecedores set nome=@nome, cnpj=@cnpj, email=@email, 
                              telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, 
                             numero=@numero, complemento=@comp, bairro=@bairro, cidade=@cidade, estado=@estado where id = @id";
                                                                                                                

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);

                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.celular);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@comp", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);


                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dado Alterado com sucesso com sucesso");
                //fechar a conexao com o BD
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);

            }

        }


        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                //definir o comando cmd - insert into
                string sql = @"delete from tb_fornecedores where id = @id";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);


                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluido com sucesso");

                //fechar a conexao com o BD
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);

            }

        }

    }
}
