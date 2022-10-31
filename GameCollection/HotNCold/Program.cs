using System;

public class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Number Guesser started:"); // greet the user

        var rand = new Random(); // generate a random

        int secretNum = rand.Next(101); // pick a random number between 0 and 100
        int userNum = 0;

        do {
            Console.WriteLine("Enter a guess for the secret number: "); // prompt the user for a guess

            string userChoice = Console.ReadLine(); // accept the users guess

            while (!Int32.TryParse(userChoice, out userNum)) { // convert from string to int so we can compare, if possible
                Console.WriteLine("Please enter only numerical values."); // prompt user again if not valid
                userChoice = Console.ReadLine();
            }

            if (secretNum == userNum) { // if the user guessed correctly
                Console.WriteLine("Congatulations, you've guessed the secret number!");

            } else if (secretNum > userNum) { // if user guesses low
                Console.WriteLine("Oops, you've guessed too low!");
            } else if (secretNum < userNum) { // if user guesses too high
                Console.WriteLine("Oops, too high!");
            }
        } while (secretNum != userNum);

        Console.WriteLine("Thanks for playing!");
    }
}