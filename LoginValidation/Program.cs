using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; 

            while (i < 3)
            {
                Console.WriteLine("Sisesta Kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta Parool:");
                string userPassword = Console.ReadLine();
                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere Tulemast!");
                        break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäänud");
                }
            }

            Console.WriteLine("Kena Päeva!");






        }
    }
}
