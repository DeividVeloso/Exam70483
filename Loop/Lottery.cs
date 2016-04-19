using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Lottery
    {
        static void Main(string[] args)
        {

            int[] picked = new int[6];

            Random rnd = new Random();

            Console.WriteLine("Your lotto numbers are:");

            for (int select = 0; select < 6; select++)
            {
                if (select != -1)
                {

                    picked[select] = rnd.Next(49);

                    if (picked[select] != picked[select])
                    {
                        Console.Write(" " + picked[select] + " ");
                    }

                }

            }
        }
    }
}
