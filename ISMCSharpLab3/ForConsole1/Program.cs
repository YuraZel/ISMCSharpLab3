using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 8;
            int i;
            double dob = 1;
            for (i = a; i <= b; i++)
            {
                dob = dob * i;
            }
            Console.WriteLine("dob= " + dob);
            Console.ReadKey();

        }
    }
}
