using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter The Last Harmonic Number");
            double num = Convert.ToDouble(Console.ReadLine());
            double harmonicSum = 0;
            for (double i = 1 ; i <= num; i++)
            {
                Console.WriteLine("1/" + i + "=" +(1 / i));
                harmonicSum +=(1 / i);
            }
            Console.WriteLine("The Sum Of Harmonic Number is :"+ harmonicSum);
        }
    }
}
