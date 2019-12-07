using System;

namespace HomeWork_7
{
    class Program
    {
        class Employee
        {
            string firstName, lastName;
            public Employee(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
            public void SalaryTax(int i_position, int experience)
            {
                string position = null;
                switch (i_position)
                {
                    case 1:
                        position = "QA Engineer";
                        break;
                    case 2:
                        position = "Developer";
                        break;
                    case 3:
                        position = "Product manager";
                        break;
                }
                Console.WriteLine("Фамилия" + "\t" + "Имя" + "\t" + "Должность" + "\t" + "\t" + "Оклад,грн" + "\t" + "Налоговый сбор,грн");
                Console.WriteLine(lastName +"\t"  + firstName + "\t" + position + "\t" + "\t" + 100 * i_position * experience + "грн" + "\t" + "\t" + 100 * i_position * experience * 0.20 + " грн");

            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee("Игорь", "Козякин");
            int i_position, experience;         
            do
            {
                Console.Clear();
                Console.WriteLine("Укажите должность сотрeдника: 1 - QA Engineer; 2-Developer; 3-Product manager");
                i_position = Convert.ToInt32(Console.ReadLine());
            }
            while (i_position < 0 || i_position > 3);

           
            do
            {
                Console.Clear();
                Console.WriteLine("Укажите стаж сотрeдника - значение от 1 до 10");
                experience = Convert.ToInt32(Console.ReadLine());            
            }
            while (experience < 1 || experience > 10);

            employee.SalaryTax(i_position, experience);
        }
    }
}
