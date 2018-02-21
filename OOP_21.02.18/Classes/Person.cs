using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_21._02._18.Classes
{
    enum PersonGender { Male, Female, Transgender}

    internal class Person
    { // поле
        public string FirstName;
        public string LastName;
        public int Age;
        public PersonGender Gender;

        

        // конструктор
        // ctor автоматическое создание конструктора
        
        private Person() // конструктор 1
        {
           
            Age = 0;
            Console.WriteLine("private Person()");
        }

        public Person(PersonGender gender) : this()
        {
            Gender = gender;
            Console.WriteLine("public Person(PersonGender gender)");
        }

        public Person(string firstname, string lastname ) : this()
        {
            FirstName = firstname;
            LastName = lastname;           
            Console.WriteLine("public Person(string firstname, string lastname)");
        }

    
    }
}
