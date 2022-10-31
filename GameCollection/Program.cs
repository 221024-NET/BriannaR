using System;

namespace HotOrCold {
    class Program {
        public static void Main(String[] args) {
            Console.WriteLine("Number Guesser started: ");
            var rand = new Random(); // create Random
            int secretNum = rand.Next(101); // generate number from 1-100
            Console.WriteLine("Enter your Secret Number guess: ");
            string userChoice = Console.ReadLine(); // read user guess
            int userNum = Int32.Parse(userChoice); // string to int

            bool loop = true;
            while (loop) {
                if (secretNum == userNum) {
                    // if correctly guessed
                    Console.WriteLine("Congrats! You guessed the secret number!");
                    loop = false;
                } else if (secretNum > userNum) {
                    // if too low
                    Console.WriteLine("Oops, you've guessed too low!");
                } else if (secretNum < userNum) {
                    // if too high
                    Console.WriteLine("Oops, you've guessed too high!");
                }
            }

        }
    }
}
