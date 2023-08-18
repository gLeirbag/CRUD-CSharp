using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSharp.Model
{
    public static class ProdutoDAO
    {
        public static int Inserir(Produto produto)
        {
            try
            {
                //A classe NpgsqlCommand representa uma instrução SQL ou procedimento armazenado para executar contra um banco de dados PostgreSQL.
                NpgsqlCommand comando = Banco.DataSource.CreateCommand("INSERT INTO produtos (descricao, datavalidade, preco, taxalucro) VALUES (@descricao, @data_validade, @preco, @taxa_lucro) RETURNING codigo");
            
                //Adiciona os parâmetros ao comando SQL, evitando SQL Injection.
                //O método AddWithValue adiciona um parâmetro com o nome e o valor especificados.
                comando.Parameters.AddWithValue("@descricao", produto.Descricao);
                comando.Parameters.AddWithValue("@data_validade", produto.DataValidade);
                comando.Parameters.AddWithValue("@preco", produto.Preco);
                comando.Parameters.AddWithValue("@taxa_lucro", produto.TaxaLucro);

                return comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }   
        }

        public static DataTable Listar()
        {
            try
            {
                NpgsqlCommand comando = Banco.DataSource.CreateCommand("SELECT * FROM produtos");  //Cria o comando SQL que executaremos;
                NpgsqlDataReader reader = comando.ExecuteReader();                                 //Executa o comando SQL e retorna um DataReader
                var tabela = new DataTable();
                tabela.Load(reader);

                //Mostra o nome da tabela
                //MessageBox.Show(tabela.TableName);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable Listar(string descricao)
        {
            try
            { 
                NpgsqlCommand comando = Banco.DataSource.CreateCommand("SELECT * FROM produtos WHERE descricao LIKE @des");
                comando.Parameters.AddWithValue("@des", "%" + descricao + "%");
                NpgsqlDataReader reader = comando.ExecuteReader();
                var tabela = new DataTable();
                tabela.Load(reader);

                return tabela;
            }
            catch (Exception e )
            {

                throw e;
            }
        }


    }
}
