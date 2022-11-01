using System;

namespace RPSGame {

    public class Game {
        // Options:  1 - Rock, 2 - Paper, 3 - Scissors
        public Game() { }

        public int getCompChoice() {
            var rand = new Random(4);
            int compChoice = rand.Next(1, 4);
            return compChoice;
        }

        public int getUserChoice() {
            Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
            string userString = Console.ReadLine();
            int userChoice = inputValidation(userString);
            return userChoice;
        }

        public int inputValidation(string userString) {
            int userChoice = -1;
            // Input validation
            while (!Int32.TryParse(userString, out userChoice)) {
                Console.WriteLine("Error! Please enter a number.");
                Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
                userString = Console.ReadLine();
            }
            return userChoice;
        }

        public string getResult(int compChoice, int userChoice) {
            // Options:  1 - Rock, 2 - Paper, 3 - Scissors
            if (compChoice == userChoice) {
                // both are right
                return $"A draw! Both chose {userChoice}";
            } else if ((compChoice == 1 && userChoice == 3) || (compChoice == 2 && userChoice == 1) || (compChoice == 3 && userChoice == 2)) {
                // Comp wins
                return $"You lost! {compChoice} beats {userChoice}";
            } else {
                // User Wins
                return $"You win! {userChoice} beats {compChoice}";
            }
        }

        public void playAgainMessage() {
            Console.WriteLine("Play again? y/n: ");
            // while True:
            // game = new_game.Game()
            // game.print_result()
            // prompt "Do you want to play again? (y/n):"
            // if user enters n, game ends
            // if user enters y, repeat:
        }
    }


}
