using System;
using System.Text;

namespace Wordle {

    public class Program {

        public static void Main(string[] args) {
            string fpath = "./testFile.txt";
            string gameHistory = "./.playerHistory";

            string[] words = File.ReadAllLines(fpath);
            var rand = new Random();

            bool solved = false;
            int turns;
            string guess;

            //potential array of past guesses to be shown on every turn's end

            //ColorString[] guesses = new ColorString[6];
            ConsoleColor[] feedback = { ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Gray };

            // Create new user
            Console.WriteLine("Please enter a username: ");
            string newUsername = Console.ReadLine();
            Console.WriteLine("Please enter a password: ");
            string newPassword = Console.ReadLine();

            User player = new User(newUsername, newPassword);

            bool loop = true;

            // * START GAME LOOP
            do {
                turns = 0;
                string secret = words[rand.Next(words.Length)].ToLower().Trim();

                // ! display secret word for testing
                Console.WriteLine(secret);

                // Game Loop
                while (turns < 6) {
                    Console.WriteLine("Guess: ");
                    guess = Console.ReadLine().ToLower();
                    if (guess == null || guess.Length != 5) {
                        Console.WriteLine("Invalid guess. Must be a 5-letter word");
                        continue;
                    }
                    // guesses[turns].S=guess;
                    turns++;

                    // wrong guess, give feedback
                    for (int i = 0; i < 5; i++) {
                        //guessed letter in the right place
                        if (guess[i] == secret[i]) {
                            Console.WriteLine("This {0} is in the right place", guess[i]);
                            feedback[i] = ConsoleColor.Green;
                            //guess[turns].setCharColor(ConsoleColor.Green,i);
                        }

                        //guessed letter wrong
                        //letter is or isn't in the word
                        else {
                            Console.WriteLine("The word {0} contain {1}", secret.Contains(guess[i]) ? "does" : "does not", guess[i]);
                            feedback[i] = secret.Contains(guess[i]) ? ConsoleColor.Yellow : ConsoleColor.Gray;
                            /*
                            if secret.Contains(guess[i]) guesses[turns].setCharColor(ConsoleColor.Yellow,i);
                            //default color is gray so no need to set there
                            */
                        }
                    }

                    //print the colored guess
                    /*If ColorString works just use the given method instead*/
                    for (int i = 0; i < 5; i++) {
                        printcolor(guess[i], feedback[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write("\n");

                    //correct guess
                    if (guess == secret) {
                        solved = true;
                        break;
                    }
                }//end of while


                Console.WriteLine(solved ? $"Solved in: {0} turn(s)" : "Not solved ");
                Console.WriteLine("The word was: {1}", turns, secret);

                // Update user info
                // (win or loss boolean, # of turns int)
                player.UpdateRecord(solved, turns);

                Console.WriteLine("Play Again? (Y/N)");
                string choice = Console.ReadLine();

                if (choice.ToUpper() != "Y") {
                    loop = false;
                }

            } while (loop);
            // * END GAME LOOP

            // (Display player history info)
            player.SaveHistory(gameHistory);
            Console.WriteLine("Here are your current stats: ");
            var playerRecord = player.DisplayRecord(gameHistory);
            Console.WriteLine(playerRecord);

        }

        //Print a char with a specific background color
        private static void printcolor(char c, ConsoleColor cc) {
            Console.BackgroundColor = cc;
            Console.Write("{0}", c);
        }
    }

}
