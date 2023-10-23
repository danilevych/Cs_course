using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lendth = 6;
            
            string path = @"C:\Users\User\source\repos\Cs_course\HomeWork9\shapes.txt";

            List<Shape> items = new List<Shape>(lendth);

            items.Add(new Circle(2, "a"));
            items.Add(new Circle(4, "b"));
            items.Add(new Square(3, "A"));
            items.Add(new Circle(6, "c"));
            items.Add(new Circle(8, "d"));
            items.Add(new Square(5, "B"));

            

            using (StreamWriter newFile = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                IEnumerable<Shape> shapes = from shape in items
                                            where shape.Area() > 10 & shape.Area() < 100
                                            select shape;

                foreach (Shape shape in shapes)
                {
                    newFile.WriteLine(shape.Name);
                }
            }


            foreach (Shape shape in items)
            {
                if (shape.Name.Contains("a"))
                {
                    Console.WriteLine(shape.Name);
                }
            }

            //Task 3
            using (StreamWriter newFile = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                IEnumerable<Shape> shapes = from shape in items
                                            where shape.Name.Contains("a")
                                            select shape;

                foreach (Shape shape in shapes)
                {
                    newFile.WriteLine($" This name of Shape contains \"a\" - {shape.Name}");
                }
            }

            //Task 4

            //IEnumerable<Shape> newList = items.Where(x => x.Perimeter() > 5).ToList();
            //foreach (Shape shape in newList)
            //{
            //    Console.WriteLine(shape.Perimeter());
            //}


            items.RemoveAll(x => x.Perimeter() < 5); 

            foreach (Shape shape in items)
            {
                Console.WriteLine(shape.Perimeter());
            }
        }
    }
}