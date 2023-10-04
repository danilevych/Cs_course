using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Person
    {
        private string name;
        private DateTime birthTime;

        public string Name { get { return name; } }
        public DateTime BirthTime { get {  return birthTime; } }

        public Person() 
        {
            name = "Facundo";
            birthTime = new DateTime(2000, 10, 10, 00, 00, 00);
        }

        public Person(string name, DateTime birthTime)
        {
            this.name = name;
            this.birthTime = birthTime;
        }

        public int Age()
        {
             return DateTime.Now.Year - this.BirthTime.Year;
            
        }

        public static Person Input()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter birthday date:");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"You create: {name}, who was born {birthDate}");

            return new Person(name, birthDate);
        }

        public void ChangeName(string newName)
        {
            this.name = newName;
            Console.WriteLine($"New name of person: {this.name}");
        }
        public override string ToString()
        {
            return "Name of Person " + name + "; birth day of person " + birthTime;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator == (Person man, Person woman)
        {
            return man.Name == woman.Name;
        }
        public static bool operator != (Person man, Person woman)
        {
            return !(man == woman);
        }

        









    }
}
