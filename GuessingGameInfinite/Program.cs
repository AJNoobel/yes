using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {



                Random random = new Random();


                int correctNumber = random.Next(1, 10);


                int guess = 0;


                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {

                    string input = Console.ReadLine();


                    if (!int.TryParse(input, out guess))
                    {

                        Console.WriteLine("Please use an actual number");

                        continue;
                    }


                    guess = Int32.Parse(input);


                    if (guess != correctNumber)
                    {

                        Console.WriteLine("Wrong number, please try again");
                    }
                }




            }
        }
    }
}
