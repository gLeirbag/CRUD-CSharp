using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp.Model
{
    public class Produto
    {
        // Propriedades, estou tentando usar só propriedades ao invés de métodos getters e setters.
        public int Codigo { get; set; }     
        public string CodigoString
        {
            get
            {
                return this.Codigo.ToString();
            }
            set
            {
                this.Codigo = int.Parse(value);
            }
        }

        public string Descricao { get; set; }

        public DateTime DataValidade { get; set; }
        
        public TimeSpan PrazoValidade { 
            get
            { 
                TimeSpan intervaloTempo = DataValidade.Date - DateTime.Now;
                return intervaloTempo;
            }
        }

        public double Preco { get; set; }

        public double TaxaLucro { get; set; }

        //Construtor com todos os parâmetros
        public Produto(int cod, string des, DateTime dt, double pr, double tx)
        {
            this.Preco = pr;
            this.TaxaLucro = tx;
            this.Codigo = cod;
            this.Descricao = des;
            this.DataValidade = dt;

        }

        public Produto()
        {

        }
       

    }
}
