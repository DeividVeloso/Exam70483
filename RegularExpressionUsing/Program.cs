using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

            string value = "My Custom Value";
            foreach (char c in value)
                Console.WriteLine(c);

            foreach (string word in "My sentence separated by spaces".Split(' ')) 
            {
                Console.WriteLine(word);
            }
        }
    }
}
