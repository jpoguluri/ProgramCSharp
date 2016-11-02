using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joel.Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of  {0}+{1} is {2}", 3, 4, (3 + 4));
           Console.WriteLine("Difference of {0}-{1}, is {2}", 7, 2, (7 - 2));
           Console.WriteLine("Product of {0}*{1} is {2}", 2, 8, (8 * 2));

            Console.WriteLine("7th Table");
            

            int i = 1;

            for  (i = 1; i <= 70; i++)
            {
                if (i % 7 == 0)
               {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
