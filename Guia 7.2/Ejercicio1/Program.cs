using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float condicionP, n1, n2, n3, prom;
            Console.WriteLine("ingrese la condicion de promocion");
            condicionP = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ahora ingrese las tres notas a evaluar");
            n1 = Convert.ToSingle(Console.ReadLine());
            n2 = Convert.ToSingle(Console.ReadLine());
            n3 = Convert.ToSingle(Console.ReadLine());
            prom = (n1 + n2 + n3) / 3f;
            if (condicionP >= prom)
            {
                Console.WriteLine("el alumno promociona");
            }
            else
            {
                Console.WriteLine("el alumno rinde final");
            }
        }
    }
}
