using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine(" Write your n: ");
            n = Convert.ToInt32(Console.ReadLine());
            double summa = 0;
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                summa += factorial;
            }
            Console.WriteLine("summa= " + summa);
        }
    }
}
