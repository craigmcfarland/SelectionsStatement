using System;

namespace SelectionsStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my first number game!");
            Console.WriteLine("See if you can guess my favorite number!");
            Console.WriteLine("What is the upper limit for th erange of number");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);


            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("What is your Guess");
            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine(" Your guess is too high");

            }

            if(guess < number)
            {
                Console.WriteLine("Your guess is too High");

            }
            else
            {
                Console.WriteLine("Correct");

            }



        }
    }
}
