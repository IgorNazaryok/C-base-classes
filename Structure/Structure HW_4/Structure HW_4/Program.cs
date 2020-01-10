using System;

namespace Structure_HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату своего рождения дд/мм/гггг");

            string birthday = Console.ReadLine().Substring(0, 6);
            
            DateTime now = DateTime.Now;
            string nowYear = now.ToString().Substring(6, 4);

            DateTime nextBirthday = DateTime.Parse(birthday + nowYear);
           
            if (nextBirthday< DateTime.Now)
            {
                nextBirthday=nextBirthday.AddYears(1);
            }
           
            TimeSpan time = nextBirthday - DateTime.Now;

            Console.WriteLine("До вашего дня рождения осталось {0} дней", time.Days);

        }
    }
}
