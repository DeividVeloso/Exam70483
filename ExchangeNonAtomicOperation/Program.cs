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

                //if (value == 1)
                //{
                // Removing the following line will change the output
                //Thread.Sleep(1000);

                //value = 2;

                /*
                  1 - Pega o valor na memoria
                  2 - Coloca o novo valor
                  3 - Verifica se o valor da memoria é igual a 1
                     if (value == 1)
                        value = 2
                 */

                Interlocked.CompareExchange(ref value, 2, 1);

                //}
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
