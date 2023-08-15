using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
