using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
    class Hex
    {
        public Hex(string kod)
        {
            Kod = kod;
        }

        public string Kod { get; set; }
        //public void Deconstruct(out string R,out string G,out string B)
        //{

        //    R = Kod[0].ToString() + Kod[1].ToString();
        //    G = Kod[2].ToString() + Kod[3].ToString();
        //    B = Kod[4].ToString() + Kod[5].ToString();
        //}
        public void Deconstruct(out int r1, out int g1, out int b1)
        {
            r1 = Convert.ToInt32(Kod.Substring(0, 2), 16);
            g1 = Convert.ToInt32(Kod.Substring(2, 2), 16);
            b1 = Convert.ToInt32(Kod.Substring(4, 2), 16);
        }
    }
}
