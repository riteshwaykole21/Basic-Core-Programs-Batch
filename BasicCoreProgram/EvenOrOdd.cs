using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenOrOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter The Number Is Even Or Odd ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                if (number % 2 == 0)
                   Console.WriteLine("{0} This The Even Number ", number);
                else
                    Console.WriteLine("{0} This Is The Odd Number ", number);
            }
            else
                Console.WriteLine("Enter The Positive Number");
        }
    }
}
