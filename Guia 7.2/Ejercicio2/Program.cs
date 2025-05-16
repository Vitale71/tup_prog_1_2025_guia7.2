using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero entrero para determinar signo o si es 0");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("el numero es negativo");
            }
            else
            {
                if (num == 0)
                {
                    Console.WriteLine("el numero es 0");
                }
                else
                {
                    Console.WriteLine("el numero es positivo");
                }
            }
        }
    }
}
