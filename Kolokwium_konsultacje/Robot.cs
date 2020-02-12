using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
    class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void WLewo(object sender, EventArgs e)
        {
            X--;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public void WPrawo(object sender, EventArgs e)
        {
            X++;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public void WGore(object sender, EventArgs e)
        {
            Y++;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public void WDol(object sender, EventArgs e)
        {
            Y--;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }
}
