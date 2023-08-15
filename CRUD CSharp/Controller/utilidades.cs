using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CSharp.Controller
{
    public class Utilidades
    {
        public static TimeSpan CalcularPrazoValidade(DateTime dataValidade)
        {
            TimeSpan intervaloTempo = dataValidade.Date - DateTime.Now;
            return intervaloTempo;
        }

        public static DateTime StringParaDatetime(string data)
        {
            DateTime dataConvertida = DateTime.Parse(data);
            return dataConvertida;
        }
    }
}
