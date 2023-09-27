using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork2
{
    public enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402
    }

    class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void Info()
            {
                Console.WriteLine($"Dog name: {name}, mark: {mark}, age: {age}");
            }

            public override string ToString()
            {
                return string.Format($"Dog name: {name}, mark: {mark}, age: {age}", name, mark, age);
            }

        }

            static void Main(string[] args)
            {
            Console.WriteLine("______________________________");
            Console.WriteLine("Task 1\n");
            Console.WriteLine("Please, enter a first float number:");

            float firstNumber = Single.Parse(Console.ReadLine());
            Console.WriteLine($"First number is: {firstNumber}\n");

            Console.WriteLine("Please, enter a second number:");
            float secondNumber = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Second number is: {secondNumber}\n");

            Console.WriteLine("Please, enter a third number:");
            string? thirdNumberString = Console.ReadLine();
            float thirdNumber = float.Parse(thirdNumberString);
            Console.WriteLine($"Third number is: {thirdNumber}\n");

            bool inRangeFirst = firstNumber >= -5 & firstNumber <= 5 ? true : false;
            bool inRangeSecond = secondNumber >= -5 & secondNumber <= 5 ? true : false;
            bool inRangeThird = thirdNumber >= -5 & thirdNumber <= 5 ? true : false;
            bool result = (inRangeFirst == inRangeSecond == inRangeFirst) ? true : false;

            Console.WriteLine($"Are the all numbers in range? - {result}");

            Console.WriteLine("______________________________");


            Console.WriteLine("Task 2\n");

            int size = 3;
            int[] array = new int[size];

            Console.WriteLine("Enter 3 integer numbers (after each, pls press \"Enter\"):");

            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int arrayMin(int[] array, int size)
            {
                int min = array[0];

                for (int i = 0; i < size; i++)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
                return min;
            }

            int arrayMax(int[] array, int size)
            {
                int max = array[size - 1];

                for (int i = 0; i < size; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                }
                return max;
            }

            Console.WriteLine("Min value is:" + arrayMin(array, size));
            Console.WriteLine("Max value is:" + arrayMax(array, size));

            Console.WriteLine("______________________________");

            Console.WriteLine("Task 3\n");

            Console.WriteLine("You must do some mistake!\nEnter a number of mistake you want: 400, 401 or 402");
            int typeOfErrors = Convert.ToInt32(Console.ReadLine());

            switch (typeOfErrors)
            {
                case 400:
                    Console.WriteLine("Bad Request");
                    break;
                case 401:
                    Console.WriteLine("Unauthorized");
                    break;
                case 402:
                    Console.WriteLine("Payment Required");
                    break;
                default:
                    Console.WriteLine("who knows who knows what kind of mistake it is...\n");
                    break;
            }

            Console.WriteLine("______________________________");

            Console.WriteLine("You must do some mistake again!\nEnter a number of mistake you want: 400, 401 or 402");
            int typeOfError = Convert.ToInt32(Console.ReadLine());

            string ErrorsType(int typeOfError) => typeOfErrors switch
            {
                400 => "Bad Request",
                401 => "Unauthorized",
                402 => "Paymant Required",
                _ => "No case availabe"
            };
            Console.WriteLine(ErrorsType(typeOfError));

            Console.WriteLine("______________________________");

            Console.WriteLine("Task 4\n");

            Dog dog = new Dog();

            dog.name = "Bobik";
            dog.mark = "Dvoryanin";
            dog.age = 1;

            dog.Info();
            Console.WriteLine(dog.ToString());

            Console.WriteLine("______________________________");

        }
    }
}
