using System;

namespace RPSGame {

    class Program {
        public static void Main(String[] args) {
            Game play = new Game();
            // TODO: Loop start for playAgain()

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

            // TODO: Add playAgainMessage() for draw and end;

        }
    }
}