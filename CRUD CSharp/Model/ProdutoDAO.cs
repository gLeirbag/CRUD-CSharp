using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                NpgsqlCommand comando = Banco.DataSource.CreateCommand("INSERT INTO produtos (descricao, datavalidade, preco, taxalucro) VALUES (@descricao, @data_validade, @preco, @taxa_lucro) RETURNING codigo");
            
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
    }
}
