using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //switch (i)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Case 1");
            //            goto case 2;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("Case 2");
            //            break;
            //        }
            //}


            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index += 2)
            {
                Console.WriteLine(values[index]);
            }
        }
    }
}
