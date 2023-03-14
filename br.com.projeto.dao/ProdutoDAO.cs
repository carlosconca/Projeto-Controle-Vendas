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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }

        public void cadastraProduto(Produto obj)

        {
            try
            {
                //criar sql
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id ) 
                           values (@descricao, @preco, @qtd, @for_id)";

                // organizar e executar o comando sql
                MySqlCommand executedcmd = new MySqlCommand(sql, conexao);
                executedcmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executedcmd.Parameters.AddWithValue("@preco", obj.preco);
                executedcmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executedcmd.Parameters.AddWithValue("@for_id", obj.for_id);

                //abria a conexao e executar o comando
                conexao.Open();
                executedcmd.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastrado com sucesso.");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro:" + erro);
            }

        }


        public DataTable listarProdutos()
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select p.id as 'Código',
                               p.descricao as 'Descrição',
                               p.preco as 'Preço',
                               p.qtd_estoque as 'Qtd Estoque',
                               f.nome as 'Fornecedor' from tb_produtos as p
                               join tb_fornecedores as f on (p.for_id = f.id);";
                               

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelaProduto;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }

        public void alterarProduto(Produto obj)

        {
            try
            {
                //criar sql
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd, for_id=@for_id where id =@id"; 
                           

                // organizar e executar o comando sql
                MySqlCommand executedcmd = new MySqlCommand(sql, conexao);
                executedcmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executedcmd.Parameters.AddWithValue("@preco", obj.preco);
                executedcmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executedcmd.Parameters.AddWithValue("@for_id", obj.for_id);

                executedcmd.Parameters.AddWithValue("@id", obj.id);


                //abria a conexao e executar o comando
                conexao.Open();
                executedcmd.ExecuteNonQuery();

                MessageBox.Show("Produto Alterado com sucesso.");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro:" + erro);
            }

        }

        public void excluirProduto(Produto obj)

        {
            try
            {
                //criar sql
                string sql = @"delete from tb_produtos where id =@id";


                // organizar e executar o comando sql
                MySqlCommand executedcmd = new MySqlCommand(sql, conexao);
               
                executedcmd.Parameters.AddWithValue("@id", obj.id);


                //abria a conexao e executar o comando
                conexao.Open();
                executedcmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso.");
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro:" + erro);
            }

        }

    }

}



