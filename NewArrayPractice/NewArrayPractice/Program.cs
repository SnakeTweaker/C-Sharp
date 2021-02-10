using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example of string concatenation 

            var firstName = "CJ ";
            var lastName = "Busca";

            string name = string.Format("{0}{1}", firstName, lastName);

            Console.WriteLine(name);
            

            //You can create a string from combining all elements of that array using a seperator

            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);

            Console.WriteLine(numbers);
        }
    }
}
