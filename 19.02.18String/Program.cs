using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------String----------------------------------------------------
namespace _19._02._18String
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Shag-academy";                                  // variant 1
            //string myString2 = new string(new char[] { 'S', 'H', 'A', 'G' });  // variant 2


            //Console.WriteLine(myString);
            //Console.WriteLine(myString2);

            ////--------------------------------UpperCase and LowerCase---------------------------

            //string upperVersion = myString.ToUpper();

            //Console.WriteLine(upperVersion);
            //Console.WriteLine(myString.ToUpper());

            //Console.WriteLine(myString.ToUpper().ToLower());
            //Console.WriteLine(myString.ToLower().ToUpper());
            //Console.WriteLine(myString.Count());
            //Console.WriteLine(myString.Count().ToString().ToUpper());

            ////--------------------------------------Split-----------------------------------

            //string myString3 = "C#-Vasiilyev-Alexey";
            //string [] splittedResult = myString3.Split('-');

            //Console.WriteLine(splittedResult);

            ////---------------------------------------Trim--------------------------- обрезает
            //string myString4 = "         jhkhkhdfjgklhdflgjkdf        ";
            //Console.WriteLine(myString4.Trim());

            //----------------------------------------------------------------------------------------------------

            int myInt = 100;
            byte MyByte = 100;
            sbyte mySbyte = 100;
            long myLong = 100;

            //checked
            //{
            //    sbyte newSbyte = (sbyte)(mySbyte + mySbyte);
            //    Console.WriteLine(newSbyte);
            //}

            //unchecked
            //{ 
            //sbyte newSbyte = (sbyte)(mySbyte + mySbyte);
            //Console.WriteLine(newSbyte);
            //}

            //string MyString = "apple_tree";

            //foreach (var item in MyString)
            //{
            //    Console.WriteLine((int)item);
            //}

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /*
         *  1. string[] args
         *  Совет: regions 
         *  2. unchecked / checked
         *  
         *  3. Массивы
         *  3.1 Random
         *  4. String
         */
            
                #region Topic 1 - Command Line Arguments
                /*
                string[] adminPasswords = { "y2*3da", "67Yw1J*" };
                string[] userPasswords = { "12345", "123456" };
                string [] passwordInput = { args[0], args[1] };
                bool isPassedByUserPassword = false, isPassedByAdminPassword = false;
                if (adminPasswords.Contains(args[0]))
                {
                    isPassedByAdminPassword = true;
                }
                else if (adminPasswords.Contains(args[1]))
                {
                    isPassedByAdminPassword = true;
                }
                if (userPasswords.Contains(args[0]))
                {
                    isPassedByUserPassword = true;
                }
                else if (userPasswords.Contains(args[1]))
                {
                    isPassedByUserPassword = true;
                }
                if(isPassedByUserPassword && isPassedByAdminPassword)
                {
                    Console.WriteLine("Welcome to SUPER-SECRET-PROGRAM");
                }
                */
                #endregion

                #region Checked Unchecked
                //checked
                //{
                //    int a = 100;
                //    sbyte b = 100;
                //    b = (sbyte)a;

                //    Console.WriteLine(b);

                //}
                #endregion

                #region Arrays
                //int [] array = new int[10];

                //int [] secondArray = new int[5] { 1, 2, 3, 4, 5};

                //int[] thirdArray = new int[] { 2, 3, 4, 5 };

                // Some int in range [A, B]
                //Random random = new Random();
                // R => [5; 10);

                //double sum = 0;
                //for(int i = 0; i < array.Length; i++)
                //{
                //    array[i] = random.Next(1, 10);
                //    sum += array[i];
                //    Console.Write(array[i] + " ");
                //}
                //Console.WriteLine();
                //Console.WriteLine(sum);
                //Console.WriteLine((sum / array.Length));

                // Jugged Array - Зубчатый массив
                //int[][] juggDimArray = new int[10][];

                //int[,] twoDimArray = new int[4,7];

                //int counter = 0;
                //for (int i = 0; i < 4; i++)
                //{
                //    for (int j = 0; j < 7; j++)
                //    {
                //        counter++;
                //        twoDimArray[i, j] = counter;
                //        Console.Write(twoDimArray[i, j] + " ");
                //    }
                //    Console.WriteLine();
                //}

                //for(int i = 0; i < juggDimArray.Length; i++)
                //{
                //    int length = random.Next(5, 10);
                //    juggDimArray[i] = new int[length];
                //    for(int j = 0; j < juggDimArray[i].Length; j++)
                //    {
                //        Console.Write(juggDimArray[i][j] + " ");
                //    }
                //    Console.WriteLine();
                //}

                //for(int i = 0; i<juggDimArray.Length / 2; i++)
                //{
                //    juggDimArray[i] = new char[i + 1];
                //    for(int j = 0; j < juggDimArray[i].Length; j++)
                //    {
                //        juggDimArray[i][j] = '#';
                //        Console.Write(juggDimArray[i][j]);
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = juggDimArray.Length/2 - 1; i >= 0; i--)
                //{
                //    juggDimArray[i] = new char[i + 1];
                //    for (int j = 0; j < juggDimArray[i].Length; j++)
                //    {
                //        juggDimArray[i][j] = '#';
                //        Console.Write(juggDimArray[i][j]);
                //    }
                //    Console.WriteLine();
                //}

                //int[][] juggArray = new int[random.Next(5, 10)][];
                //int maxLength = 0, maxLengthIndex = 0;
                //int maxSubsum = 0, maxSubsumIndex = 0;
                //for (int i = 0; i < juggArray.Length; i++)
                //{
                //    juggArray[i] = new int[random.Next(3, 7)];

                //    if(juggArray[i].Length > maxLength)
                //    {
                //        maxLength = juggArray[i].Length;
                //        maxLengthIndex = i;
                //    }

                //    int subSum = 0;
                //    for(int j = 0; j<juggArray[i].Length; j++)
                //    {
                //        juggArray[i][j] = random.Next(0,10);
                //        subSum += juggArray[i][j];
                //        Console.Write(juggArray[i][j] + " ");
                //    }
                //    if(subSum > maxSubsum)
                //    {
                //        maxSubsum = subSum;
                //        maxSubsumIndex = i;
                //    }
                //    Console.WriteLine();
                //}


                //Console.WriteLine("MAX LENGTH " + maxLength + " INDEX " + maxLengthIndex);
                //Console.WriteLine("MAX SUM " + maxSubsum + " INDEX " + maxSubsumIndex);

                //string initialWord = "mama";
                //string encodedWord = "";
                //int rotateValue = 3;

                //foreach (var item in initialWord)
                //{
                //    int ascii = (int)item;
                //    ascii += rotateValue;
                //    encodedWord += (char)(ascii);
                //}
                //Console.WriteLine(encodedWord);

                //string decodedWord = "";
                //foreach (var item in encodedWord)
                //{
                //    int ascii = (int)item;
                //    ascii -= rotateValue;
                //    decodedWord += (char)(ascii);
                //}
                //Console.WriteLine(decodedWord);


                //for (int i = -25; i <= 26; i++)
                //{
                //    string decodedValue = "";
                //    foreach (var item in encodedWord)
                //    {
                //        int intValue = (int)item;
                //        intValue += i;
                //        decodedValue += (char)intValue;
                //        Console.WriteLine( i +  " " + decodedValue);
                //    }
                //}


                //string firstString = "Almaty";
                //string secondString = new string(new char[] { 'A', 's', 't', 'a', 'n', 'a' });
                //string thirdString = firstString + " " + secondString; // Concatenation

                //Console.WriteLine(thirdString.ToUpper());
                //Console.WriteLine(thirdString.ToLower());

                //string longString = "HELLO_MY_WORLD*I_AM_HAPPY";

                //var splittedString = longString.Split('*');

                //foreach (var item in splittedString)
                //{
                //    Console.WriteLine(item);
                //}

                //firstString.ToUpper();
                //Console.WriteLine(firstString);

                //string intialString = "MyNewString";
                //intialString += "AddedSmthNew";

                //StringBuilder smth = new StringBuilder();
                //string someString = "";

                //for(int i = 0; i < 1000000; i++)
                //{
                //    smth.Append("a");
                //}
                //Console.WriteLine(smth.ToString().Length);

                //string code = "loldaaawwwffg";

                ////Console.WriteLine(code.Contains("wffgg"));

                //string newString = code.Replace("wwff", "y");

                //char[] reversed = code.Reverse().ToArray();

                //string reversedString = new string(reversed);

                //// Console.WriteLine(reversedString);

                //string newStringWithCopies = "aaaabbbcccddde";
                //char[] districtValues = newStringWithCopies.Distinct().ToArray();

                //string updatedValue = new string(districtValues);
                ////Console.WriteLine(updatedValue);


                //Console.WriteLine(updatedValue + " " + newString);


                //Console.WriteLine("{1} {1} {1}", updatedValue, newString, newStringWithCopies); // String Formatting
                //string secret = "***";
                //Console.WriteLine($"Hello it is my string { DateTime.Now } lol lol lol lol"); // String Interpolation

                //Console.OutputEncoding = UTF8Encoding.UTF8;
                //Thread.CurrentThread.CurrentCulture = new CultureInfo("us");

                //int salary = 100000;
                //string value = string.Format(new CultureInfo("kz-KZ"), "{0:C}", salary);
                //Console.WriteLine(value);
                #endregion
            
             //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                string name = "Alexey";

            foreach (var item in name)
            {
                Console.WriteLine((int)item );
            }

            Console.ReadLine();
        }
    }
}
