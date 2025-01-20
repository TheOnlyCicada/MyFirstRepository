using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the random number generator
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have generated a random number between 1 and 100.");
            Console.WriteLine("Can you guess what it is?");

            // Main game loop
            while (guess != randomNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Validate the input
                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}