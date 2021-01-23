using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //practicing format strings
            Console.WriteLine("This is a list of min and max values for primitive data types in C#. The left most value is min, right is max.");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);
            //Console.WriteLine("{0} {1}", bool.MinValue, bool.MaxValue); No min, no max
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("{0} {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", short.MinValue, short.MaxValue);

            const float Pi = 3.14f;
            //Pi = 1; -- This cannot be modified because it is a constant

        }
    }
}
