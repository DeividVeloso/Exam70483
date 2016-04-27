using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadedProblemUsing
{
    class Program
    {
        static void Main(string[] args)
        {

            var t1 = Task.Run(() => Thread1());
            var t2 = Task.Run(() => Thread2());

            // t1.Wait();
            t2.Wait();
        }

        private static int _flag = 0;
        private static int _value = 0;

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }
        public static void Thread2()
        {
            //Thread.Sleep(2000);
            if (_flag == 1)
                Console.WriteLine(_value);
        }

    }
}
