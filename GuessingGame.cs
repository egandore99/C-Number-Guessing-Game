using System.ComponentModel.Design;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;
            String response;

            Console.WriteLine("Welcome to the Number Guessing Game! Choose a difficulty level: ");
            Console.WriteLine("1 - Easy (1 to 50)");
            Console.WriteLine("2 - Medium (1 to 100)");
            Console.WriteLine("3 - Hard (1 to 200)");

            int difficulty = Convert.ToInt32(Console.ReadLine());

            switch (difficulty)
            {
                case 1:
                    max = 50;
                    break;
                case 2:
                    max = 100;
                    break;
                case 3:
                    max = 200;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Medium");
                    max = 100;
                    break;
            }

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine($"I'm thinking of a number between {min} and {max}. Try to guess it!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine($"Not quite! {guess} is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"Not quite! {guess} is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine($"Number: {number}");
                Console.WriteLine("You win!");
                Console.WriteLine($"Guesses: {guesses}");

                Console.WriteLine("Would you like to play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing my game! @egandore99");

            Console.ReadKey();

        }
    }
}
