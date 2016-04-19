using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Book
    {
        public string Title;
        public string Category;
        public string Author;
        public int NumberPage;
        public int CurrentPage;
        public string ISBN;

        public Book(int cPage, int nPage)
        {
            this.CurrentPage = cPage;
            this.NumberPage = nPage;
            this.Title = "";
            this.Category = "";
            this.Author = "";
            this.ISBN = "";
        }

        public int NextPage()
        {
            return this.CurrentPage += 1;
        }

        public int PrevPage()
        {

            return this.CurrentPage -= 1;
        }
    }
}
