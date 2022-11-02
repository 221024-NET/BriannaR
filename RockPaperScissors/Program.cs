using System;

namespace RPSGame {

    class Program {
        public static void Main(String[] args) {
            Game play = new Game();
            bool playAgain = false;
            // Loop start for playAgain()
            do {
                // Get computer choice
                int compChoice = play.getCompChoice();

                // Get user Input
                int userChoice = play.getUserChoice();

                // Convert both choices to option str
                string compOption = play.getOption(compChoice);
                string userOption = play.getOption(userChoice);

                // Get Result
                string result = play.getResult(compOption, userOption);
                Console.WriteLine(result);

                // ! Play again prompt
                Console.WriteLine("Game over! To play again, press y, OR press any key to exit: ");
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.Key == ConsoleKey.Y) {
                    playAgain = true;
                } else {
                    Console.WriteLine("Exiting game...");
                    playAgain = false;
                }

            } while (playAgain);
        }
    }
}