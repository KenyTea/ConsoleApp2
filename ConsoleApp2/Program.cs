using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // namespaces (пространство имён)

// camelCase - use for arguments, all variables inside method
// PascalCase - use for all classes, all methods
// F12 HELP class's method

namespace ConsoleApp2  //
{
    class Program
    {
        static void Main(string[] args)
        {
            // cin and cout
            Console.WriteLine("Hello World"); // with \n

            Console.ForegroundColor = ConsoleColor.Green; // Color
            Console.BackgroundColor = ConsoleColor.Red; // Color

            Console.Title = "C# Group"; // Name Consol

            Console.Write("Hello");// without \n
            Console.Write("World");
            Console.ReadLine();

            byte myValue = 255; // +, max
            sbyte myValue2 = 127; // -/+,  max
            Console.WriteLine(myValue);
            Console.WriteLine(myValue2);

            byte a = Byte.MaxValue; // show max capacity
            Console.WriteLine(a);

            int myInteger = int.MaxValue; // same things
            int myInteger2 = Int32.MaxValue; // same things sintax shugar

            float myFloat = Single.MaxValue;
            double myDouble = Double.MaxValue;
            long mylong = Int64.MaxValue;



            Console.ReadLine(); // like system pause
            Console.ReadKey(); // like system pause
        }
    }
}
