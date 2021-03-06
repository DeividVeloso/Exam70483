﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AggregateExceptionUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));

               // Console.ReadLine();
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions",
                e.InnerExceptions.Count);
            }
        }

        public static bool IsEven(int i)
        {
            Thread.Sleep(1000);
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
