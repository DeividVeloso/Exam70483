using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int condition = 10;
            // switch statement syntax
            switch (condition)
            {
                case 1:
                    Console.WriteLine("statement1;");
                    break;
                case 2:
                    Console.WriteLine("statement2;");
                    break;
                case 3:
                    Console.WriteLine("statement3;");
                    break;
                default:
                    Console.WriteLine("statementDefaut;");
                    break;
            }
        }
    }
}
