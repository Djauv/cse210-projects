using System;

/*
HAVE SYSTEM PULL RANDOM NUMBER
HAVE USER GUESS
TELL IF NUM IS HIGHER OR LOWER
*/


class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        float magicGuess = 0;

        while (magicGuess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            magicGuess = float.Parse(guess);

            if (magicGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

        }
        Console.WriteLine($"You guessed it, the magic number is {magicNumber}!!!");




    }
}