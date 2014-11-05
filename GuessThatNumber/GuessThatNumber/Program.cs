using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessNumber(0);
            Console.ReadKey();
        }
        static void GuessNumber(int numberGuess)
        {
            Random rng = new Random();
            int numberThatsGenerated = rng.Next(1, 101);
            int totalGuesses = 1;

            Console.WriteLine("Guess a number");
            numberGuess=Convert.ToInt32(Console.ReadLine());


            //int lastNumberGuessed = 0;
            while (numberGuess != numberThatsGenerated)
            {

                if (numberThatsGenerated > numberGuess)
                {
                    Console.WriteLine("You need to guess higher!");
                    totalGuesses++;
                    numberGuess=Convert.ToInt32(Console.ReadLine());

                }
                if(numberThatsGenerated < numberGuess)
                {
                    Console.WriteLine("You need to guess lower!");

                    totalGuesses++;
                    numberGuess=Convert.ToInt32(Console.ReadLine());

                }

            }
            Console.WriteLine("You got it!");
            Console.WriteLine("It took you: "+totalGuesses+" trys.");
        }
    }
}
