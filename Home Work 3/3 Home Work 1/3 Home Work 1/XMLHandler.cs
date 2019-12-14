using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Home_Work_1
{
    class XMLHandler : AbstractHendler
    {       
        public XMLHandler()
        {
            Console.WriteLine("Это Документ типа XML");
        }
            public override void Open()
            {
                Console.WriteLine("Открыт документ типа XML");
            }
            public override void Create()
            {
                Console.WriteLine("Создан документ типа XML");
            }
            public override void Chenge()
            {
                Console.WriteLine("Изменен документ типа XML");
            }
            public override void Save()
            {
                Console.WriteLine("Сохранен документ типа XML");
            }       
    }
}
