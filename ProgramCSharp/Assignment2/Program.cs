using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = new string[7];
            for(int i = 0;i < arrayOfStrings.Length;i++)
            {
                arrayOfStrings[i] = Console.ReadLine();
            }
            Console.WriteLine(arrayOfStrings);
            Console.ReadLine();
        }
    }
}
