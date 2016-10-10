using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a;
            Console.WriteLine(" Write your n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Write your a: ");
            a = Convert.ToDouble(Console.ReadLine());
            double dob = 1;
            for (int i = 1; i <= n; i++)
            {
                dob *= a;
            }
            Console.WriteLine("dob= " + dob);
            Console.ReadKey();
        }
    }
}
