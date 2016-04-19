using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            string quantityTextBox = "10";
            try
            {
                quantity = int.Parse(quantityTextBox);
            }
            catch
            {
                quantity = 1;
            }

            int weight;
            string weightTextBox = "70";

            if (int.TryParse(weightTextBox, out weight)) weight = 10;

            DateTime.Parse("3:45 PM April 1, 2014").ToString();
            DateTime.Parse("1 apr 2014 15:45").ToString();
            DateTime.Parse("15:45 4/1/14").ToString();
            DateTime.Parse("3:45pm 4.1.14").ToString();
            DateTime.Parse("15:04 26/03/2016").ToString();


        }
    }
}
