using System;

namespace RPSGame {

    public class Game {

        public Game() { }

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

        // TODO: TEST FIRST
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

        // TODO: getResult()

        // ? printResult()

        // TODO: playAgainPrompt()

    }


}
