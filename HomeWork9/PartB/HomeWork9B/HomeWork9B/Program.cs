using System;

namespace HomeWork9B
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\User\source\repos\Cs_course\HomeWork9\PartB\HomeWork9B\lorem.txt";
            

            try
            {
                string[] lines = File.ReadAllLines(file);
                Console.WriteLine(String.Join(Environment.NewLine, lines));

                IEnumerable<int> count = from line in lines
                                         select line.Length;

                foreach (int i in count)
                { Console.WriteLine(i.ToString()); }

                Console.WriteLine($"The longest line have {count.Max()} symbols, the shortest -  {count.Min()}");


                //IEnumerable<string> list = from line in lines
                //                           where line.Contains("var")
                //                           select line;
                IEnumerable<string> list = lines.Where(line => line.Contains("var"));

                foreach (string i in list)
                { Console.WriteLine(i.ToString()); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
