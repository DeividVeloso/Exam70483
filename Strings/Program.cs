using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                string indent = new string(' ', 4 * i);
                Console.WriteLine(indent + i.ToString());
            }
        }
    }
}
