using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D a;
            a = new Punto2D(1, 1);
            Console.WriteLine(a.ToString());

            
            Punto a2;
            a2 = new Punto(2.3);

            Console.WriteLine(a2.ToString());
            

            Distancia a4;
            a4 = new Distancia(2);

            Console.WriteLine(a4.ToString());
            Console.ReadKey();

        }
    }
}
