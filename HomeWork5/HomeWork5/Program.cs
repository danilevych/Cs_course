using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lenght = 3;
            Console.WriteLine("____________");

            Programmer developer = new Programmer("c++++");
            Console.WriteLine(developer.Tool);
            developer.Create();
            developer.Destroy();

            Console.WriteLine("____________");

            Builder builder = new Builder("I can something");
            Console.WriteLine(builder.Tool);
            builder.Create();
            builder.Destroy();

            Console.WriteLine("____________");

            List<IDeveloper> people = new List<IDeveloper>();

            for (int i = 0; i < lenght; i++)
            {
                people.Add(developer);
                people.Add(builder);
            }

            foreach (IDeveloper developers in people)
            {
                developers.Create();
                developers.Destroy();
                Console.WriteLine(developers.Tool);

            }

            people.Sort();

            foreach (IDeveloper developers in people)
            {
                Console.WriteLine(developers);
            }

            Console.WriteLine("____________");

            Dictionary<uint, string> dict = new Dictionary<uint, string>();

            dict.Add(1, "Boris");
            dict.Add(2, "Vilgelm");
            dict.Add(3, "Olga");
            dict.Add(4, "Simona");
            dict.Add(5, "Lev");
            dict.Add(6, "Stepan");
            dict.Add(7, "Zoya");

            foreach (KeyValuePair<uint, string> kvp in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("Enter ID of person (1 to 7):");
            uint id = Convert.ToUInt32(Console.ReadLine());
            bool checkKey = true;

            foreach (KeyValuePair<uint, string> kvp in dict)
            {
                if (kvp.Key == id)
                {
                    Console.WriteLine($"{kvp.Value}");
                    checkKey = false;
                }
            }
            if (checkKey)
            {
                Console.WriteLine("Something goes wrong..");
            }
        }
    }
}