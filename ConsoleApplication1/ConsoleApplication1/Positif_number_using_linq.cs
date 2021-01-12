using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // data source
            int[] numbers = { 1, 2, -8, 4, 10, -6, 7, 8 };

            //execute methode
            GetpositifNumber(numbers);
            
            //keyboard run

            Console.ReadKey();
        }
        static void GetpositifNumber(int[] array)
        {
            //// query expression
            var numQuery =
            from num in array
            where (num > 0)
            select num;
            // query execution in foreach
            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
