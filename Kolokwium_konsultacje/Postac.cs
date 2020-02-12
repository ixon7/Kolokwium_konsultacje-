using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_konsultacje
{
    class Postac
    {
        private bool spowolniony = true;

        public void Kolejka()
        {
            if (status == Status.Normlany)
            {
                Console.WriteLine("Co robisz?");
                Console.ReadLine();
            }
            else
            {
                if (status == Status.Trucizna)
                {
                    HP -= 2;
                    Console.WriteLine("Co robisz?");
                    Console.ReadLine();
                }
                else
                {
                    if (status == Status.Ogluszenie)
                    {
                        Console.WriteLine("Tracisz kolejkę");
                        status = status & ~Status.Ogluszenie;
                        //Postac      10110
                        //cel   11101 &&&&&
                        //!ogluszenie 11101
                        //wynik       10100
                    }
                    else
                    {
                        if (status == Status.Spowolnienie)
                        {
                            Console.WriteLine("Tracisz Kolejke");
                            spowolniony = false;
                        }
                        else
                        {
                            Console.WriteLine("Co robisz dalej?");
                            spowolniony = true;
                            if (status == Status.Szał)
                            {
                                Console.WriteLine("Postac ruszyła do ataku");
                            }
                        }
                    }
                }
            }
        }
        public Postac()
        {
            HP = 10;
            this.status = 0;
        }

        public int HP { get; set; }
        //status
        //List<string> Status 
        public Status status { get; set; }
    }
}
