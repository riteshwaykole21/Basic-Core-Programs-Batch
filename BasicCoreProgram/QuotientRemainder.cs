using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientRemainder
    {
        public void Division()
        {
            Console.WriteLine("Enter The Divident");
            double divident = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Divisor");
            double divisor = Convert.ToDouble(Console.ReadLine());
            double quotient = divident / divisor;
            double remainder = divident % divisor;
            Console.WriteLine("Quotient is :" + quotient);
            Console.WriteLine("Reaminder is : " + remainder);
        }
    }
}
