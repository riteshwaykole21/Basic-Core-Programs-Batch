using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 :FlipCoin \n 2 : Leap Year\n 3:Power Of Two\n 4:Harmonic Number\n 5:Calculatin Factor\n 6:Quotient Number\n 7:Swap two Number\n 8: Even Odd Number ");
            Console.WriteLine("Enter a Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.Coin();
                    break;
                case 2:
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;
                case 3:
                    PowerOfTwo Num = new PowerOfTwo();
                    Num.Power();
                    break;
                case 4:
                    HarmonicNumber Numb = new HarmonicNumber();
                    Numb.Harmonic();
                    break;
                case 5:
                    Calculation Numbe = new Calculation();
                    Numbe.Factor();
                    break;
                case 6:
                    QuotientRemainder remainder = new QuotientRemainder();
                    remainder.Division();
                    break;
                case 7:
                    SwappingNumber Swaping = new SwappingNumber();
                    Swaping.Swap();
                    break;
                case 8:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.CheckEvenOdd();
                    break;
            }
            Console.ReadLine();
        }
    }
}
