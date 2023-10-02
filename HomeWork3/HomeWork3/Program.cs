using System;

namespace Homework3
{
    public class Program
    {
        enum Mounthf
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,

        }
        static void Main(string[] args)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter some string:");
            string someString = Console.ReadLine();

            int counter = 0;

            foreach (char arg in someString)
            {
                counter += 1;
            }

            Console.WriteLine(counter);
            Console.WriteLine("________________________________");

            Console.WriteLine("Task 2");
            Console.WriteLine("Please enter the number of mounth:");
            int mounth = Convert.ToInt32(Console.ReadLine());

            string GuessMounth(int Mounth) => mounth switch
            {
                1 => "31",
                2 => "28",
                3 => "31",
                4 => "30",
                5 => "31",
                6 => "30",
                7 => "31",
                8 => "31",
                9 => "30",
                10 => "31",
                11 => "30",
                12 => "31",
                _ => "No case availabe"
            };
            Console.WriteLine(GuessMounth(mounth));

            Console.WriteLine("________________________________");
            Console.WriteLine("Task 3");

            int[] array = new int[10];
            int sum = 0;
            int product = 1;
            bool flag = false;

            for (int i = 0, j = 1; i < array.Length; i++, j++)
            {
                Console.WriteLine($"Please, print a  {j} number:");
                array[i] = Convert.ToInt32(Console.ReadLine());

                if (array[i] < 0 & i < 5)
                {
                    flag = true;
                }
            }

            sum = array.Skip(0).Take(5).Sum();

            foreach (int i in array.Skip(5).Take(5))
            {
                product *= i;
            }

            int result = flag ? product : sum;
            Console.WriteLine(result);

            Console.WriteLine("________________________________");

        }
    }
};