using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Майн Рид", "Солнечные лучи играли на ее белокурых косах, ...... ","Белая перчатка" );
           
            //book.Content = "MY_Content";
            //book.Author = "MY_Author";

            book.Show();
            
            Console.ReadKey();
        }
    }
}
