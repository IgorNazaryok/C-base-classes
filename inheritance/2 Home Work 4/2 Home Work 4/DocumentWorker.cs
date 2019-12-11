using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Home_Work_4
{
    class DocumentWorker
    {
        
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
       virtual public void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
