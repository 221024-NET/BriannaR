namespace CollectionsApp {
    public class Lists {
        // Fields
        List<int> bigList = new List<int>(1000);


        public Lists() {
            for(int i = 0; i < this.bigList.count; i++) {
                bigList.Insert(i, i * 5);
            }
        }


        // Methods







    }
}