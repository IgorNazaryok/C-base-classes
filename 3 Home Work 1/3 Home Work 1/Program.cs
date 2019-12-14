using System;

namespace _3_Home_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHendler xml = new XMLHandler();
            AbstractHendler txt = new TXTHandler();
            AbstractHendler doc = new DOCHandler();
            xml.Open();
            txt.Chenge();
            doc.Create();
            xml.Save();

        }
    }
}
