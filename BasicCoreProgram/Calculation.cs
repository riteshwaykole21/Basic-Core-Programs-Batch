using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Calculation
    {
        public void Factor()
        {
            Console.WriteLine("Enter The Number To Calculate Prime Factorization");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
