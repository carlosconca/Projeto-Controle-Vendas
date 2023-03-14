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
    public class ClienteDAO
    {


        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

        }

        //Cadastrar Cliente

        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                //definir o comando cmd - insert into
                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                               values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente cadastrado com sucesso");
                //fechar a conexao com o BD
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);

            }

        }

        public DataTable listarClientes()
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro );
                return null;

            }
        }


        //Alterar Cliente

        public void alterarCliente(Cliente obj)
        {
            try
            {
                //definir o comando cmd - insert into
                string sql = @"update tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                              where id=@id";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
                executacmd.Parameters.AddWithValue("@id", obj.codigo);


                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliete alterado com sucesso");
                //fechar a conexao com o BD
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);

            }

        }




        //Excluir Cliente

        public void excluirCliente(Cliente obj)
        {
            try
            {
                //definir o comando cmd - insert into
                string sql = @"delete from tb_clientes where id = @id";

                //organizar cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
             
                executacmd.Parameters.AddWithValue("@id", obj.codigo);


                //abrir a conexão e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso");

                //fechar a conexao com o BD
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);

            }

        }

        //buscarar Cliente
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome = @nome";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }

        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                //Criar DataTable e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

                //Organiar o comando sql  e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Criar o MySqlDataAdapter para preeencher os dados no DstaTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //fechar a conexao com o BD
                conexao.Close();

                return tabelacliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o commando sql: " + erro);
                return null;

            }
        }
    }
}
