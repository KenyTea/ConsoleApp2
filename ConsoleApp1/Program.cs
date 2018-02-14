using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.*/

            int a = 5;
            int b = 10;
            int c = 15;
            Console.Write(a ); Console.Write(' '); Console.Write(b); Console.Write(' '); Console.Write(c);
            Console.WriteLine();
            Console.WriteLine();

            /*2.	Вывести на экран числа 5, 10 и 21 одно под другим.*/
            int d = 5;
            int e = 10;
            int f = 21;
            Console.WriteLine(d); Console.WriteLine(e); Console.WriteLine(f);
            Console.WriteLine();

            /*3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.*/
            Console.WriteLine("Enter number");
            float temp = float.Parse(Console.ReadLine());
            temp = temp / 1000;
            Console.Write(temp); Console.WriteLine(" m.");
            Console.WriteLine();

            /*4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?*/


        }
    }
}
