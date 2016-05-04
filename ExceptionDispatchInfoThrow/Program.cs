using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDispatchInfoThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionDispatchInfo possibleException = null;
            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }
            if (possibleException != null)
            {
                possibleException.Throw();
            }

            /*
                Você pode usar exibir thrown exception do erro em outra classe e mostra junto com outro exception
             * 
             */
        }
    }
}
