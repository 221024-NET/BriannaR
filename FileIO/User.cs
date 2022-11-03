using System;
using System.Text;
using System.IO;

namespace Wordle {
    public class User {
        //Fields
        string userName;
        string password;
        int wins;
        int losses;
        double avgTurns;
        int[] turns;

        // Constructors
        public User(string userName, string password) {
            this.userName = userName;
            this.password = password;
            this.wins = 0;
            this.losses = 0;
            this.avgTurns = 0;
            this.turns = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        }

        public User(string userName, string password, int wins, int losses, double avgTurns, int[] turns) {
            this.userName = userName;
            this.password = password;
            this.wins = wins;
            this.losses = losses;
            this.avgTurns = avgTurns;
            this.turns = turns;

        }

        // Methods
        public void UpdateRecord(bool win, int turn) {
            if (win) {
                this.wins++;
                this.turns[turn]++;
                this.avgTurns = GetAvgTurns(turn);
            } else
                this.losses++;
        }

        public int GetAvgTurns(int turn) {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < 6; i++) {
                sum += turns[i] * i;
                count += turns[i];
            }
            return sum / count;
        }

        public string DisplayRecord(string path) {
            string[] records = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();
            result.AppendLine("Player \t\t Wins \t\t Losses \t\t Average turns");

            foreach (string record in records) {
                string[] current = record.Split(", ");

                result.AppendLine($"{current[0]} \t {current[2]} \t\t {current[3]}\t\t\t {current[4]}");

            }
            return result.ToString();
        }


        public void SaveHistory(string path) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.userName}, {this.password}, {this.wins}, {this.losses}, {this.avgTurns}, {this.turns[1]}, {this.turns[2]}, {this.turns[3]}, {this.turns[4]}, {this.turns[5]}, {this.turns[6]}");
            File.AppendAllText(path, sb.ToString());
        }
    }
}