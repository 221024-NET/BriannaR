using System;

namespace CollectionsApp {
    public class Program {
        public static void Main() {
            Console.WriteLine("Starting!");
            Timer myTimer = new Timer();

            TimeSpan runTime = myTimer.Run();
            Console.WriteLine("Total elapsed time is: {0} ms", runTime.TotalMilliseconds);
        }
    }
}