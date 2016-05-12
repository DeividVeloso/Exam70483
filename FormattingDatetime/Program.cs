using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingDatetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2013, 4, 22);
            CultureInfo provider = new CultureInfo("pt-BR"); 
            Console.WriteLine(d.ToString("d", provider)); // Displays 4/22/2013
            Console.WriteLine(d.ToString("D", provider)); // Displays Monday, April 22, 2013
            Console.WriteLine(d.ToString("M", provider)); // Displays April 22
        }
    }
}
