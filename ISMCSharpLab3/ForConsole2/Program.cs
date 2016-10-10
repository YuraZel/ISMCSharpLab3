using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine(" Write your n: ");
            n = Convert.ToInt32(Console.ReadLine());
            double summa = 0;
            for (int i = 1; i <= n; i++)
            {
                summa += 1.0 / i;
            }
            Console.WriteLine("summa= " + summa);
            Console.ReadKey();
        }
    }
}
