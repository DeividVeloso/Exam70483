using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal[] loanAmounts = { 30m, 20m, 50m, 100m, 5m };

            IEnumerable<decimal> loanquery = from amount in loanAmounts
                                             where amount % 2 == 0
                                             orderby amount ascending
                                             select  amount;

            foreach (var item in loanquery)
            {
                Console.WriteLine(item);    
            }
            
        }
    }
}
