namespace modul6_1302220048
{
    internal class SayaTubeUser
    {
        int id;
        String Username;
        private  List<SayaTubeVideo> uploadVideos;
    
        public SayaTubeUser(String Username)
        {
            this.Username = Username;
            id = generateRandomid();
            uploadVideos = new List<SayaTubeVideo> ();
         }

        public int generateRandomid()
        { 
          Random random = new Random();
          return random.Next(0000, 9999);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;  
            foreach (SayaTubeVideo video in uploadVideos)
            {
                total += video.playcount; 
            }
             
            return total;

        
        }

        public void AddVideo(SayaTubeVideo video)
        {

           uploadVideos.Add(video);

        }

        public void PrintAllVideoPLayCount()
        {
            Console.WriteLine("User: " + Username);
            Console.WriteLine("Video 1 Judul: "  );
            Console.WriteLine("Video 1 Judul: "  );
        }

        public string GetUsername () 
        {
            return Username;
        }

    }
}
