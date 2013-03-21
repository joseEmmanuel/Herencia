using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Programa
    {
        public void Trompeta()
        {
            Trompeta trompeta = new Trompeta();
            trompeta.nombre = "TROMPETA";
            trompeta.notas = " DO-RE-MI-FA-SOL-LA-SI";
            trompeta.precio = 8000;
            Console.WriteLine(trompeta.informacion());
        }

        static void Main(string[] args)
        {
            Programa programa = new Programa();
            programa.Trompeta();
            Console.ReadLine();
            
        }
    }
}