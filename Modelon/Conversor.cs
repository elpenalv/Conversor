using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloNegocio;
using ModeloDominio;

namespace ModeloNegocio
{
    public class Conversor
    {
        // Campos privados
        private ColeccionDivisas coleccion;
        private Divisa divRef;


        // Método para obtener la colección de divisas
        public ColeccionDivisas GetDivisas() { 

        return coleccion;

        }
        //Constructor   
        public Conversor(ColeccionDivisas coleccionDivisas, Divisa divisaBase)
        {
            this.coleccion = coleccionDivisas;
            this.divRef = divisaBase;
        }

        /// <summary>
        ///  Método para realizar una conversión de divisa
        /// </summary>
        /// <param name="divisaDe"> Divisa de entrada</param>
        /// <param name="divisaE">Divisa de salida</param>
        /// <param name="cantidad">Cantidad a convertir</param>
        /// <returns></returns>
        public double Convertir(Divisa divisaDe, Divisa divisaE, double cantidad)
        {
           
            double cantidadEnDivisaBase = divRef.cambio /  divisaDe.cambio ;
            double cantidadConvertida = cantidadEnDivisaBase *  divisaE.cambio;

            return cantidadConvertida * cantidad;
        }
      
    }
}
