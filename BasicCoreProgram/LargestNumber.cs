using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestNumber
    {
        public void AmongThree()
        {
            Console.WriteLine("Enter The First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            int Third = Convert.ToInt32(Console.ReadLine());
            if(First >Second && First > Third)
                Console.WriteLine("{0} First Number Is Greter Than Second And Third" ,First);
            else if(Second >Third && Second >First)
                Console.WriteLine("{0}Second Number Is Greter Than First and Third" ,Second);
            else Console.WriteLine("{0} Third Number Is greter than Second & first",Third);
        }
    }
}
