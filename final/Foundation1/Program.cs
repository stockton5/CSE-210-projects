using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();
            Video v1 = new Video("How to Shoot a Bow", "Jared Hammer", 420);
            v1.AddComment(new Comment("Adam", "Great tutorial!"));

            Video v2 = new Video("C# Classes Explained", "CodeAcademy", 600);
            v2.AddComment(new Comment("Mike", "Very clear explanation."));
            videos.Add(v2);

            Video v3 = new Video("Idaho Mule Deer Hunt", "Backcountry Hunter", 890);
            v3.AddComment(new Comment("HunterJoe", "Beautiful country."));
            videos.Add(v3);
            foreach (Video video in videos)
            {
                Console.WriteLine("====================================");
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Program complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}