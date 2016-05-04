using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EnvironmentFailFastUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
                if (i == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }

        /*
         Para a aplicação, não deixa executar o finally e cria um LOG no Log de enventos do Windows.
         */
    }
}
