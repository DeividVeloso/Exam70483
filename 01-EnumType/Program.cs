using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            //var obj = new EnumExample();


            switch (EnumExample.Days.Friday)
            {
                case EnumExample.Days.None:
                    break;
                case EnumExample.Days.Sunday:
                    break;
                case EnumExample.Days.Monday:
                    break;
                case EnumExample.Days.Tuesday:
                    break;
                case EnumExample.Days.Wednesday:
                    break;
                case EnumExample.Days.Thursday:
                    break;
                case EnumExample.Days.Friday:
                    Console.WriteLine(EnumExample.Days.Friday);
                    break;
                case EnumExample.Days.Saturday:
                    break;
                default:
                    break;
            }      
        }
    }
}
