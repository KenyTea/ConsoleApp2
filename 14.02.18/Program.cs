using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays (massivs)

            //int[] arr = new int[10];
            //int[] arr2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //variant init
            //int[] arr3 = new int[] { 1,2,3,4,5}; //variant init

            //Console.WriteLine(arr3.GetType().Name); // show  Int32[]
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i] = i * 10;
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //--------------------------------------------------------------------------------
            int[,] twoDimArr = new int[5, 5]; // two-dimensional array

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    twoDimArr[i, j] = i * j;
                    Console.WriteLine(twoDimArr[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //-----------------------------------------------------------------------------
            int[][] juggedArray = new int[5][]; // зубчатый массив
            for (int i = 0; i < 5; i++)
            {
                juggedArray[i] = new int[(i * 3) +1];
                for (int j = 0; j < juggedArray[i].Length; j++)
                {
                    juggedArray[i][j] = i * j;
                }
            }

            Console.ReadLine();
        }

    }
}
