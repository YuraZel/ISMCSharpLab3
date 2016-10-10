using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine(" Write your a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Write your b: ");
            b = Convert.ToInt32(Console.ReadLine());
            double summa = 0;
            for (int i = a; i <= b; i++)
            {
                summa += Math.Pow(i, 2);
            }
            Console.WriteLine("summa= " + summa);
            Console.ReadKey();
        }
    }
}
