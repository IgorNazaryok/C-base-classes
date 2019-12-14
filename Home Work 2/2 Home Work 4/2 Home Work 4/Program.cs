using System;

namespace _2_Home_Work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рады Вас преведствовать в нашей программе DocumentWorker!");
            Console.WriteLine("Для активации Pro или Expert верссии введите код активации состоящий из 6 цифр:");
            string activation = Console.ReadLine();
            switch (activation)
            {
                case "111111":
                    DocumentWorker ProDocumentWorkerUP = new ProDocumentWorker() as DocumentWorker;
                    Console.WriteLine("Активация успешна! Благодарим за приобретение версии Pro!");
                    break;

                case "111222":
                    DocumentWorker ExpertDocumentWorkerUP = new ExpertDocumentWorker() as DocumentWorker;
                    Console.WriteLine("Активация успешна! Благодарим за приобретение версии Exp!");
                    break;

                default:
                    DocumentWorker documentWorker = new DocumentWorker();
                    Console.WriteLine("Вам доступна бесплатная верися программы!");
                    break;
            }
        }
    }
}
