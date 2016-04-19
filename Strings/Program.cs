using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] delimiters = { ',', '-' };
            string values = "12-21,,33-17,929";
            string[] fields = values.Split(delimiters,
            StringSplitOptions.RemoveEmptyEntries);

            string[] weekdays =
                                {
                                "Monday", "Tuesday", "Wednesday",
                                "Thursday", "Friday", "Saturday",
                                "Sunday","xoxo/xxxx/zzzz"
                                };
            string allDays = string.Join("^", weekdays);

            //string text = "ABACATE";


            //int[] counts = new int[26];
            //text = text.ToUpper();
            //foreach (char ch in text)
            //{
            //    if (char.IsLetter(ch))
            //    {
            //        int index = (int)ch - (int)'A';
            //        counts[index]++;
            //    }
            //}

            //char[] characters = text.ToCharArray();
            //for (int i = 0; i < characters.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        characters[i] = char.ToUpper(characters[i]);
            //    }
            //    else
            //    {
            //        characters[i] = char.ToLower(characters[i]);
            //    }

            //    text = new string(characters);
            //}

            //Console.WriteLine(text);
        }
    }
}
