using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // example of using conditional operator
            Random rnd = new Random();
            int num = 0;
            num = rnd.Next(100); // generate a random number between 1 and 100
            // and assign to num
            // if the value in num mod 2 is equal to zero, the operator will return
            // the string even indicating an even number, otherwise it will return
            // the string false
            string type = num % 2 == 0 ? "even" : "odd";

            Console.WriteLine(type);
            Console.ReadLine();
        }
    }
}
