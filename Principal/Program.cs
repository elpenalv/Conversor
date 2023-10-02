using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentacionConsola;
using ModeloDominio;
using ModeloNegocio;

namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            ColeccionDivisas divisas = new ColeccionDivisas();

            Divisa divRef = new Divisa("Euro", 1);
            divisas.Add(divRef);
            divisas.Add(new Divisa("Dolar", 1.07));
            divisas.Add(new Divisa("Libra", 0.86));
            divisas.Add(new Divisa("Yen", 158.016));

            Conversor conversor = new Conversor(divisas, divRef);

            Consola c = new Consola(conversor);
            c.mostrar();

        }
    }
}
