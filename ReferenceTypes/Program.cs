using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Todor", "Ivan", "Misho", "Ivaylo" };
            Console.WriteLine("First name before method call is: " + names[0]);
            EditNames(names);
            Console.WriteLine("First name after method call is: " + names[0]);

            // String is reference type but also immutable!!!
            string myName = "Hashim";
            Console.WriteLine("MyName before method call is: " + myName);
            AddLastnameToMyName(myName);
            Console.WriteLine("MyName after method call is: " + myName);

            Console.WriteLine("MyName before Change method call is: " + myName);
            ChangeMyName(myName);
            Console.WriteLine("MyName after Change method call is: " + myName);

            // Objects(Classes) are reference types
            Person myPerson = new Person("Todor", 22);
            Console.WriteLine(myPerson.Name + " is " + myPerson.Age + " years old. Before we call the method");
            RenamePerson(myPerson);
            ChangePersonAge(myPerson);
            Console.WriteLine(myPerson.Name + " is " + myPerson.Age + " years old. After we call the method");

            // care here
            Person personIvaylo = new Person("Ivaylo", 18);
            Console.WriteLine(personIvaylo.Name + " is " + personIvaylo.Age + " years old. Before we call ChangePerson method");
            ChangePerson(personIvaylo);
            Console.WriteLine(personIvaylo.Name + " is " + personIvaylo.Age + " years old. After we call ChangePerson method");
        }

        static void ChangePerson(Person myPerson)
        {
            myPerson = new Person("Pesho", 23);
            Console.WriteLine(myPerson.Name + " is " + myPerson.Age + " years old. In the ChangePerson method");
            myPerson.Name = "Ivan";
            myPerson.Age = 40;
            Console.WriteLine(myPerson.Name + " is " + myPerson.Age + " years old. In the ChangePerson method After we change Name and Age!");
        }

        static void ChangeMyName(string myName)
        {
            myName = myName.Replace('a', 'o');
            Console.WriteLine("MyName in Change method is: " + myName);
        }

        static void AddLastnameToMyName(string myName)
        {
            myName += " Solakov";
            Console.WriteLine("MyName in method is: " + myName);
        }

        static void EditNames(string[] names)
        {
            names[0] = "Pesho";
            Console.WriteLine("First name in method is: " + names[0]);
        }

        static void RenamePerson(Person person)
        {
            person.Name = "Pesho";
        }

        static void ChangePersonAge(Person person)
        {
            person.Age = 23;
        }
    }

    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}
