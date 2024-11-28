using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create videos
        Video video1 = new Video("Learning C#", "Code Academy", 600);
        Video video2 = new Video("How to bake a cake", "Caterer", 900);
        Video video3 = new Video("Programming Basics", "Dev Simplified", 720);

        // Step 2: Add comments to videos
        video1.AddComment(new Comment("Andrew", "This was so helpful, thank you!"));
        video1.AddComment(new Comment("Joyce", "Great explanation!"));
        video1.AddComment(new Comment("Charles", "Very clear and concise."));

        video2.AddComment(new Comment("Diana", "I finally understand how to bake a cake now."));
        video2.AddComment(new Comment("Wisdom", "Well explained!"));
        video2.AddComment(new Comment("Beatrice", "Can you make a video on learning how to make pasta?"));

        video3.AddComment(new Comment("Funmi", "Perfect for beginners."));
        video3.AddComment(new Comment("Leonard", "Exactly what I needed."));
        video3.AddComment(new Comment("Ebube", "Straight to the point, loved it."));

        // Step 3: Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Step 4: Display details for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}

// Video class
class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; }
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

// Comment class
class Comment
{
    public string Name { get; private set; }
    public string Text { get; private set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}