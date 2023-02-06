using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the Year You Want To Check For Leap Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("it is a Leap year");
            }
            else
                Console.WriteLine("it is not a Leap Year ");
        }
    }
}
