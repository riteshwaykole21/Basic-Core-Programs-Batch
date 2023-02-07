using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwappingNumber
    {
        public void Swap()
        {
            Console.WriteLine("Enter The First Number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number :");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + SecondNumber;
            SecondNumber = firstNumber - SecondNumber;
            firstNumber = firstNumber - SecondNumber;
            Console.WriteLine("After Swapping two Number : First Number Is=" + firstNumber + "and second number is " +SecondNumber);
        }
    }
}
