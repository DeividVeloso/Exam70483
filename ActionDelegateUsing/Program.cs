using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            calc(3, 4); // Displays 7
        }
    }
}
