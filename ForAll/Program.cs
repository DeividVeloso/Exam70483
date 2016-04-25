using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);
            var parallelResult = numbers.AsParallel().WithDegreeOfParallelism(6)
            .Where(i => i % 2 == 0);

            parallelResult.ForAll(e => Console.WriteLine(e));

            /*
             Usando o for no Parallel 
             */
        }
    }
}
