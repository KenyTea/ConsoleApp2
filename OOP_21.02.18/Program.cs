﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_21._02._18.Classes;

namespace OOP_21._02._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alexey", "Vassilyev");
            CustomByte customByte = new CustomByte();
            Console.WriteLine(person.Gender);

            Console.ReadLine();
        }
    }
}
