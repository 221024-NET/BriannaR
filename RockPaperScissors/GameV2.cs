using System;

namespace RPSGame {
    public class GameV2 {

        // constructor
        public GameV2() { }

        public int getCompChoice() {
            var rand = new Random(4);
            int compChoice = rand.Next(1, 4);
            return compChoice;
        }

        public int getUserChoice() {
            Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
            string userInput = Console.ReadLine();
            int userChoice = inputValidation(userInput);
            return userChoice;
        }

        public int inputValidation(string userString) {
            int userChoice = -1;

            while (!Int32.TryParse(userString, out userChoice)) {
                Console.WriteLine("Error! Please enter a number.");
                Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
                userString = Console.ReadLine();
            }
            return userChoice;
        }

        public string getOption(int givenChoice) {
            // Should take int and return str choice from dict
            Dictionary<int, string> options = new Dictionary<int, string> {
                {1, "rock"},
                {2, "paper"},
                {3, "scissors"}
            };
            int matchKey = givenChoice;
            return options[matchKey];
        }



        // ####### TESTING ########
        public string getOption(int givenChoice) {
            // Should take int and return str choice from dict
            Dictionary<int, string> options = new Dictionary<int, string> {
                {1, "rock"},
                {2, "paper"},
                {3, "scissors"}
            };
            int matchKey = givenChoice;
            return options[matchKey];
        }

        public string getResult(string compChoice, string userChoice) {
            // TODO: Print both choices and compare
            // TODO: If choice == 1, choice = "rock", etc
            // return result message;
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