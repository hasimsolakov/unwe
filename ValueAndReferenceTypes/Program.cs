using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            Console.WriteLine("num1 before method call: " + num1);
            PrintNumberIncremented(num1);
            Console.WriteLine("num1 after method call: " + num1);
            int myNumber = 30;
            Console.WriteLine("myNumber before method call: " + myNumber);
            PrintNumberIncremented(myNumber);
            Console.WriteLine("myNumber after method call: " + myNumber);

            GetSum(3, 5, 6, 8);
        }

        static void PrintNumberIncremented(int num1)
        {
            num1 += 10;
            Console.WriteLine("In method: " + num1);
        }

        static int GetSum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
