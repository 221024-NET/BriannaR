namespace CollectionsApp {
    public class Lists {
        // Fields
        List<int> bigList = new List<int>(500);
        // Random rand = new Random();


        public Lists() {
            for (int i = 0; i < this.bigList.Count; i++) {
                bigList.Insert(i, i * 5);
            }

            // for (int i = 0; i < this.bigList.Count; i++) {
            //     bigList.Add(rand.Next(501));
            // }
        }

        // Methods









    }
}