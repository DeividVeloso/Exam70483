using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count up to 10 in increments of 3 -- Tabuada
            for (int counter = 0; counter <= 30; counter += 3)
            {
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
