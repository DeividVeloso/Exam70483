using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterlockedUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });

            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);

            up.Wait();

            Console.WriteLine(n);

            Console.ReadKey();

            /*
                Classe Interlocked garanti a Atomicidade, não interfere entre as Threads, 
               ele garante que nenhuma thread vai interferir no valor referenciado até terminar a operação
             * Interlocked guarantees that the increment and decrement operations are executed atomically. 
             * No other thread will see any intermediate results.
             */
        }
    }
}
