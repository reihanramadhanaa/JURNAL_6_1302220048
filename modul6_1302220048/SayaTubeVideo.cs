namespace modul6_1302220048
{
    public class SayaTubeVideo
    {
         int id;
        public String title;
        public int playcount;

        public SayaTubeVideo (String title)
        {
            this.title = title;
            id = generateRandom();
            this.playcount = 0;

        }

        private int generateRandom()
        {
            Random random = new Random();
            return random.Next(0000, 9999);
        }

        public void IncreasePlayCount(int newPlayCount)
        {
            playcount += newPlayCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " +  title);
            Console.WriteLine("Play Count: " + playcount);  

        }

    }
}
