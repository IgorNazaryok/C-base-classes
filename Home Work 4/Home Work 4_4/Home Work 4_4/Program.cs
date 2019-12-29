using System;

namespace Home_Work_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string text = "Текстовая строка", search = "стр", replace= "АБВГД";
                                 
            Console.WriteLine(text);
            Console.WriteLine(text.SubString(2));
            Console.WriteLine(text.SubString(2, 8));
            Console.WriteLine(text.IndexOF(search));
            Console.WriteLine(text.RepLace(search, replace));

        }
    }
}
