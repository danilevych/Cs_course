using System;
using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countOfPersons = 6;
            const int veryYoung = 16;


            Person man = new Person();
            Person woman = new Person("Liza", new DateTime(2024, 08, 08));
            Console.WriteLine(man.Name);
            Console.WriteLine(man.BirthTime);


            man.Age();
            woman.Age();

            Person newPerson = Person.Input();
            Console.WriteLine(newPerson.Name);
            int age = newPerson.Age();
            newPerson.ChangeName("Bob");

            Console.WriteLine(man.BirthTime.ToLongDateString());

            Console.WriteLine(man.ToString());

            if (man == woman)
            {
                Console.WriteLine("The same name");
            }
            else
            {
                Console.WriteLine("Not same names");
            }

            man.Output();
            woman.Output();

            Console.WriteLine("________________________________________________________");

            Person[] people = new Person[countOfPersons];


            for (int i = 0; i < countOfPersons; i++)
            {
                Console.WriteLine(($"Enter a name of {i + 1} person"));
                string name = Console.ReadLine();

                Console.WriteLine(($"Enter a birth day of {i + 1} person"));
                DateTime birthDay = Convert.ToDateTime(Console.ReadLine());

                people[i] = new Person(name, birthDay);
                Console.WriteLine(people[i].Age());


                people[i].Output();
                Console.WriteLine("____");

                if (people[i].Age() <= veryYoung)
                {
                    Console.WriteLine($"Enter a new name of person {i + 1}:");
                    people[i].ChangeName("Very Young");
                }
                Console.WriteLine("________________________________________________________");
            }

            for (int i = 0; i < countOfPersons; i++)
            {
                people[i].Output();
            }
            Console.WriteLine("__________");

            for (int i = 0; i < countOfPersons - 1; i++)
            {
                for (int j = i + 1; j < countOfPersons; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"{people[i].ToString()} have the same name with: {people[j].ToString()}");
                        Console.WriteLine("________________________");
                    }
                }
            }
            Console.WriteLine("________________________________________________________");
        }
    }
}
