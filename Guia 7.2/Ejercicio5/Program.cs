using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayor, orden;
            Console.WriteLine("ingrese el primer numero");
            mayor = Convert.ToInt32(Console.ReadLine());
            orden = 1;
            Console.WriteLine("ingrese el segundo numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
                orden = 2;
            }

            Console.WriteLine("ingrese el tercer numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
                orden = 3;
            }

            Console.WriteLine("ingrese el cuarto numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
                orden = 4; 
            }

            Console.WriteLine("ingrese el quinto numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
                orden = 5;
            }
            Console.WriteLine("el mayor numero es: {0} con orden de {1}" ,mayor , orden);
        }
    }
}
