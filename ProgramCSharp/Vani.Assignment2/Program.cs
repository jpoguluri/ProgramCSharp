using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vani.Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[] { 1, 2, 3, 4, 2, 5, 2, 6, 2, 3, 2 };
            //for (int index = 0; index < numbers.Length; index++)  
            // {
            //  Console.WriteLine(numbers [index]);

            // }
            // Console.ReadLine();
            // int counter = 0;
            // for (int index = 0; index < numbers.Length; index++)
            // {
            //if (numbers[index] == 2)
            //  {
            //    counter++;
            //  }
            // Console.WriteLine("2 is found {0} times", counter);
            // Console.ReadLine();

            // }
            string inputString = "The Lord is my Shepherd!";
            char[] inputStringCharArray = inputString.ToCharArray();
            foreach(char character in inputStringCharArray.Reverse())
                {
                Console.Write(character);
                Console.ReadLine();
            }
          
        }
    }

}