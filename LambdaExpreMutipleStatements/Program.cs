using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpreMutipleStatements
{
    class Program
    {

        public delegate int Calculate(int x, int y, int z = 0);
        static void Main(string[] args)
        {
            Calculate calc = (x, y, z) =>
                                    {
                                        Console.WriteLine("Adding numbers");
                                        Console.WriteLine("Result numbers {0}", x + y);

                                        return x + y;

                                    };

            int result = calc(3, 4);
        }
    }
}
