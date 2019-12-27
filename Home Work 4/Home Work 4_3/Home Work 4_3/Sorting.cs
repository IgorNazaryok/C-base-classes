using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work_4_3
{
    static class SortingClass
    {
        public static void SortingMetod(this int [] arr, bool route)
        {
           if(route)
            {
                Console.Write("До сортировки: "+"\t" + "\t");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
                int temp;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }

                    }
                }
                Console.WriteLine("");
                Console.Write("После сортировки по возрастанию: " + "\t");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
                Console.WriteLine("");
            }
            else
            {
                Console.Write("До сортировки: " + "\t" + "\t");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
                int temp;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        if (arr[i] < arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }

                    }
                }
                Console.WriteLine("");
                Console.Write("После сортировки по убыванию: " + "\t");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
                Console.WriteLine("");
            }
           
        }
    }
}
