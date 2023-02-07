using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Alphabet
    {
        public void CheckVowel()
        {
            Console.WriteLine("Enter the alphabet");
            char alphabet = Convert.ToChar(Console.ReadLine());
            if (alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet=='U' || alphabet=='a' || alphabet=='e' || alphabet=='i' || alphabet=='o' || alphabet=='u')
                 Console.WriteLine("The Alphabet is vowel " +alphabet);
            else
                Console.WriteLine("The alphabet is Consont" +alphabet);

        }
    }
}
