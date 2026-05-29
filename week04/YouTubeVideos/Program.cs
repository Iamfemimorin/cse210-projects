using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // VIDEO 1
        Video v1 = new Video("C# Basics", "Code Academy", 600);
        v1.AddComment(new Comment("John", "Very helpful!"));
        v1.AddComment(new Comment("Mary", "I finally understand classes."));
        v1.AddComment(new Comment("Alex", "Great explanation!"));

        // VIDEO 2
        Video v2 = new Video("OOP Explained", "Tech World", 900);
        v2.AddComment(new Comment("Sam", "Abstraction is now clear."));
        v2.AddComment(new Comment("Ella", "Nice examples."));
        v2.AddComment(new Comment("David", "This helped me a lot."));

        // VIDEO 3
        Video v3 = new Video("Game Development Intro", "Unity Hub", 1200);
        v3.AddComment(new Comment("Chris", "I want to build games now!"));
        v3.AddComment(new Comment("Sophie", "Very inspiring."));
        v3.AddComment(new Comment("Mike", "Good starter video."));

        // LIST OF VIDEOS
        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // DISPLAY ALL VIDEOS
        foreach (Video v in videos)
        {
            v.Display();
            Console.WriteLine();
        }
    }
}