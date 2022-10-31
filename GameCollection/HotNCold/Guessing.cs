using System;

namespace HotNCold {

    public class Guessing {

        // Constructor
        public Guessing() { }

        // Methods

        public int GenerateSecretNum() {
            var rand = new Random(); // generate a random
            int secretNum = rand.Next(101); // pick a random number between 0 and 100
            return secretNum;
        }

        public int GetUserNum() {
            Console.WriteLine("Enter a guess for the secret number: ");
            string userChoice = Console.ReadLine(); // accept the users guess
            int userNum = -1;


            while (!Int32.TryParse(userChoice, out userNum)) { // convert from string to int so we can compare, if possible
                Console.WriteLine("Please enter only numerical values."); // prompt user again if not valid
                userChoice = Console.ReadLine();
            }

            return userNum;
        }

        public string PrintResult(int secretNum, int userNum) {
            if (secretNum == userNum) { // if the user guessed correctly
                return "Congratulations, you've guessed the secret number!";
            } else if (secretNum > userNum) { // if user guesses low
                return "Oops, you've guessed too low!";
            } else if (secretNum < userNum) { // if user guesses too high
                return "Oops, you've guessed too high!";
            }
            return "Game over!";

        }
    }
}
