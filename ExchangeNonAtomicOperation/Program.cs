using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExchangeNonAtomicOperation
{
    class Program
    {
        static int value = 1;
        public static void Main()
        {
            Task t1 = Task.Run(() =>
            {

                if (value == 1)
                {
                    // Removing the following line will change the output
                    //Thread.Sleep(1000);
                    value = 2;
                }
            });
            Task t2 = Task.Run(() =>
            {
                value = 3;
            });
            Task.WaitAll(t1, t2);
            Console.WriteLine(value); // Displays 2
        }
    }
}
