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
        public int Id { get; set; }     
        public string IdString
        {
            get
            {
                return this.Id.ToString();
            }
            set
            {
                this.Id = int.Parse(value);
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
       

    }
}
