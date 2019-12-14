using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Home_Work_4
{
    class ExpertDocumentWorker: ProDocumentWorker
    {
       
        override public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
