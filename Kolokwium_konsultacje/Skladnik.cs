using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
    class Skladnik
    {
        public Skladnik(int weglowodany, int tluszcz, int sol)
        {
            Weglowodany = weglowodany;
            Tluszcz = tluszcz;
            Sol = sol;
        }
        public int Weglowodany { get; set; }
        public int Tluszcz { get; set; }
        public int Sol { get; set; }
    }
}

