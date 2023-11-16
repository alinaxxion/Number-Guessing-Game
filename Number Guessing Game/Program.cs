using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();
            int randomNum = random.Next(1, 11);

            Console.WriteLine("Can you guess the correct number?");
            Console.WriteLine("I will generate a number between 1 and 10...");
            Console.WriteLine("Guess correctly, you win! Otherwise, continue playing until you win :)");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Number is too high!");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Number is too low!");
                }
                else
                {
                    Console.WriteLine("YOU WIN!");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine("Thanks for playing~");

            Console.ReadKey();
        }

    }
}