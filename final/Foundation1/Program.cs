using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Videos
        Video v1 = new Video("Serral vs Clem MINE OUT this huge map! (StarCraft 2)", "LowkoTV", 2973);
        Video v2 = new Video("So I Tried Elden Ring | EP 1", "CarbotAnimations", 88);
        Video v3 = new Video("Can You Beat Skyrim With Only A Fork?", "Mitten Squad", 1201);

        // Add Comments
        v1.AddComment("vitorh3568","that Seige Tank... truly MVP");
        v1.AddComment("tiongkiong","7k mmr barcode zerg is like hiding your face by covering your ear");
        v1.AddComment("milesallen1605","Seems clear that the nerf to infestors means even serral now struggles to close out against ghosts");
        v2.AddComment("LeuvahkTrigger","The amount of people who see the 'secret item' text, the blood stains surrounding them, and still jump to make sure is absolutely staggering in this game and I love it.");
        v2.AddComment("LoneWolf-rz3lp","The sheer accuracy of this is what makes it hilarious.");
        v2.AddComment("doomsdayking4843","I love how the Zelda music starts and he starts attacking that dude and giggling. Then gets absolutely destroyed because he clearly missed the tutorial hole.");
        v3.AddComment("StickmanCorp","You should have enchanted the fork with 'Health Absorb' and use it to eat your enemies.");
        v3.AddComment("antivire","Missed opportunity to name your fork wielding orc... Forc");
        v3.AddComment("stupidthefish4981","With one upgrade, he doubled his forks damage. That's impressive");

        // Add Videos to List
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Display Videos
        foreach (var video in videos)
        {
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()} ({video.GetLenSeconds()} seconds & {video.GetNumComments()} comments)");
            Console.WriteLine("________________________________________________________________________________________________________________");
            Console.WriteLine("<<Comments>>");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetComment()}");
            }
            Console.WriteLine();
        }
    }
}