using System;
using System.Collections.Generic;

public class Comment
{
    // Properties to store the name and text of the comment
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the comment
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // Method to return a string representation of the comment
    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}

public class Video
{
    // Properties to store video information
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    public List<Comment> Comments { get; set; }

    // Constructor to initialize the video
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments for the video
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("Python Tutorial for Beginners", "John Doe", 120);
        Video video2 = new Video("Advanced Python Programming", "Jane Smith", 150);
        Video video3 = new Video("Understanding Object-Oriented Programming", "Mike Brown", 200);
        
        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great video! Very helpful for beginners."));
        video1.AddComment(new Comment("Bob", "I learned so much, thanks!"));
        video1.AddComment(new Comment("Charlie", "Nice explanations!"));
        
        // Add comments to video2
        video2.AddComment(new Comment("Eve", "The concepts here are advanced but interesting."));
        video2.AddComment(new Comment("David", "Amazing content!"));
        
        // Add comments to video3
        video3.AddComment(new Comment("Grace", "This really helped me understand OOP better."));
        video3.AddComment(new Comment("Hank", "Good video but could use more examples."));
        video3.AddComment(new Comment("Ivy", "Excellent breakdown of classes and objects."));
        video3.AddComment(new Comment("Jack", "Great depth into OOP, very informative."));
        
        // Put all videos into a list
        List<Video> videos = new List<Video> { video1, video2, video3 };
        
        // Iterate through each video and display its details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Video Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Display all comments for the video
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment}");
            }
            Console.WriteLine("\n" + new string('-', 40) + "\n");  // Separator between video entries
        }
    }
}
