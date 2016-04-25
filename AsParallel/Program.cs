using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0,100);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();

            for (int i = 0; i < parallelResult.Length; i++)
            {
                Console.WriteLine(parallelResult[i].ToString());
            }
        }
    }
}
