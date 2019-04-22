using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class UserGuessesNumber
    {
        int value = RandomNumber(1, 1000);
        List<int> bisectionList = Enumerable.Range(1, 1000).ToList();

        public List<int> GuessNumber()
        {
            bool winOrLose = false;
            int high = 1000;
            int low = 1;
            int count = 1;
            do 
            {
                Console.WriteLine($"Choose a number between: {low} - {high}\t\t\t\t\t\t\t  Total Guesses Left: {11 - count}");
                int userGuess = int.Parse(Console.ReadLine());
                //Check if the number was out of range
                if (userGuess > high || userGuess < low)
                {
                    Console.WriteLine("Your guess was now within the limits");
                    Console.WriteLine("Please enter another number");
                    Console.WriteLine("Press Enter To Continue");
                    Console.ReadKey();
                    count--;
                }
                else if (userGuess > value)
                {
                    Console.WriteLine("The number is less than your guess");
                    high = userGuess;
                }
                else if (userGuess < value)
                {
                    Console.WriteLine("The number is greater than your guess");
                    low = userGuess;
                }
                else if (userGuess == value)
                {
                    Console.WriteLine("Great Job! You guessed the correct number");
                    winOrLose = true;
                    break;    
                }
                count++;
                Console.Clear();
            }while (count <= 10);

            if (winOrLose == true)
            {
                Console.WriteLine($"You guessed the correct number in {count} guesses");
                Console.ReadKey();
                return bisectionList;     
                
            }
            Console.WriteLine($"You are out of guesses\nBut you were close, the number i was thinking was {value}");
            Console.ReadKey();
            return bisectionList;        
        }

        

            
            

        //Setting a random INT number
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }








    }
}
