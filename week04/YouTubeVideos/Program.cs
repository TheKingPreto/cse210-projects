using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    public override string ToString()
    {
        return $"Comment by {CommenterName}: {CommentText}";
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } 
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        var newComment = new Comment(commenterName, commentText);
        Comments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine(comment);
        }
        Console.WriteLine(new string('-', 40));
    }
}

public class Program
{
    public static void Main()
    {
        Video video1 = new Video("How to Make a Website", "John Doe", 300);
        video1.AddComment("Alice", "Great tutorial, thanks!");
        video1.AddComment("Bob", "I learned a lot, but I wish you explained CSS more.");
        video1.AddComment("Charlie", "This was awesome!");

        Video video2 = new Video("Learn Python in 10 Minutes", "Jane Smith", 600);
        video2.AddComment("David", "This was super helpful!");
        video2.AddComment("Eve", "I had trouble with the third step.");
        video2.AddComment("Frank", "Fantastic! I now feel confident about Python.");
        video2.AddComment("Grace", "Could you please explain the last section more?");

        Video video3 = new Video("Top 10 JavaScript Tips", "Mike Brown", 400);
        video3.AddComment("Hannah", "Great tips, thanks for the insights!");
        video3.AddComment("Ivy", "This was really helpful for my project.");

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
