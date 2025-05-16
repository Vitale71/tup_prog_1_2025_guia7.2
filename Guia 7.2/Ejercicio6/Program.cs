using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int setJ1 = 0 , setJ2 = 0;
            
            Console.WriteLine("ingrese el nombre del jugador 1");
            string jug1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ingrese el nombre del jugador 2");
            string jug2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ingrese los puntos del set 1, jugador 1");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los puntos del set 1, jugador 2");
            int p2 = Convert.ToInt32(Console.ReadLine());
            if (p1 > p2)
            {
                setJ1++;
            }
            else
            {
                setJ2++;
            }

            Console.WriteLine("ingrese los puntos del set 2, jugador 1");
            int p3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los puntos del set 2, jugador 2");
            int p4 = Convert.ToInt32(Console.ReadLine());
            if (p3 > p4)
            {
                setJ1 ++;
            }
            else
            {
                setJ2 ++;
            }

            Console.WriteLine("ingrese los puntos del set 1, jugador 1");
            int p5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los puntos del set 1, jugador 2");
            int p6 = Convert.ToInt32(Console.ReadLine());
            if (p1 > p2)
            {
                setJ1 += 1;
            }
            else
            {
                setJ2 += 1;
            }

            if (setJ1 > setJ2)
            {
                Console.WriteLine("el ganador del partido es {0} con {1} sets ganados" , setJ1 ,jug1 );
            }
            else
            {
                Console.WriteLine("el ganador del partido es {0} con {1} sets ganados", setJ2, jug2);
            }
        }
    }
}
