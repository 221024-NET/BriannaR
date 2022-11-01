using System;

namespace RPSGame {

    class Program {
        public static void Main(String[] args) {
            Game play = new Game();

            // Get computer choice
            int compChoice = play.getCompChoice();

            // Get user choice
            var userChoice = play.getUserChoice();

            // Get Result
            Console.WriteLine($"The computer chose {compChoice}");
            string result = play.getResult(compChoice, userChoice);

            Console.WriteLine("Game over!");

            // TODO: Add playAgainMessage();

        }
    }
}