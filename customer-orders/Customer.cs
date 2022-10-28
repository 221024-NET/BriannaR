using System;

namespace NewUserApp {

    class Customer {
        // Instance Fields (private by default)
        public string name {get; set;}
        public int orderId {get; set;}
        public string destination {get; set;}
        public double totalPaid {get; set;}

        // Static field - every object shares
        public static bool orderPaid = true;

        // Constructor method
        public Customer(string fullName, int orderNumber, string city, double orderTotal) {
            this.name = fullName;
            this.orderId = orderNumber;
            this.destination = city;
            this.totalPaid = orderTotal;
        }

        // Instance methods, belongs to objects
        public void ShowConfirmation() {
            LoadingMessage();
            Console.WriteLine(name);
            Console.WriteLine($"Shipping to: {destination}");
            Console.WriteLine($"Order Total: {totalPaid}");
            Console.WriteLine($"Order number: {orderId}");
        }

        // Static methods - belong to class
        public static void LoadingMessage() {
            Console.WriteLine("One moment...");
        }

    }
}
