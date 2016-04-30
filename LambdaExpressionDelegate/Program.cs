using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.UseDelegate();
        }

        public delegate int Calculate(int x, int y);

        public void UseDelegate()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Displays 7

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
