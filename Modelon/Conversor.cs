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
        private ColeccionDivisas coleccion;
        private Divisa divRef;

        public ColeccionDivisas GetDivisas() { 

        return coleccion;

        }
        
        public Conversor(ColeccionDivisas coleccionDivisas, Divisa divisaBase)
        {
            this.coleccion = coleccionDivisas;
            this.divRef = divisaBase;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="divisaDe"></param>
        /// <param name="divisaE"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public double Convertir(Divisa divisaDe, Divisa divisaE, double cantidad)
        {
           
            double cantidadEnDivisaBase = divRef.cambio /  divisaDe.cambio ;
            double cantidadConvertida = cantidadEnDivisaBase *  divisaE.cambio;

            return cantidadConvertida * cantidad;
        }
      
    }
}
