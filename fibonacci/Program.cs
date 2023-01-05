using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e;

            Console.WriteLine("Wie viele Elemente sollen ausgegeben werden:");
            e = Convert.ToInt32(Console.ReadLine());

            int a, b, c;
            a = 0;
            b = 1;
            Console.Write("1");

            for (int i = 1; i < e ; i++)
            {
                c = a + b;

                Console.Write("\t"+ c);
                a = b;
                b = c;
                
            }
            Console.ReadLine();
        }
    }
}