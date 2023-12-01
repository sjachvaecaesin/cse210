using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments;
        Comment comment;

        comments = new List<Comment>();
        comment = new Comment("Jaci Lawson", "What a fascinating video!");
        comments.Add(comment);
        comment = new Comment("Tyler Jerry", "How did I even get here?");
        comments.Add(comment);
        comment = new Comment("Madyson Jeannine", "I never knew that about ants :o");
        comments.Add(comment);

        Video video1 = new Video("Stewart Shari", "The World of Ants", 6000, comments);
        videos.Add(video1);

        comments = new List<Comment>();
        comment = new Comment("Daria Artie", "For how short it was, that was surprisingly accurate.");
        comments.Add(comment);
        comment = new Comment("Tyler Jerry", "Sleep playlists take you to some weird places.");
        comments.Add(comment);
        comment = new Comment("Leon Karen", "What a crazy world that must've been.");
        comments.Add(comment);

        video1 = new Video("Kristin Beckett", "A Brief History of the Mongols", 300, comments);
        videos.Add(video1);
        
        comments = new List<Comment>();
        comment = new Comment("Cora Roxy", "I like to come here just to relax sometimes.");
        comments.Add(comment);
        comment = new Comment("Tyler Jerry", "I'm a world traveler at this point.");
        comments.Add(comment);
        comment = new Comment("Vinnie Editha", "Twilight Zone was such a classic show");
        comments.Add(comment);


        video1 = new Video("Radclyffe Mamie", "Welcome to the Twilight Zone", 1200, comments);
        videos.Add(video1);

        foreach(Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}