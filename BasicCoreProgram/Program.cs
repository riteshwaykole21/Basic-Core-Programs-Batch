﻿using System;
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
            Console.WriteLine("1 :FlipCoin \n 2 : Leap Year\n 3:Power Of Two ");
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
            }
            Console.ReadLine();
        }
    }
}
