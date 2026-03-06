using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1,101);

        int guess = -1;
        int amountguess = 0;

        while (guess != magicnumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                amountguess = amountguess + 1;
                Console.WriteLine("Higher");
            }
            else if (magicnumber < guess)
            {
                amountguess = amountguess + 1;
                Console.WriteLine("Lower");                
            }
            else
            {
                amountguess = amountguess + 1;
                Console.WriteLine($"Congrats, you guessed the number. It took you {amountguess} guesses");
            }
        }
    }
}