using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Content
    {
        string content;

        public string  MyContent
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Содержимое: " + MyContent);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
