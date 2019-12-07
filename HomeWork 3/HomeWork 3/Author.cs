using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Author
    {
        string author;

        public string MyAuthor
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Автор книги: "+MyAuthor);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
