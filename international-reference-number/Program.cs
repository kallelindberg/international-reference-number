using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new ReferenceNumber("2348236");

            number1.CreateReferenceNumber();
            if (number1.CheckReferenceNumber() == true)
            {
                Console.WriteLine(number1.Output + " OK!");
            }
            else
            {
                Console.WriteLine(number1.Output + " Bad input :(");
            }

            Console.ReadKey();
        }
    }
}
