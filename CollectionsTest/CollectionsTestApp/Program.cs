
namespace CollectionsApp {

    public class Program {

        public static void Main() {
            Console.WriteLine("Starting Timer!");
            Timer myTimer = new Timer();

            TimeSpan runTime = myTimer.Run();
            Console.WriteLine("Total elapsed time is: {0} ms", runTime.TotalMilliseconds);

            Lists newList = new Lists();
            Console.WriteLine($"Count: + {newList.Count}");

            // Console.WriteLine(newList.getNumAtIndex(95));

        }
    }
}