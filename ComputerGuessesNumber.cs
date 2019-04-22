using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class ComputerGuessesNumber
    {
        int high = 100;
        int low = 1;
        int value;
        
        
        public void ComputerGame()
        {
            bool win = false;
            int guesses = 10;
            int guessedNumber = 0;
            Console.WriteLine($"Choose a number between {low} - {high} for the computer to guess");
            Console.WriteLine("The computer will have 10 guesses");
            value = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("The computer is thinking................");
            do
            {
                Console.WriteLine("Press enter to make the computer guess");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Your Number:{value}\t\t The number is between:{low} - {high}\t\t Guesses Left: {guesses}\n\n");
                guessedNumber = ComputerGuess(low, high);
                Console.Clear();
                Console.WriteLine($"Your Number:{value}\t\t The number is between:{low} - {high}\t\t Guesses Left: {guesses}\n\n");
                Console.WriteLine($"The computer guess is: {guessedNumber}");
                if (guessedNumber == value)
                {
                    Console.WriteLine("The computer guessed your number! You Lost!");
                    win = true;
                    break;
                }
                else if (guessedNumber > value)
                {
                    Console.WriteLine("Your guess was to high computer");
                    high = guessedNumber - 1;
                }
                else
                {
                    Console.WriteLine("Your guess was to low computer");
                    low = guessedNumber + 1;
                }
                Console.ReadKey();
                guesses--;
            } while (guesses > 0);
            if (win == true) { Console.WriteLine("The computer won");Console.ReadKey();}
            else{ Console.WriteLine("You outsmarted the computer"); Console.ReadKey();}
            
        }

       
        // Taking the middle of the high and low
        public int ComputerGuess(int low, int high)
        {
            int compNumber = (low + high) / 2;
            return compNumber;
        }
  
    }
}
