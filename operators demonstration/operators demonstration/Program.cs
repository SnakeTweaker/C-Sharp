using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_demonstration
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var a = 1;
                var b = 2;
                var c = 3;

                //Console.WriteLine(a + b);
                // Console.WriteLine((float)a / (float)b); //casting the ints as floats for accuracy

                Console.WriteLine(a + b * c); //C# gives priority to PEMDAS
                Console.WriteLine((a + b) * c);
                Console.WriteLine(a == b); //The result pf a comparison expression is always a boolean (see example 5)
                Console.WriteLine(a != b);
                Console.WriteLine(!(a != b)); //2 negs always equal 1 positive always inverse with one positive
                Console.WriteLine(c > b && c > a);
                Console.WriteLine(c > b && c== a);
                Console.WriteLine(c > b || c > a);
                Console.WriteLine(!(c > b || c > a)); //or is double verticle line
            }

        }
    }
}
