using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
    [Flags] // atrybut
    enum Status
    {
        Normlany = 0,       //00000
        Trucizna = 1,       //00001
        Ogluszenie = 2,     //00010
        Uciszenie = 4,      //00100
        Spowolnienie = 8,   //01000
        Szał = 16           //10000
    }
    //enum delivery
    //{
    //    None =0;
    //}
}
