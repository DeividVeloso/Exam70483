using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Multicast();
        }

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
        public delegate void Del();
        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            d();
        }

    }
}
