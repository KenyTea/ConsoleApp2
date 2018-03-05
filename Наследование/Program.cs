using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    


/*Классы: Car, Engine, Door, Driver, Garage, GasStation
	Переменные: для каждого класса придумать от 3 переменных
	Методы: для каждого класса придумать от 3 методов
	Статические методы: для каждого класса как минимум 1 статический метод
	
	Классы ДОЛЖНЫ взаимодействовать между собой
*/

namespace Encapsulation
    {
        public class GasStation
        {
            public static decimal Price { get; set; } // static


            public static void StaticMethodPrice() // static
            {
                Console.WriteLine(Price);
            }

            public string gazolinOrDiesel { get; set; } // constructor

            public GasStation(string toplivo)
            {
                gazolinOrDiesel = toplivo;
            }

            public void filling()
            {
                Console.WriteLine("Is filling the car");
            }

            public void EmptyTank()
            {
                Console.WriteLine("The tank is empty");
            }

            public void FullTank()
            {
                Console.WriteLine("The tank is full");
            }

            public void Display()
            {
                Console.WriteLine($"{gazolinOrDiesel}");
            }

        }

        public class Engine : GasStation
        {
            public double V { get; set; }
            public int celinders { get; set; }

            public Engine(string toplivo, double v, int cel) : base(toplivo) // constructor + base
            {
                V = v; celinders = cel;
            }

            public void standby()
            {
                Console.WriteLine("The Engine is ready");
            }

            public void startEngine()
            {
                Console.WriteLine("The Engine is starting");
            }

            public void stopEngine()
            {
                Console.WriteLine("The Engine is stop");
            }

            public void Print()
            {
                Console.WriteLine($"{V}{celinders}");
            }

        }

        public class Car : Engine
        {
            public string Marcs { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }

            public Car(string marcs, string model, string color, double v, int cel, string toplivo) : base(toplivo, v, cel )
            {
                Marcs = marcs; Model = model; Color = color;
            }

            public void moveFront()
            {
                Console.WriteLine("The Car is miving front");
            }

            public void moveBack()
            {
                Console.WriteLine("The Car is miving back");
            }

            public void stop()
            {
                Console.WriteLine("The Car is stoping");
            }

        }


        public class Door : Car
        {
            public int amount { get; set; }

            public void open()
            {
                Console.WriteLine("The door is opened");
            }

            public void close()
            {
                Console.WriteLine("The door is closed");
            }

            public void almostClosed()
            {
                Console.WriteLine("The door is almost closed");
            }

        }

        public class Driver
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }

            public void sitting()
            {
                Console.WriteLine("The driver sits behind the wheel");
            }

            public void steeping()
            {
                Console.WriteLine("The driver is sleeping in the car");

            }

            public void waiting()
            {
                Console.WriteLine("The driver is waiting in the car");

            }

        }

        public class Garage
        {
            public string locatin { get; set; }

            public void standing()
            {
                Console.WriteLine("The car is in the garage");

            }

        }


        class Program
        {
            static void Main(string[] args)
            {
                
                Console.ReadLine();
            }
        }
    }


    

