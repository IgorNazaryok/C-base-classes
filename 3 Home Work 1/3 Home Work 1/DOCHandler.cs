using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Home_Work_1
{
    class DOCHandler: AbstractHendler
    {
        public DOCHandler()
        {
            Console.WriteLine("Это Документ типа DOC");
        }
        public override void Open()
        {
            Console.WriteLine("Открыт документ типа DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Создан документ типа DOC");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменен документ типа DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен документ типа DOC");
        }
    }
}
