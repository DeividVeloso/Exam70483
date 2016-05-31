using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStopWatchProfiling
{
    class Program
    {
        const int numberOfIterations = 100000;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Algorithm1 using StringBuilder");
            Algorithm1();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Reset();


            sw.Start();
            Console.WriteLine("Algorithm2 using +");
            Algorithm2();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Reset();

            Console.WriteLine("Ready…");
            Console.ReadLine();
        }

        private static void Algorithm1()
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < numberOfIterations; x++)
            {
                sb.Append('a');
            }
            string result = sb.ToString();
        }

        private static void Algorithm2()
        {
            string result = "";
            for (int x = 0; x < numberOfIterations; x++)
            {
                result += 'a';
            }
        }

    }
}
