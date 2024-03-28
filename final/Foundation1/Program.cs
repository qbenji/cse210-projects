using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Videos
        Video v1 = new Video("Serral vs Clem MINE OUT this huge map! (StarCraft 2)", "LowkoTV", 2973);
        Video v2 = new Video("Title 2", "Author 2", 240);
        Video v3 = new Video("Title 3", "Author 3", 360);

        // Add Comments
        v1.AddComment("","");
    }
}