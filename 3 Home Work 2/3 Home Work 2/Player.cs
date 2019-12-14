using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Home_Work_2
{
    class Player: IPlayable, IRecodable
    {     
            public void Play() 
            {
                Console.WriteLine("Прогрывание начато");
            }
            void IPlayable.Pause()
            {
                Console.WriteLine("Прогрывание поставлено на паузу");
            }
            void IPlayable.Stop()
            {
                Console.WriteLine("Прогрывание окончено");
            }
            public void Record()
            {
                Console.WriteLine("Запись начата");
            }
            void IRecodable.Pause()
            {
                Console.WriteLine("Запись поставлена на паузу");
            }
            void IRecodable.Stop()
            {
                Console.WriteLine("Запись окончена");
            }
    }
}
