using System;

namespace RPSGame {
    public class Game {

        public Game() { }

        public int getCompChoice() {
            var rand = new Random();
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

        // Convert both choices to option str
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

        // Returns game result
        public string getResult(string compOption, string userOption) {
            string result;
            Console.WriteLine($"You threw {userOption}...\n");

            if ((compOption == "rock") && (userOption == "scissors")) {
                result = "You lost...rock beats scissors!";

            } else if ((compOption == "paper") && (userOption == "rock")) {
                result = "You lost...paper beats rock!";

            } else if ((compOption == "scissors") && (userOption == "paper")) {
                result = "You lost...scissors beats paper!";

            } else if ((userOption == "rock") && (compOption == "scissors")) {
                result = "You win! Rock beats scissors!";

            } else if ((userOption == "paper") && (compOption == "rock")) {
                result = "You win! Paper beats rock!";

            } else if ((userOption == "scissors") && (compOption == "paper")) {
                result = "You win! Scissors beats paper!";

            } else if (compOption == userOption) {
                result = "It's a draw!";

            } else {
                return "Something went wrong.";
            }
            Console.WriteLine($"The computer threw {compOption}!");
            return result;

        }

        // TODO: Add loop for draw
        // TODO: Refactor options and results to enum



    }
}
