using System;

namespace NewUserApp {

   class Program {
      public static void Main(String[] args) {

      Admin dev1 = new Admin("Hari Smith", 101, true, 18.00);
      Admin dev2 = new Admin("Sam Johnson", 301, true, 19);

      Customer user1 = new Customer("Bojack Nicholas", 234, "New York City", 54.76);

      user1.ShowConfirmation();

      dev1.PrintMessage();
      dev2.PrintMessage();

      dev1.AddPayRaise();
      dev2.RevokeAdmin();



      }
   }
}