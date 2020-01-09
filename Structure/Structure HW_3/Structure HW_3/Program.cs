using System;

namespace Structure_HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ClassTaker(MyClass myClass)
            {
                myClass.change="изменено";
            }
            static void StructTaker(MyStruct myStruct)
            {
                myStruct.change = "изменено";
            }

            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            myClass.change= "не изменено";
            myStruct.change = "не изменено";
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
        }
    }
}
