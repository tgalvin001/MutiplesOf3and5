using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_and_5
{

    class Program
    {
        public static long SumOfMultiples(long j)
        {
            long sum = 0;
            for(long i = 0; i < j; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to test: ");
            Console.WriteLine(SumOfMultiples(Convert.ToInt64(Console.ReadLine())));
            

            Console.WriteLine(Math.Exp(80));
            Console.ReadKey();
        }
    }
}
