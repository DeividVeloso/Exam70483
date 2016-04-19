using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1;

            book1 = new Book();
            book1.Title = "Pense fora da caixa";
            book1.Author = "Jonh Grogan";
            book1.Category = "Auto Não Ajuda";
            book1.CurrentPage = 35;
            book1.NumberPage = 300;
            book1.ISBN = "123554876123456789102030353739";

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);
            Console.WriteLine(book1.Category);
            Console.WriteLine(book1.CurrentPage);
            Console.WriteLine(book1.NumberPage);
            Console.WriteLine(book1.ISBN);


            Console.WriteLine(book1.NextPage());

            Console.WriteLine(book1.PrevPage());

            Console.ReadLine();

        }
    }
}
