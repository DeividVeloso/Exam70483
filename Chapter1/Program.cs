﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = false;
            t.Start();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Main thread: Do some work.");
            //    Thread.Sleep(0);
            //}

            //t.Join();

            //Console.ReadLine();
        }
    }
}
