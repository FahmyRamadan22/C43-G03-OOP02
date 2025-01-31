using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Assignment02
{
    internal class EBook : Book
    {
        public EBook(string title, string author, string ISBN, double fileSize) : base(title, author, ISBN)
        {
            FileSize = fileSize;
        }

        public double FileSize { get; set; }

        public override string ToString() => $"EBook Information is:\n{base.ToString()}\nFile Size: {FileSize}";


    }
}
