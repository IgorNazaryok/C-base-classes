using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Home_Work_4
{
    class ProDocumentWorker: DocumentWorker
    {
        
        override public void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        override public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в " +
                "остальных форматах доступно в версии Эксперт");
        }
    }
}
