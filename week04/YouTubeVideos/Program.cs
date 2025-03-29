using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Creating video objects
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        Video video2 = new Video("Object-Oriented Programming", "Jane Smith", 450);
        Video video3 = new Video("Design Patterns in C#", "Mike Johnson", 600);

        // Adding comments to videos
        video1.AddComment(new Comment("Alice", "Great introduction!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I love C#!"));

        video2.AddComment(new Comment("David", "OOP is amazing!"));
        video2.AddComment(new Comment("Eve", "This makes things so clear."));
        video2.AddComment(new Comment("Frank", "Great examples!"));

        video3.AddComment(new Comment("Grace", "Design patterns are powerful."));
        video3.AddComment(new Comment("Hank", "Well explained."));
        video3.AddComment(new Comment("Ivy", "Helped me a lot, thanks!"));

        // Storing videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying video details and comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
