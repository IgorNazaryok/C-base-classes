using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Title
    {
        string title;

        public string MyTitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Зазвание книги: " + MyTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
