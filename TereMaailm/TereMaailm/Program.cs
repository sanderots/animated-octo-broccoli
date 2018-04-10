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
            static void Main(string[] args)
            {
                Console.WriteLine("Tere Maailm");
                Console.WriteLine("joujous");
                Console.WriteLine("teretere");
                Tervitaja.Tervita("Maailm");
            }
        }
    }

}
