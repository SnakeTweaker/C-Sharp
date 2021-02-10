using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args) //all primitive types maps to a type in .NET framework
        {
            
            var firstName = "CJ";
            var lastName = "Busca";
            //String lastName = "Busca"; 
            //string myName

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {1} {0}", firstName, lastName);

            Console.WriteLine(myFullName);

            //. methods
            // This is an array of names
            var names = new string[3] { "John" , "Jack" , "Jim" };
            var formattedNames = String.Join(",", names);
            Console.WriteLine(formattedNames);

            //@ is a verbatim line!
            var text = @"Hi John Look into the following paths
C:\folder1\folder2
C:\folder3\folder4";
            Console.WriteLine(text);

            //strings are classes... We can create strings in C# or in .NET the difference is when you are using the 
            //String class from .NET you must import it from the proper namespace... using System; string and String are not different


        }
    }
}
