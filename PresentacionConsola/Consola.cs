using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;
using ModeloNegocio;


namespace PresentacionConsola
{
    public class Consola
    {
        private Conversor c;

        public Consola(Conversor c) { this.c = c; }

        public void  mostrar() {

            string s1, s2;

            System.Console.WriteLine("Introduce la  divisa origen : ");
            s1 = System.Console.ReadLine();
            while (!c.GetDivisas().Contains(s1))
            {
                System.Console.WriteLine("Divisa no encontrada, introduzca una otra");
                s1 = System.Console.ReadLine();
            }


            System.Console.WriteLine("Introduce divisa convertida: ");
            s2 = System.Console.ReadLine();

            while (!c.GetDivisas().Contains(s2))
            {
                System.Console.WriteLine("Divisa no encontrada, introduzca una otra");
                s2 = System.Console.ReadLine();
            }


            System.Console.WriteLine("Cantidad de dinero : ");
            double cant;
            bool verdad = double.TryParse(System.Console.ReadLine(),out cant);

            if (!verdad)
            {
                System.Console.WriteLine("Cantidad no valida, introduzca una correcta");
                verdad = double.TryParse(System.Console.ReadLine(), out cant);
            }

            double cantidad = c.Convertir(c.GetDivisas()[s1], c.GetDivisas()[s2], cant);
            System.Console.WriteLine("El resultado es: ");
            System.Console.WriteLine(cantidad);

            s2 = System.Console.ReadLine();



        }






    }
}
