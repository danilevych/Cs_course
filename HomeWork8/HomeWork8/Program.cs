using System.Data;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lendth = 5;
            string name;
            int partOfShape;

            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Enter a data of 5 different shapes ( number in first line and string in a second line ): ");

            for (int i = 0; i < lendth; i++)
            {
                partOfShape = Convert.ToInt32(Console.ReadLine());
                name = Console.ReadLine();

                shapes.Add(new Circle(partOfShape, name));
                shapes.Add(new Square(partOfShape, name));
            }


            //Task A
            try
            {
                foreach (Shape shape in shapes)
                {
                    Console.WriteLine($"Name: {shape.Name}, Perimeter:  {shape.Perimeter():F1}, Area: {shape.Area():F1}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Task B

            Console.WriteLine($"The largest perimeter have {shapes.Max().Name}");


            //Task 3

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Start area: {shape.Area():F1}");
            }

            List<Shape> SortedList = shapes.OrderBy(shape => shape.Area()).ToList();

            foreach (Shape shape in SortedList)
            {
                Console.WriteLine($"List sorted by area: {shape.Area():F1}");
            }

        }
    }
}