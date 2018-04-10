using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TereMaailm
{
    class Program
    {
        internal class Tervitaja
        {
            internal static void Tervita(string v)
            {
                Console.WriteLine("Tere {0}", v);
            }
            internal static void Tervita(string[] nimed)
            {
                for (int i = 0; i < nimed.Length; i++)
                {
                    Tervita(nimed[i]);
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Tere Maailm");
                Console.WriteLine("joujous");
                Console.WriteLine("teretere");
                Tervitaja.Tervita("Maailm");
                Tervitaja.Tervita(new string[] { "Sander", "Jaan", "Toomas" });


                

            }
        }
    }

}
