﻿using System;
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
            //int[] arr3 = new int[] { 1,2,3,4,5};                        //variant init

            //Console.WriteLine(arr3.GetType().Name);                     // show  Int32[]
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
            //int[,] twoDimArr = new int[5, 5];                            // two-dimensional array

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        twoDimArr[i, j] = i * j;
            //        Console.WriteLine(twoDimArr[i, j] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //-----------------------------------------------------------------------------
            //Random rand = new Random();                                    // Random
            //int[][] juggedArray = new int[5][];                            // зубчатый массив
            //for (int i = 0; i < 5; i++)
            //{
            //    juggedArray[i] = new int[(i * 3) +1];
            //    for (int j = 0; j < juggedArray[i].Length; j++)
            //    {
            //        juggedArray[i][j] = rand.Next(0,10);                   // Random
            //        Console.Write(juggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Random random = new Random();
            //int maxLengthSubarrayIndex = default(int),
            //    maxLengthSubarrayValue = default(int),
            //    maxSumSubarrayIndex = default(int),
            //    maxSumSubarrayValue = default(int);

            //int[][] juggerArrayTwo = new int[random.Next(3, 7)][];

            //for (int i = 0; i < juggerArrayTwo.Length; i++)
            //{
            //    juggerArrayTwo[i] = new int[random.Next(1, 6)];
            //    if (juggerArrayTwo[i].Length > maxLengthSubarrayValue)
            //    {
            //        maxLengthSubarrayValue = juggerArrayTwo[i].Length;
            //        maxLengthSubarrayIndex = i;
            //    }
            //    int subarraySum = 0;
            //    for (int j = 0; j < juggerArrayTwo[i].Length; j++)
            //    {
            //        juggerArrayTwo[i][j] = random.Next(1, 10);
            //        Console.Write(juggerArrayTwo[i][j] + " ");
            //        subarraySum += juggerArrayTwo[i][j];
            //    }
            //    if (subarraySum > maxSumSubarrayValue)
            //    {
            //        maxSumSubarrayValue = subarraySum;
            //        maxSumSubarrayIndex = i;
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine(maxLengthSubarrayIndex + " " + maxLengthSubarrayValue);
            //Console.WriteLine(maxSumSubarrayIndex + " " + maxSumSubarrayValue);

            #region Mydubelfinde
            //Random rand = new Random();
            //int find = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int[] arrBinarFound = new int[10];
            //for (int i = 0; i < arrBinarFound.Length; i++)
            //{
            //arrBinarFound[i] = rand.Next(0, 10);
            //    Console.Write(arrBinarFound[i] + " ");
            //}
            //Console.WriteLine();

            //Array.Sort(arrBinarFound);                                      // -------Sort--------

            //for (int i = 0; i < arrBinarFound.Length; i++)
            //{
            //    Console.Write(arrBinarFound[i] + " ");
            //int left = arrBinarFound[0];
            //int right = arrBinarFound[9];
            //int midle = left + ((right - left) / 2);
            //    if (find < midle)
            //    {
            //        for (int j = 0; j < midle; j++)
            //        {
            //            if (arrBinarFound[j] == find)
            //            {
            //                Console.WriteLine("Found in " + arrBinarFound[j]);
            //            }
            //            else if (find > midle)
            //            {
            //                for (int k = midle; k < right; k++)
            //                {
            //                    if (arrBinarFound[k] == find)
            //                    {
            //                        Console.WriteLine("Found in " + arrBinarFound[k]);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}


            //Console.WriteLine();
            ////Console.WriteLine(left);
            ////Console.WriteLine(right);
            ////Console.WriteLine(midle);
            #endregion Mydubelfinde                  
            //  // https://github.com/shag-iskander-raimbayev/shag-csharp-module-three/blob/master/ArrayInCSharp/Program.cs
            Random random = new Random();
            int h = random.Next(3, 8);
            int[][] juggedArray = new int[h][];
            int maxLength = default(int);

            for (int i = 0; i < juggedArray.Length; i++)
            {
                juggedArray[i] = new int[random.Next(1, 5)];
                if (juggedArray[i].Length > maxLength)
                {
                    maxLength = juggedArray[i].Length;
                }

                for (int j = 0; j < juggedArray[i].Length; j++)
                {
                    juggedArray[i][j] = random.Next(1, 10);
                    Console.Write(juggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] mirroredArray = new int[h, maxLength * 2];

            for (int i = 0; i < juggedArray.Length; i++)
            {
                for (int j = 0; j < juggedArray[i].Length; j++)
                {
                    mirroredArray[i, j] = juggedArray[i][j];
                    Console.Write(mirroredArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            int midLine = (maxLength);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < midLine; j++)
                {
                    int oppositeElementIndex = (maxLength * 2 - 1 - j);
                    if (mirroredArray[i, j] != 0)
                    {
                        mirroredArray[i, oppositeElementIndex] = 10 - mirroredArray[i, j];
                    }
                }
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < maxLength * 2; j++)
                {
                    Console.Write(mirroredArray[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }

        static int BinarySearch(int[] array, int left, int right, int value)
        {
            if (left < right)
            {
                int midPoint = left + (right - left) / 2;
                if (array[midPoint] == value)
                {
                    return midPoint;
                }
                else if (array[midPoint] > value)
                {
                    return BinarySearch(array, left, midPoint - 1, value);
                }
                else
                {
                    return BinarySearch(array, midPoint + 1, right, value);
                }
            }
            else
            {
                return -1;
            }

            Console.ReadLine();
        }

    }
}
