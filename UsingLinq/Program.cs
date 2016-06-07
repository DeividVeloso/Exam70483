using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] data = { 1, 2, 5, 8, 11 };
            ////var result = from d in data
            ////             where d % 2 == 0
            ////             select d;
            //var result = data.Where(d => d % 2 == 0);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] data = { 1, 2, 5, 8, 11 };
            //var result = from d in data
            //             select d;
            //Console.WriteLine(string.Join(", ", result)); // Displays 1, 2, 5, 8, 11

            //int[] data = { 1, 2, 5, 8, 11 };
            //var result = from d in data
            //             where d > 5
            //             orderby d descending
            //             select d;
            //Console.WriteLine(string.Join(", ", result)); //

            int[] data1 = { 1, 2, 5 };
            int[] data2 = { 2, 4, 6 };
            var result = from d1 in data1
                         from d2 in data2
                         select d1 * d2;
            Console.WriteLine(string.Join(", ", result)); // Displays 2, 4, 6, 4, 8, 12, 10, 20, 30
        }
    }
}
