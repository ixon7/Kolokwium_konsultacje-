using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                //stwórz listę produktów 
                List<Produkt> produkty = new List<Produkt>();

                //Wypełnij kolekcję losowaymi danymi 
                // Produkt1
                List<Skladnik> skladniki1 = new List<Skladnik>();
                skladniki1.Add(new Skladnik(100, 32, 5));
                skladniki1.Add(new Skladnik(50, 50, 0));
                skladniki1.Add(new Skladnik(1000, 0, 155));
                produkty.Add(new Produkt(skladniki1));

                // Produkt2
                List<Skladnik> skladniki2 = new List<Skladnik>();
                skladniki2.Add(new Skladnik(10, 16, 0));
                skladniki2.Add(new Skladnik(32, 12, 0));
                skladniki2.Add(new Skladnik(19, 0, 20));
                produkty.Add(new Produkt(skladniki2));

                foreach (var i in produkty)
                {
                    Console.WriteLine($"Węglowodany {i.lista.Sum(x => x.Weglowodany)}");
                    Console.WriteLine($"Tluszcz {i.lista.Sum(x => x.Tluszcz)}");
                    Console.WriteLine($"Sol {i.lista.Sum(x => x.Sol)}");
                }


                Hex obiekt = new Hex("FFAAEE");
                (int r, int g, int b) = obiekt;


                Panel panel = new Panel();
                Robot robot = new Robot();
                //Dopisz do listy nasłuchujących handlerów funkcję WLewo
                panel.LEFT += robot.WLewo;
                panel.RIGHT += robot.WPrawo;
                panel.DOWN += robot.WDol;
                panel.UP += robot.WGore;
                // Wywołaj funkcję, która opublikuje event LEFT
                panel.Left();
                panel.Down();
                panel.Up();
                panel.Right();

                Postac postac = new Postac();
                postac.Kolejka();
                postac.status = Status.Spowolnienie;
                postac.Kolejka();
                postac.status = Status.Trucizna;
                postac.Kolejka();
                postac.status = Status.Szał;
            }
        }
}
