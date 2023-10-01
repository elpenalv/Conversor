using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace ModeloNegocio         
{
    public class ColeccionDivisas : KeyedCollection<string, Divisa>
    {
        protected override string GetKeyForItem(Divisa item)
        {
            return item.id;
        }

    }
}

