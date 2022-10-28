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
            Console.WriteLine($"Name: {name}, ID: {id} \n");
        }

        public void RevokeAdmin() {
        	this.isAdmin = false;
            Console.WriteLine($"Admin privileges removed for {this.name} \n");
        }

        public void AddPayRaise() {
        	Console.WriteLine($"Current pay per hour for {name}: {pay}");
            LoadingMessage();
            Console.WriteLine($"Pay increase added for {this.name}");
            Console.WriteLine($"New pay per hour for {this.name}: {this.pay + Admin.payIncrease} \n");
        }


        // Static methods - belongs to the class itself
        public static void LoadingMessage() {
            Console.WriteLine("One moment...\n");
        }

    }

}
