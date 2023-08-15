using CRUD_CSharp.Controller;
using CRUD_CSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Pra fazer:
// [ ] - Mover a lógica de negócio para a camade Controller.

namespace CRUD_CSharp.View
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                Model.Produto produto = new Model.Produto();
                produto.Descricao = txtBoxDescricao.Text;
                produto.DataValidade = CalDataValidade.SelectionStart;
                
                produto.Preco = double.Parse(txtBoxPreco.Text);
                produto.TaxaLucro = double.Parse(txtBoxLucro.Text);

                int retorno = Model.ProdutoDAO.Inserir(produto);

                if (retorno > 0)
                {
                    MessageBox.Show("Produto inserido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível inserir o produto!");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable resultado =ProdutoDAO.Listar();

                // Renomeando as colunas
                resultado.Columns["codigo"].ColumnName =       "Código";
                resultado.Columns["descricao"].ColumnName =    "Descrição";
                resultado.Columns["datavalidade"].ColumnName = "Data de Validade";
                resultado.Columns["preco"].ColumnName =        "Preço";
                resultado.Columns["taxalucro"].ColumnName =    "Taxa de Lucro";

                //Adicionando coluna do prazo de validade
                DataColumn prazoValidade = new DataColumn("Prazo de Validade", typeof(int) );

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
                

                dvgTabela.DataSource = resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  
    }
}
