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
            //int a = 5;
            //int b = 10;
            //int c = 15;
            //Console.Write(a ); Console.Write(' '); Console.Write(b); Console.Write(' '); Console.Write(c);
            //Console.WriteLine();
            //Console.WriteLine();

            /*2.	Вывести на экран числа 5, 10 и 21 одно под другим.*/
            //int d = 5;
            //int e = 10;
            //int f = 21;
            //Console.WriteLine(d); Console.WriteLine(e); Console.WriteLine(f);
            //Console.WriteLine();

            /*3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.*/
            //Console.WriteLine("Enter number");
            //float temp = float.Parse(Console.ReadLine());
            //temp = temp / 1000;
            //Console.Write(temp); Console.WriteLine(" m.");
            //Console.WriteLine();

            /*4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?*/
            //int days = 234;
            //int weeks;
            //weeks = days / 7;
            //Console.Write(weeks); Console.WriteLine(" weeks");

            /*5.	Дано двузначное число. Найти:
                        a.	число десятков в нем;
                        b.	число единиц в нем;
                        c.	сумму его цифр;
                        d.	произведение его цифр
                        */
            //int value = 25;
            //int doz = value  / 10;
            //int unit = value % 10;
            //int sum = doz + unit;
            //int multi = doz * unit;
            //Console.Write("dez - "); Console.WriteLine(doz);
            //Console.Write("unit - "); Console.WriteLine(unit);
            //Console.Write("sum - "); Console.WriteLine(sum);
            //Console.Write("multiplication - "); Console.WriteLine(multi);

            /*6.	Вычислить значение логического выражения при следующих значениях логических величин
             * А, В и С: А = Истина, В = Ложь, С = Ложь:
                          a.	А или В; 
                          b.	А и В; 
                          c.	В или С.
                          */
            //bool A = true;
            //bool B = false;
            //bool C = false;
            //bool sum;

            //sum = (A || B);
            //Console.WriteLine(sum);
            //sum = (A && B);
            //Console.WriteLine(sum);
            //sum = (B || C);
            //Console.WriteLine(sum);

            /*7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?*/

            //Console.WriteLine("Enter the radius of the circle ");
            //int radius = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the values of the side of the square ");
            //int side = int.Parse(Console.ReadLine());
            //double Sr;
            //double P = 3.14;
            //Sr = (P * (radius * radius));
            //Console.Write("Area of a circle "); Console.WriteLine(Sr);
            //double Ss = side * side;
            //Console.Write("Square of a square "); Console.WriteLine(Ss);
            //Console.WriteLine();

            //if (Sr > Ss)
            //{
            //    Console.WriteLine("Area of the circle is larger than the square");
            //    Console.WriteLine();
            //}
            //else if (Sr < Ss)
            //{
            //    Console.WriteLine("Square of the square is larger than the area of the circle");
            //    Console.WriteLine();
            //}
            //else Console.WriteLine("The square of the square and the area of the circle are equal");
            //Console.WriteLine();

            /*8.    Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?*/
            Console.WriteLine("Enter V and M for solid #1");
            int Vs = int.Parse(Console.ReadLine());
            int Vs2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter V and M for solid #2");
            int MasS = int.Parse(Console.ReadLine());
            int MasS2 = int.Parse(Console.ReadLine());
            int solid, solid2;
            solid = Vs / MasS;
            solid2 = Vs2 / MasS2;
            Console.Write("The density of the first material"); Console.WriteLine(solid);
            Console.Write("The density of the second material"); Console.WriteLine(solid2);
            Console.WriteLine();
            if (solid > solid2)
            {
                Console.WriteLine("The density of the first material is higher than the second");
            }
           else if (solid < solid2)
            {
                Console.WriteLine("The density of the second material is higher than the first");
            }
            else
            {
                Console.WriteLine("The density of both materials is the same");
            }



        }
    }
}
