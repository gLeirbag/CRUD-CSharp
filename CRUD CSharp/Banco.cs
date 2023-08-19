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

        //NpgsqlDataSource representa seu banco de dados PostgreSQL e pode fornecer conexões a ele ou suportar a execução direta de SQL nele.
        //NpgsqlDataSource encapsula as várias configurações do Npgsql necessárias para se conectar ao PostgreSQL, bem como o pool de conexões que torna o Npgsql eficiente.
        public static readonly NpgsqlDataSource DataSource = NpgsqlDataSource.Create(StringConexao);
        

    }
}
