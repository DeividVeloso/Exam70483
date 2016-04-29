using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCoalescingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? z = 2;
            int y = x ?? z ?? -1;
            /*
             Verifica se x é diferente de null se for coloca valor de x
             Senão z e se z for null coloca o próximo valor
             */

            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
