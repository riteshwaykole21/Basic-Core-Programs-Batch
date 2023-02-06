using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        int countHead = 0;
        int countTail = 0;
        public void Coin()
        {
            Console.WriteLine("Enter The Number Of Times To Flip the Coin");
            int flipNum = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < flipNum; i++)
            {
                double numCheck = random.NextDouble();
                if (numCheck > 0.5)
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("Count Of Head :"  +countHead);
            Console.WriteLine("Count Of Tail :" +countTail);
            float headPercentage = (float)countHead / 100;
            float tailPercentage = (float)countTail / countHead * 100;
            Console.WriteLine("Percentage of Head :" + headPercentage);
            Console.WriteLine("percentage of Tail :" + tailPercentage);
        }
    }
}
