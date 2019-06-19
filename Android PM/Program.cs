using System;
using System.Threading;

namespace Android_PM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the question?");
            string q = Console.ReadLine();
            bool p = string.IsNullOrEmpty(q);
            if(p==false)
            {
                Console.WriteLine("Booting Android PM Indeed");
                Console.WriteLine("******************");
                Thread.Sleep(2500);
                Console.WriteLine("Brexit Means Brexit");
                Thread.Sleep(1000);
                Console.WriteLine("Running Strong_and_Stable.exe");
                Thread.Sleep(1000);
                Console.WriteLine("Resign, Resign, Resign");
                Thread.Sleep(1000);
                Console.WriteLine("Summon Johnson");
                Thread.Sleep(1000);
                Console.WriteLine("Terminate Democracy");
                Thread.Sleep(1000);
            }
        }
    }
}
