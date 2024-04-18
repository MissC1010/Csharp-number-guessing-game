using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number will be generated between 1-10");
            Console.WriteLine("if you guess the correct number, You Win!");

            while (!isCorrectGuess)
            {
                Console.Write("Enter you guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high ↑");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low ↓");
                }

                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Congratulation you have won!");

            Console.ReadKey();
        }
    }
}
