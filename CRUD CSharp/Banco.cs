using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CRUD_CSharp
{
    public static class Banco
    {
        // Constante de conexão com o banco de dados. Ficar de olho na senha. Isso em C# é um membro da classe categorizado como "constante".
        private const string StringConexao = "Server=localhost;Port=5432;User Id=postgres;Password=G4briel1;Database=tocc8;";
        public static readonly NpgsqlDataSource DataSource = NpgsqlDataSource.Create(StringConexao);
        

        //public static void abrirConexao()
        //{
        //    if (dataSource == null)
        //    {
        //        dataSource = NpgsqlDataSource.Create(StringConexao);
        //        return;
        //    }
        //    else
        //    {
        //          throw new Exception("Já há uma conexão aberta");
        //    }
        //}


    }
}
