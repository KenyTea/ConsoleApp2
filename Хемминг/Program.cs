using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хемминг
{
    class Program
    {
        static void Main(string[] args)
        {
            // конвертация из десятичной в двоичную

            //int value = int.Parse(Console.ReadLine()); 
            //string binary = Convert.ToString(value, 2);
            //Console.WriteLine(binary);
            //Console.ReadLine();

            int x = int.Parse(Console.ReadLine()); 
            string s = "";
            while (x > 0)
            {
                s = ((x % 2 == 0) ? "0" : "1") + s;
                x /= 2;
            }
            Console.Write(s);
            Console.ReadKey();

            //int num10 = int.Parse(Console.ReadLine()); // число в десятичной системе исчисления
            //int a = 0; // a - остаток после % деления из которого формируется число в 
            //           //    двоичной системе исчисления
            //int i = 0;

            //int[] b = new int[10]; // массив с помощью которого двоичное число позже 
            //                       //будет выведено с конца для правильного отображения 

            //while (num10 >= 1)
            //{
            //    a = num10 % 2;
            //    b[i] = a;
            //    i++;

            //    num10 = num10 / 2;

            //    Console.Write(a);
            //};

            //Console.WriteLine();

            //for (i = (b.Length - 1); i >= 0; i--)
            //{
            //    Console.Write(b[i]);
            //}

            //Console.ReadKey();

        }
    }
}
