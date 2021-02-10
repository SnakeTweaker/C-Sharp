using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 2;
            var number = 2;
            //C# will automatically detect the data type for "var" usage
            //int count = 10;
            var count = 10;

            //if you are declaring a float, you must remember to include "f" or else C# will be treated as a double
            //float totalPrice = 29.99f;
            var totalPrice = 29.99f;

            //char character = 'A';
            var character = 'A';

            //string firstName = "Christian";
            var firstName = "Christian";

            //bool isWorking = true;
            var isWorking = true;
            //You can use code snippets to make writing code easier "cw" for Console.WriteLine
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

        }
    }
}
