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
            int num, mayor;
            Console.WriteLine("ingrese el primer numero");
            mayor = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("ingrese el segundo numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("ingrese el tercer numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("ingrese el cuarto numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("ingrese el quinto numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }
            Console.WriteLine("el mayor numero es: {0}", mayor);
        }
    }
}
