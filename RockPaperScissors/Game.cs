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

        public int getUserNum() {
            Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
            string userString = Console.ReadLine();
            int userNum = inputValidation(userString);
            return userNum;
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

        public string getChoice(int compChoice, int userNum) {
            // Options:  1 - Rock, 2 - Paper, 3 - Scissors
            // TODO: should return string option:
            // Compare each number to options
            // change result to string and return
            // return string to pass to PrintResult
            // TODO: If choice == 1, choice = "rock", etc

            // Console.WriteLine($"You chose {userChoice}");

        }

        public string getResult(int compChoice, int userChoice) {
            // Options:  1 - Rock, 2 - Paper, 3 - Scissors
            // TODO: If choice == 1, choice = "rock", etc
            string result = "";
            if (compChoice == userChoice) {
                // both are right
                result = $"A draw! Both chose {userChoice}";
            } else if ((compChoice == 1 && userChoice == 3) || (compChoice == 2 && userChoice == 1) || (compChoice == 3 && userChoice == 2)) {
                // Comp wins
                result = $"You lost! {compChoice} beats {userChoice}";
            } else {
                // User Wins
                result = $"You win! {userChoice} beats {compChoice}";
            }
            return result;
        }

        public void printResult() {
            // TODO: Get str from getChoice()
            Console.WriteLine("");
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
