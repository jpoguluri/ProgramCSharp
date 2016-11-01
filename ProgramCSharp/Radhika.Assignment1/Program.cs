using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhika.Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for tables");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Table of {0}", a);
            for (int i = 1; i > 11; i++)
            {
                Console.WriteLine(" {0}*{a}", a * i);
                Console.ReadLine();
            }
          
     
        }
    }
}
