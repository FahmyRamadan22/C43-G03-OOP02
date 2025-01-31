using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Assignment02
{
    internal class PrintedBook : Book
    {
        public int PageCount { get; set; }
        public PrintedBook(string title, string author, string ISBN, int pageCount) : base(title, author, ISBN)
        {
            PageCount = pageCount;
        }

        public override string ToString() => $"Printed Book Information is:\n{base.ToString()}\nPage Count: {PageCount}";

    }
}
