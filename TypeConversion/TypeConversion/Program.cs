using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte b = 1;
            int i = b;
            Console.WriteLine(i);*/

            //You cannot convert type int to type byte but you can do byte to int. What needs to happen is called a cast
            //casting below

            /*int i = 1;
            byte b = (byte) i;
            Console.WriteLine(b);*/

            //You can only store 255 in a byte, so inputting 1000 will result in data loss, that is why C# wants you to apply casting
            /*int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);*/

            /*var number = "1234";
            //int i = (int) number; You cannot cast a number to an integer
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);*/


            //try block will catch the exception because the value assigned to our byte causes an overflow
            try
            {
                /*var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);*/

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion fail. Number cannot be converted to a byte.");
            }


        }
    }
}
