using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
    class Produkt
    {
        public List<Skladnik> lista;
        public Produkt()
        {
            lista = new List<Skladnik>();
        }
        public Produkt(List<Skladnik> lista)
        {
            this.lista = lista;
        }
    }
}
