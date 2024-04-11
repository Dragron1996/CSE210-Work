using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new();

        void DisplayVideo()
        {
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine($"Video{count} - 4k");
                video.DisplayData();
                Console.WriteLine("\nComments:");
                video.DisplayComment();
            }
        }

        
        Video video1 = new();
        Video video2 = new();
        Video video3 = new();
        
        Comments comment = new("Tualla", "Love you!! You're amazing");

        
        video1.SetMeta("Jason the Baller", "Awesome new credit card", 10);
        video1.SetComment(comment);
        
        comment = new("David", "Bad investment");
        video1.SetComment(comment);
        
        comment = new("Elise", "Love the new video");
        video1.SetComment(comment);
        
        videos.Add(video1);

        
        video2.SetMeta("Yamamotto", "The Last Hero", 30);
        comment = new("nobunaga", "If only I saw you at your prime");
        video2.SetComment(comment);
        
        comment = new("Miyomoto", "He would have been my first lost");
        video2.SetComment(comment);
        
        comment = new("Masamune", "Can you do the same with only one eye?");
        video2.SetComment(comment);
        
        videos.Add(video2);

        
        video3.SetMeta("Aang", "How I learn airbender", 10);
        comment = new("Katara", "Now do this with water");
        video3.SetComment(comment);
        
        comment = new("Toph", "Great video, twinkle toes!");
        video3.SetComment(comment);
        
        comment = new("Zuko", "Toph how can you comment when you're blind");
        video3.SetComment(comment);
        
        videos.Add(video3);
        DisplayVideo();

    }
    
}