using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, -8, 10, 7, -6, 8 };
            var result = GetpositifNumber(numbers);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static char[] GetpositifNumber(int[] array)
        {

            return array.Where(item => item >= 0)
                   .SelectMany(item => item.ToString().ToCharArray())
                   .ToArray();
        }
    }
}
