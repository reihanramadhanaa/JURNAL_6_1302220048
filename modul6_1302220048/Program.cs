using modul6_1302220048;

internal class Program
{
    private static void Main(string[] args)
    {
      SayaTubeUser user = new SayaTubeUser("Dhana");
        String[] judul = new String[]
        {
            "Upin dan ipin",
            "boboboy",
            "godzilla",
            "Avanger",
            "Spiderman",
            "Ironman",
            "Batman",
            "Captain America",
            "Tanos",
            "Thor"
        };

        for (int i = 0; i < judul.Length; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo("Review film : " + judul[i] + "oleh" + user.GetUsername);
            video.IncreasePlayCount(100);
            Console.WriteLine("Menambahkan File:");
            video.PrintVideoDetails();
            user.AddVideo(video);
        
        }

        user.PrintAllVideoPLayCount();
        user.GetTotalVideoPlayCount();

      }
}