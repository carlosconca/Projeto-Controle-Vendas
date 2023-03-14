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
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {

                //criar o comando sql
                string sql = "insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)" +
                             "values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);


                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso");
                //fechar a conexao com o BD
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        public void alterarFncionario(Funcionario obj)

        {
            try
            {
                string sql = "update tb_funcionarios set nome=@nome , rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado where id = @codigo";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);



                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com sucesso");
                //fechar a conexao com o BD
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        public void deletarFncionario(Funcionario obj)

        {
            try
            {
                string sql = "delete from tb_funcionarios where id = @codigo";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
               

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);



                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com sucesso");
                //fechar a conexao com o BD
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }




        public DataTable listarFuncionarios()
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelafuncionario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }

        public DataTable BusacaFuncionariosPorNome(string nome)
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelafuncionario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }

        public DataTable listarFuncionariosPorNome(string nome)
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelafuncionario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;


            } 
    }

    }
}




