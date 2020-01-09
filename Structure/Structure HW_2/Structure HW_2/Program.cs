using System;


namespace Structure_HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            void CreateArrayTrain(Train[] T)
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine($"Введите данные {i} поезда - Номер, Пункт назаначения и Время отправления");
                    int trainNuber = Convert.ToInt32(Console.ReadLine());
                    string destination = Console.ReadLine();
                    string departureTime = Console.ReadLine();
                    T[i-1] = new Train(destination, trainNuber, departureTime);
                    T[i-1].ShowInfo();
                }

            }
            void SortArrayTrain(Train[] T)
            {
                Train temp;
                for (int j = 0; j < T.Length - 1; j++) 
                {
                    for (int i = 0; i < T.Length - 1; i++)
                    {
                        if (T[i].TrainNuber > T[i + 1].TrainNuber)
                        {
                            temp = T[i + 1];
                            T[i + 1] = T[i];
                            T[i] = temp;
                        }

                    }
                }               
            }
            void ShowInfoTrain(Train[] array)
            {
                Console.WriteLine("Для просмотра информации укажите номер поезда");
                int number = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                while (i < 8)
                {
                    if (array[i].TrainNuber == number)
                    {
                        array[i].ShowInfo();
                        break;
                    }
                    i++;
                    if (i == 8)
                    {
                        Console.WriteLine("Номер поезда не найден..");
                    }
                }
            }
            
            CreateArrayTrain(trains);   
            SortArrayTrain(trains);
            ShowInfoTrain(trains);

            
        }
        
    }    
}
