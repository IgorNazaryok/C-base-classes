using System;

namespace _3_Home_Work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IRecodable recorder = new Player();
            recorder.Record();                       
            recorder.Pause();
            recorder.Stop();
            Console.WriteLine(new string('*', 30));
            IPlayable player = new Player();      
            player.Play();
            player.Pause();
            player.Stop();

        }
    }
}
