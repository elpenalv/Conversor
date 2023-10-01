using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Divisa
    {
        public string id { get; }
        public double  cambio { get; set; }

        public Divisa(string id, double cambio)
        {
            this.id = id;
            this.cambio = cambio;
        }
    }

  
}
