using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11)
                int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta Number:");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (cpuRandom == userGuess)
                {
                    Console.WriteLine("tubli! Oled Mängu Võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"proovi uuesti! { 3 - i} katset on jäänud.");
                }
            }


        }
    }
}
