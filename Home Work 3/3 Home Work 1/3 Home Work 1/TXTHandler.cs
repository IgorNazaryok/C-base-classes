using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Home_Work_1
{
    class TXTHandler: AbstractHendler
    {
        public TXTHandler()
        {
            Console.WriteLine("Это Документ типа TXT");
        }
        public override void Open()
        {
            Console.WriteLine("Открыт документ типа TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Создан документ типа TXT");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменен документ типа TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен документ типа TXT");
        }
    }
}
