using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Double number = 150.33333;

            string MyString = number.ToString("0.##;-0.##");
            string MyString2 = number.ToString("+#;-#;0");

   
            Console.WriteLine(MyString);
            Console.WriteLine(MyString2);
        }
    }
}
