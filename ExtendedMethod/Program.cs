using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedMethod
{

    public static class myExtendedMehods
    {
        public static int square(this int num, int num2)
        {
            int result = 0;
            result = num * num2;
            return result;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int myNum = 3;
            myNum = myNum.square(9);

            Console.WriteLine(myNum.ToString());
        }
    }
}
