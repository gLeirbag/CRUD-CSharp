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

namespace CRUD_CSharp.View
{
    public partial class fGrafico : Form
    {
        public fGrafico()
        {
            InitializeComponent();
            mostrarGrafico();
        }

        public void mostrarGrafico()
        {
            try
            {
                DataTable Produtos = ProdutoDAO.Listar();

                chartGrafico.Titles.Add("Lucros e Validades");

                chartGrafico.ChartAreas[0].AxisX.Title = "Descrição";
                //chartGrafico.ChartAreas[0].AxisY.Title = "Validade";

                chartGrafico.Series[0].Name = "Lucro";
                chartGrafico.Series[0].IsVisibleInLegend = true;

                chartGrafico.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
                chartGrafico.Series[1].Name = "Validade";
                chartGrafico.Series[1].IsVisibleInLegend = true;

                foreach (DataRow produto in Produtos.Rows)
                {
                    chartGrafico.Series[0].Points.AddXY((string)produto["descricao"], Convert.ToDouble(produto["taxalucro"]));
                    //chartGrafico.Series[0].Points.AddY((string)produto["descricao"]);
                    //chartGrafico.Series[0].Points.Add(Convert.ToDouble(produto["taxalucro"]));
                    var data = (DateTime)produto["datavalidade"];
                    chartGrafico.Series[1].Points.Add(Utilidades.CalcularPrazoValidade(data).Days);

                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
