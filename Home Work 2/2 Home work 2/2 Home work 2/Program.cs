using System;

namespace _2_Home_work_2
{
    class ClassRoom
    {
        Pupil first, second, third,fourth;
        public ClassRoom(Pupil first, Pupil second, Pupil third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = second;
        }
        public ClassRoom(Pupil first, Pupil second)
        {
            this.first = first;
            this.second = second;
            this.third = first;
            this.fourth = second;
        }
        public void ClassInfo()
        {
            Console.WriteLine("Меня зовут "+this.first.Name+"!"); 
            this.first.Study();
            this.first.Read();
            this.first.Write();
            this.first.Relax();

            Console.WriteLine("Меня зовут " + this.second.Name + "!");
            this.second.Study();
            this.second.Read();
            this.second.Write();
            this.second.Relax();
            
            Console.WriteLine("Меня зовут " + this.third.Name + "!");
            this.third.Study();
            this.third.Read();
            this.third.Write();
            this.third.Relax();

            Console.WriteLine("Меня зовут " + this.fourth.Name + "!");
            this.fourth.Study();
            this.fourth.Read();
            this.fourth.Write();
            this.fourth.Relax();
        }
    }

    class Pupil
    {
       public string Name;
        public Pupil(string Name)
        {
            this.Name = Name;
        }
        public virtual void Study()
        {
            Console.WriteLine("Я учусь!");
        }
        public virtual void Read()
        {
            Console.WriteLine("Я читаю!");
        }
        public virtual void Write()
        {
            Console.WriteLine("Я пишу!");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Я отдыхаю!");
        }
    }

    class ExcelentPupil:Pupil
    {
        public ExcelentPupil(string Name):base(Name)
        {
            
        }
        public override void Study()
        {
            Console.WriteLine("Я учусь отлично!");
        }
        public override void Read()
        {
            Console.WriteLine("Я читаю отлично!");
        }
        public override void Write()
        {
            Console.WriteLine("Я пишу отлично!");
        }
        public override void Relax()
        {
            Console.WriteLine("Я отдыхаю отлично!");
        }
    }
    class GoodPupil:Pupil
    {
        public GoodPupil(string Name) : base(Name)
        {

        }
        public override void Study()
        {
            Console.WriteLine("Я хорошо учусь!");
        }
        public override void Read()
        {
            Console.WriteLine("Я хорошо читаю!");
        }
        public override void Write()
        {
            Console.WriteLine("Я хорошо пишу!");
        }
        public override void Relax()
        {
            Console.WriteLine("Я хорошо отдыхаю!");
        }
    }
    class BadPupil:Pupil
    {
        public BadPupil(string Name) : base(Name)
        {

        }
        public override void Study()
        {
            Console.WriteLine("Я плохо учусь!");
        }
        public override void Read()
        {
            Console.WriteLine("Я плохо читаю!");
        }
        public override void Write()
        {
            Console.WriteLine("Я плохо пишу!");
        }
        public override void Relax()
        {
            Console.WriteLine("Я плохо отдыхаю!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil Vasya = new ExcelentPupil("Василий");
            GoodPupil Kolya = new GoodPupil("Николай");
            BadPupil Sasha = new BadPupil("Александра");
            GoodPupil Dasha = new GoodPupil("Дарья");
            ClassRoom classRoom = new ClassRoom(Vasya,Kolya,Sasha);
            classRoom.ClassInfo();
        }
    }
}
