using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Number Guessing Game!");
            // Computer randomly generate the nubmer within the range
            // User input 
            // Check the valid user input
            // Compare ComputerNum with user input 
            // If number matches - game stops
            // Returns message for another user input
            // User provides input again if the number doesn't match!
            Random rndm = new Random();
            int compNum = rndm.Next(1, 101);
            while (true)
            {
                Console.WriteLine("Please guess a number between 1 and 100");
                string userInput = Console.ReadLine();
                int guess = 0;
                bool isInt = Int32.TryParse(userInput, out guess);
                if (!isInt)
                {
                    Console.WriteLine("That isn't a number");

                }
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Select a number between 1 and 100");
                }
                if (compNum > guess)
                {
                    Console.WriteLine("Guess lower.");
                }
                else if (compNum < guess)
                {
                    Console.WriteLine("Guess higher.");
                }
                else
                {
                    Console.WriteLine("You guessed right!");
                }
            }
        }
    }
}
