using System.ComponentModel.Design;
using static System.Console;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int randomNumber = random.Next(1, 101);
            WriteLine("Guess a number between 1 and 100");
            //Console.WriteLine(randomNumber); // TODO: Husk å fjerne denne linja!!

            while (true)
            {
                WriteLine("Write your number:");
                string? input = ReadLine();
                if (int.TryParse(input, out int guess))
                {
                    if (guess > randomNumber)
                    {
                        WriteLine("The number you guessed is too high!");
                    }
                    else if (guess < randomNumber)
                    {
                        WriteLine("The number you guessed is too low!");
                    }
                    else if (guess == randomNumber)
                    {
                        WriteLine("Congratulations, You guessed the right number!");
                        break;
                    }
                }
                else
                {
                    WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}