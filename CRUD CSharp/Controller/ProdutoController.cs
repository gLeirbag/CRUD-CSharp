using CRUD_CSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CSharp.Controller
{
    public static class ProdutoController
    {
        public static DataTable Listar()
        {
            try
            {
                DataTable resultado = ProdutoDAO.Listar();

                // Renomeando as colunas
                resultado.Columns["codigo"].ColumnName = "Código";
                resultado.Columns["descricao"].ColumnName = "Descrição";
                resultado.Columns["datavalidade"].ColumnName = "Data de Validade";
                resultado.Columns["preco"].ColumnName = "Preço";
                resultado.Columns["taxalucro"].ColumnName = "Taxa de Lucro";

                //Adicionando coluna do prazo de validade
                DataColumn prazoValidade = new DataColumn("Prazo de Validade", typeof(int));

                resultado.Columns.Add(prazoValidade);
                resultado.Columns["Prazo de Validade"].SetOrdinal(3);
                //resultado.Columns["Prazo de Validade"].format;

                //Calculando o prazo de validade.
                foreach (DataRow row in resultado.Rows)
                {
                    DateTime data = (DateTime)row["Data de Validade"];
                    row["Prazo de Validade"] = Utilidades.CalcularPrazoValidade(data).Days;
                }
                //resultado.Columns["Prazo de Validade"].DataType = typeof(Day);


                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable Listar(string descricao)
        {
            DataTable resultado = ProdutoDAO.Listar(descricao);

            // Renomeando as colunas
            resultado.Columns["codigo"].ColumnName = "Código";
            resultado.Columns["descricao"].ColumnName = "Descrição";
            resultado.Columns["datavalidade"].ColumnName = "Data de Validade";
            resultado.Columns["preco"].ColumnName = "Preço";
            resultado.Columns["taxalucro"].ColumnName = "Taxa de Lucro";

            //Adicionando coluna do prazo de validade
            DataColumn prazoValidade = new DataColumn("Prazo de Validade", typeof(int));

            resultado.Columns.Add(prazoValidade);
            resultado.Columns["Prazo de Validade"].SetOrdinal(3);
            //resultado.Columns["Prazo de Validade"].format;

            //Calculando o prazo de validade.
            foreach (DataRow row in resultado.Rows)
            {
                DateTime data = (DateTime)row["Data de Validade"];
                row["Prazo de Validade"] = Utilidades.CalcularPrazoValidade(data).Days;
            }
            //resultado.Columns["Prazo de Validade"].DataType = typeof(Day);


            return resultado;
        }


    }
}
