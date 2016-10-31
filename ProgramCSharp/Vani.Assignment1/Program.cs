using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vani.Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to Bible Quiz!");
            Console.WriteLine();
            int i = 0;
            // Question -1
            Console.WriteLine("Number of Chapters are in the book of Acts!");
            Console.WriteLine("1. 5    2.15");
            Console.WriteLine("3.27    4.28");
            Console.WriteLine();
            Console.Write("Choose one of the options: ");
            String userResponse = Console.ReadLine();
            String message;
            if (userResponse == "4")
            {
                i++;
                message = "Yay! you are correct!";
            }
            else
            {
                message = "It's high time to Open youe Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question  - 2
            Console.WriteLine("How many Verse are in  Proverbs Frist Chapter!");
            Console.WriteLine("1. 4     2. 33");
            Console.WriteLine("3. 35    4. 12");
            Console.WriteLine();
            Console.Write("Choose one of the option!");
            userResponse = Console.ReadLine();
            if (userResponse == "2")
            {
                i++;
                message = "Yay! you are correct!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question -3
            Console.WriteLine("During Jesus Temptations,how long did He go without eating ?");
            Console.WriteLine("1. 40 days&nights   2. 5 days");
            Console.WriteLine("3. 10 Days&nights   4. 2 days");
            Console.WriteLine();
            Console.Write("Choose one of the option!");
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                i++;
                message = "Yay! you are correct!";
            }
            else
            {
                message = "It's high time to Open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question-4
            Console.WriteLine("How many books are in the New Testament ?");
            Console.WriteLine("1. 20  2. 40");
            Console.WriteLine("3. 27  4. 50");
            Console.WriteLine();
            Console.Write("Choose one of the option!");
            userResponse = Console.ReadLine();
            if (userResponse == "3")
            {
                i++;
                message = "Yay! you are the correct!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question -5
            Console.WriteLine("How many books are in the Old Testament?");
            Console.WriteLine("1. 30  2. 39");
            Console.WriteLine("3.40   4.50");
            Console.WriteLine();
            Console.Write("Choose one of the option");
            userResponse = Console.ReadLine();
            if (userResponse == "2")
            {
                i++;
                message = "Yay! you are the corret!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question - 6
            Console.WriteLine("How many books are there in the Bible?");
            Console.WriteLine("1. 30   2. 69");
            Console.WriteLine("3. 66   4. 100");
            Console.WriteLine();
            Console.Write("Choose one of the option");
            userResponse = Console.ReadLine();
            if (userResponse == "3")
            {
                i++;
                message = "Yay! you are the correct!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question - 7
            Console.WriteLine("About how Old was Jesus when He began his Public minstry?");
            Console.WriteLine("1. About 30 years Old    2. About 20 years Old");
            Console.WriteLine("3. About 40 years Old    4. About 50 years Old");
            Console.WriteLine();
            Console.Write("Choose one of the option");
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                i++;
                message = "Yay! you are the correct!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question - 8
            Console.WriteLine("About how many People did God insprire to write the Bible?");
            Console.WriteLine("1. 56  2. 30");
            Console.WriteLine("3. 10  4. 40");
            Console.WriteLine();
            Console.Write("Choose one of the option");
            userResponse = Console.ReadLine();
            if (userResponse == "4")
            {
                i++;
                message = "Yay! you are the correct!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question - 9
            Console.WriteLine("What is the longest Chapter in the Bible?");
            Console.WriteLine("1. Psalm 119   2. Psalm 117");
            Console.WriteLine("3. Psalm 120   4. Psalm 130");
            Console.WriteLine();
            Console.Write("Choose one of the option");
            userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                i++;
                message = "Yay! you are the correct!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            //Question - 10
            Console.WriteLine("What is the shortest Chapter in the Bible?");
            Console.WriteLine("1. Psalm 119   2. Psalm 117");
            Console.WriteLine("3. Psalm  120  4. Psalm 130");
            Console.WriteLine();
            Console.Write("Choose one of the option");
            userResponse = Console.ReadLine();
            if (userResponse == "2")
            {
                i++;
                message = "Yay! you are the correct!";
            }
            else
            {
                message = "It's high time to open your Bible";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            Console.WriteLine("Your Quiz Results Summary:");
            Console.WriteLine();
            Console.WriteLine("1. Number of correct answers:{0}", i);
            int P = i * 100 / 10;
            Console.WriteLine();
            Console.WriteLine("2. Percentage of correct answers : {0}", P);
            Console.WriteLine();
            if (P >= 75)
            {
                Console.WriteLine("3. Great Job! your grade is :{0}", "A");
            }
            if (P < 75 && P >= 50)
            {
                Console.WriteLine("3. Not too Bad! your grade is : {0}", "B");
            }
            if (P < 50)
                Console.WriteLine("3. Way to go! your grade is :{0}", "C");
            Console.ReadLine();
        }
    }
}
