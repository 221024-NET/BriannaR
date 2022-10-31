using System;

namespace HotNCold {
    public class Program {
        public static void Main(string[] args) {
            Guessing game = new Guessing();

            Console.WriteLine("Number Guesser started:"); // greet the user

            int secretNum = game.GenerateSecretNum();

            int userNum = 0;

            do {
                userNum = game.GetUserNum();

                Console.WriteLine(game.PrintResult(secretNum, userNum));

            } while (secretNum != userNum);

            Console.WriteLine("Thanks for playing!");
        }
    }
}