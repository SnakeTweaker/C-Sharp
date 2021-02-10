using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, 
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            //converting an enum to and from an integer

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //converting strings-enums

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            //parsing is converting a string to a different type

            var shippingMethod = (ShippingMethod) Enum.Parse(typeof (ShippingMethod), methodName);
        }
    }
}
