using System;

namespace HomeWork_6
{
    class Program
    {
        class User
        {
            string login, firstName, lastName, age;
            readonly DateTime creationDate;

            public User(string login, string firstName, string lastName, string age)
            {
                this.login = login;
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.creationDate = DateTime.Now;                
            }
           public  void print()
            {
                Console.WriteLine("User login: " + this.login + "\t"  + "Name: " + this.firstName+ "\t" 
                    + "First Name: " + this.firstName+ "\t"
                    + "Age: " + this.age + "\t"+"\t"
                    + "Creation date: " + this.creationDate);
            }
        }
        static void Main(string[] args)
        {
            new User("inazarek", "Igor","Nazaryok","34").print();
            new User("inazarek", "Igor", "Nazaryok", "34").print();
            new User("inazarek", "Igor", "Nazaryok", "34").print();
            new User("inazarek", "Igor", "Nazaryok", "34").print();
        }
    }
}
