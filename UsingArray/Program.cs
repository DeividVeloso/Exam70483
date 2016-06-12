﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2D = new string[3, 2] 
            { 
                { "one", "two"}, 
                { "three", "four"},
                { "five", "six"} 
            };
            Console.WriteLine(array2D[0, 0]); // one
            Console.WriteLine(array2D[0, 1]); // two
            Console.WriteLine(array2D[1, 0]); // three
            Console.WriteLine(array2D[1, 1]); // four
            Console.WriteLine(array2D[2, 0]); // five
            Console.WriteLine(array2D[2, 1]); // six
        }
    }
}
