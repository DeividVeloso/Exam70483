using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Make a StringBuilder holding the ABCs.
            //StringBuilder letters = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //// This one holds the next line of letters.
            //StringBuilder line = new StringBuilder();
            //// Create the result StringBuilder.
            //StringBuilder result = new StringBuilder();
            //// Loop over the letters.
            //for (int i = 0; i < 26; i++)
            //{
            //    // Add the next letter to line.
            //    line.Append(letters[i]);
            //    // Add line to the result.
            //    result.AppendLine(line.ToString());
            //}
            //Console.WriteLine(line);

            //Console.WriteLine(result);
            // Display the result.
            // stringBuilderTextBox.Text = result.ToString();
            //stringBuilderTextBox.Select(0, 0);

            int i = 163;
            Console.WriteLine(string.Format("{0} = {1,4} or 0x{2:X}", (char)i, i, i));

            string text = string.Format("{1} {4} {2} {1} {3}","who", "I", "therefore", "am", "think");
            Console.WriteLine(text);

            Console.WriteLine(string.Format("It is now {1:HH} o'clock", DateTime.Now, DateTime.Now));
        }
    }
}
