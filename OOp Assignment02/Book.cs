using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Assignment02
{
    internal abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        protected Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        public override string ToString() => $"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}";


    }
}
