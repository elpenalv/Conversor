using ModeloDominio;
using ModeloNegocio;
using PresentacionConsola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentacionWIndows;


namespace Principal
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            
            ColeccionDivisas divisas = new ColeccionDivisas();

            Divisa divRef = new Divisa("Euro", 1);
            divisas.Add(divRef);
            divisas.Add(new Divisa("Dolar", 1.05));
            divisas.Add(new Divisa("Libra", 0.87));
            divisas.Add(new Divisa("Yen", 157.11));

            Conversor conversor = new Conversor(divisas, divRef);

            // Consola c = new Consola(conversor);
            //c.mostrar();
            Form1 f = new Form1(conversor);
            Application.Run(f);

        }
    }
}
