using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Book
    {
        Title title = null;
        Content content = null;
        Author author = null;
        void BildBook()
        {
            this.author = new Author();
            this.content = new Content();
            this.title = new Title();
        }
        public Book(string Author, string Content,string Title )
        {
            BildBook();
            this.author.MyAuthor = Author;
            this.content.MyContent = Content;
            this.title.MyTitle = Title;
        }
        public void Show()
        {
            this.author.Show();
            this.title.Show();
            this.content.Show();
            
        }

        public void GetAutor(string value)
        {
            this.author.MyAuthor= value;
        }
        public void GetContent(string value)
        {
            this.content.MyContent = value;
           
        }
        public void GetTitle(string value)
        {
            this.title.MyTitle = value;

        }

    }
}
