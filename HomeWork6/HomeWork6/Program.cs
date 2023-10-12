using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork6
{
    class Program
    {
        public static List<int> ReadNumber(int start, int end)
        {
            const int capasity = 3;

            List<int> sequenceOfNumbers = new List<int>();


            for (int i = 0; i < capasity; i++)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);
                    ArgumentOutOfRangeException.ThrowIfGreaterThan(number, 42);
                    ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(number, start);

                    start = number;
                    
                    sequenceOfNumbers.Add(number);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }

            foreach (int value in sequenceOfNumbers)
            {
                Console.Write($"{value} ");
            }

            return sequenceOfNumbers;

        }
        static void Main(string[] args)
        {

            try
            {
                int start = Convert.ToInt32(Console.ReadLine());
                int end = Convert.ToInt32(Console.ReadLine());

                if (end < start + 10)
                {
                    throw new СheckTheValidityOfInputParametersExeption("The START must be less than the END by at least 10");
                }
                ReadNumber(start, end);
            }
            catch (СheckTheValidityOfInputParametersExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex )
            { 
                Console.WriteLine("Uxpected exception");
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
