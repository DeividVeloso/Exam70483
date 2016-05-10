using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncWithLambdaAnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Func<int, int, int> subFunc = (x, y) => x - y;
            Console.WriteLine(addFunc(2, 3));
            Console.WriteLine(subFunc(2, 3));

        }
    }
}
