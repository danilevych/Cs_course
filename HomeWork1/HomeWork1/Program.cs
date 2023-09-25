using System;
using System.Transactions;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a value (side a square):");
            int a = Convert.ToInt32(Console.ReadLine());
            int squareArea = a * a;
            int squarePerimeter = 2 * (a + a);

            Console.WriteLine($"Results:\n Side of area {a},\n square area is: {squareArea},\n square perimeter is: {squarePerimeter}");


            Console.WriteLine("___________________________");


            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is: {name}\n" +
                $"Your age is: {age}");


            Console.WriteLine("___________________________");


            Console.WriteLine("Enter a radius of a circle in a double format:");
            double r = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;
            double length = 2 * pi * r;
            double area = pi * Math.Pow(r, 2);
            //double volume = 4/3 * pi * r * r * r;
            double volume = 4.0 / 3.0 * pi * Math.Pow(r, 3);

            Console.WriteLine($"Results:\n" +
                $"Radius: {r}\n" +
                $"Area: {area:F4}\n" +
                $"Volume: {volume:F4}");


            Console.WriteLine("___________________________");



            Console.ReadKey();
        }
    }
}


