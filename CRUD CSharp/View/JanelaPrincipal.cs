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
                //Salvar
                if(txtBoxCodigo.Text.Length == 0)
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
                        DataTable resultado = ProdutoController.Listar(txtBoxPesquisarDesc.Text);
                        dvgTabela.DataSource = resultado;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível inserir o produto!");
                    }

                }

                //Editar
                else
                {
                    Model.Produto produto = new Produto( Int32.Parse(txtBoxCodigo.Text), txtBoxDescricao.Text, CalDataValidade.SelectionStart, Int32.Parse(txtBoxPreco.Text) , Int32.Parse(txtBoxLucro.Text));
                    ProdutoDAO.Editar(produto);
                    MessageBox.Show("Produto editado com sucesso!");
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
                DataTable resultado = ProdutoController.Listar();
                dvgTabela.DataSource = resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtBoxPesquisarCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable resultado = ProdutoController.Listar(txtBoxPesquisarDesc.Text);
                dvgTabela.DataSource = resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            new fGrafico().ShowDialog();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
            ProdutoDAO.Excluir(int.Parse(txtBoxCodigo.Text));
            MessageBox.Show("Produto excluído com sucesso!");
            DataTable resultado = ProdutoController.Listar(txtBoxPesquisarDesc.Text);
            dvgTabela.DataSource = resultado;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao deletar"+ex.Message);
            }
        }

        private void txtBoxCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBoxCodigo.Text.Length > 0)
                { 
                    btnSalvar.Text = "Editar";
                    int codigo = Int32.Parse(txtBoxCodigo.Text);

                    Produto produto = ProdutoDAO.Recuperar(codigo);

                    txtBoxDescricao.Text = produto.Descricao;
                    txtBoxLucro.Text = produto.TaxaLucro.ToString();
                    txtBoxPreco.Text = produto.Preco.ToString();
                    CalDataValidade.SelectionStart = produto.DataValidade;


                }
                else btnSalvar.Text = "Salvar";

                DataTable resultado = ProdutoController.Listar(txtBoxPesquisarDesc.Text);
                dvgTabela.DataSource = resultado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Entrada Inválida: "+ ex);
                txtBoxCodigo.Clear();
            }
        }
    }
}
