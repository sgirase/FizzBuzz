using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set parameters for extended fizz buzz. Just add as many tuples to the list as you may like
           var tupleList = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(3, "Fizz" ),
                new Tuple<int, string>(5, "Buzz" ),
                new Tuple<int, string>(7, "Hello" )
            };
            Console.WriteLine(FizzBuzzExtended.PrintFizzBuzz(tupleList, 1, 100));
            Console.ReadKey();

            FizzBuzz objFizzBuzz = new FizzBuzz(1, 100, "Fizz", "Buzz");
            Console.WriteLine(objFizzBuzz.PrintFizzBuzz());
            Console.ReadKey();
        }

        public static void PrintFizzBuzz(int minRange, int maxRange, string fizz, string buzz)
        {
            string output = string.Empty;
            for (int i = minRange; i <= maxRange; i++)
            {
                output = i.ToString();
                if (i % 3 == 0) output += " " + fizz;
                if (i % 5 == 0) output += " "+buzz;
                Console.WriteLine(output);
            }
        }
    }
}
