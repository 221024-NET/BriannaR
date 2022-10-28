using System;

namespace NewUserApp {

    class Admin {
        // Instance Fields (private by default)
        public string name {get; set;}
        public int id {get; set;}
        public double pay {get; set;}
        public bool isAdmin = true;


        // Static field - every object shares
        public static string location = "Main Office";
        public static double payIncrease =  5.00;

        // Constructor method
        public Admin(string userName, int idNumber, bool isAdmin, double payPerHour) {
        	this.name = userName;
            this.id = idNumber;
            this.pay = payPerHour;
            this.isAdmin = isAdmin;
        }

        // Instance methods, belongs to objects
        public void PrintMessage() {
            Console.WriteLine($"Name: {name}, ID: {id}");
        }

        public void revokeAdmin() {
        	this.isAdmin = false;
            Console.WriteLine("Admin privileges removed");
        }

        public void addPayRaise() {
        	Console.WriteLine($"Current pay per hour: {pay}");
            LoadingMessage();
            Console.WriteLine("Pay increase added");
            Console.WriteLine($"New pay per hour: {this.pay + Admin.payIncrease}");
        }


        // Static methods - belongs to the class itself
        public static void LoadingMessage() {
            Console.WriteLine("One moment...");
        }

    }

}
