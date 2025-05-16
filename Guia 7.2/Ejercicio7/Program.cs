using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el año");
            int año = Convert.ToInt32(Console.ReadLine());
            if (año % 4 == 0)
            {
                if (año % 100 == 0)
                {
                    if (año % 400 == 0)
                    {
                        Console.WriteLine("es año bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("no es año bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("es un año bisiesto");
                }
            }
            else
            {
                Console.WriteLine("el año no es bisiesto");
            }
        }
    }
}
