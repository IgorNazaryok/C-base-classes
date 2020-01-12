using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_HW_6
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if(hours > (int)Post.CIO)
            {
                Console.WriteLine("Положена премия"); 
            }
            else
             Console.WriteLine("Премия не положена");

            return (hours > (int)Post.CIO);

        }
    }
}