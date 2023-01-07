using System;

namespace numberGuessingGame
{
    internal class Program
    {
        const int LOWESTNUMBER = 1;
        const int HIGHESTNUMBER = 50;
        const int MAXGUESSES = 10;
        const int HINTRANGE = 5;

        static void Main(string[] args)
        {
            Random rd = new Random();
            int userGuess = 0;
            int randomNumber = rd.Next(HIGHESTNUMBER) + 1;
            int guessCounter = 0;

            Console.WriteLine($"Hello User, this program is a game that lets you guess a number between {LOWESTNUMBER} and {HIGHESTNUMBER}\nYou only have {MAXGUESSES} tries to guess the right number");

            while (userGuess != randomNumber)
            {
                Console.WriteLine("Please enter your guess: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                guessCounter++;

                if (userGuess == randomNumber)
                {
                    Console.WriteLine($"That's right! Congratualtions.\nYou guessed the number in {guessCounter} tries.");
                    break;
                }

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("That's too low");
                }

                if (userGuess > randomNumber)
                {
                    Console.WriteLine("That's too high");
                }

                if (Math.Abs(randomNumber - userGuess) <= HINTRANGE)
                {
                    Console.WriteLine($"But close!\nHint: you're only {HINTRANGE} or less away from the right answer.");
                }

                if (guessCounter >= MAXGUESSES)
                {
                    Console.WriteLine($"Sorry, you're out of luck.\nThe right number was {randomNumber}");
                    break;
                }

                Console.WriteLine($"You have {MAXGUESSES - guessCounter} guesses left!");
            }


        }
    }
}
