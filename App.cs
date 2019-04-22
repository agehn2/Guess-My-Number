using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class App
    {
        
        public void Run()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("1.Play against computer 2. Computer guesses your number 3. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        new UserGuessesNumber().GuessNumber();
                        break;
                    case 2:
                        new ComputerGuessesNumber().ComputerGame();
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        break;

                }
            } while (!exit);
            



        }



    }
}
