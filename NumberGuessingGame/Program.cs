using System.ComponentModel.Design;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int randomNumber = random.Next(1, 101);
            int guess;
            Console.WriteLine("Guess a number between 1 and 100");
            //Console.WriteLine(randomNumber); // TODO: Husk å fjerne denne linja!!

            while (true)
            {
                Console.WriteLine("Write your number:");
                //guess = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();
                if (int.TryParse(input, out guess))
                {
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("The number you guessed is too high!");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("The number you guessed is too low!");
                    }
                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("Congratulations, You guessed the right number!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}