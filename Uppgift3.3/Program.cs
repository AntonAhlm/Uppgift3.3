using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra en bil?");
            int tid = Convert.ToInt32(Console.ReadLine());
            int pris = tid * 80 ;

            if (pris > 950)
                pris = 950;

            Console.WriteLine("Det kommer att kosta " + pris + "kr.");

 
        }
    }
}
