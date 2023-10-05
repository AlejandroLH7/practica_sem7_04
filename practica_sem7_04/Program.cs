using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sem7_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                ("Ingresa un numero: ");
            Console.WriteLine("==================");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 2 * num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
