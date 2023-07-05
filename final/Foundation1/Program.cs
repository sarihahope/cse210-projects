using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("I Need a Hero: The Fairy Godmother Song | Shrek 2", "Tune", 45);
        video1._comments.Add(new Comment("user1234", "Shrek! Shrek! Shrek!"));
        video1._comments.Add(new Comment("Shreklover10000", "Who doesn't love Shrek!"));
        video1._comments.Add(new Comment("personusername", "Not the gumdrops!!"));
        videos.Add(video1);



    

        Video video2 = new Video("Squirrels In My Pants - Phineas and Ferb - Official Video", "Disney Music", 130);
        video2._comments.Add(new Comment("Phineas&Ferb", "Squirrels!"));
        video2._comments.Add(new Comment("Shreklover10000", "Who doesn't love Shrek!"));
        video2._comments.Add(new Comment("personusername", "Not the gumdrops!!"));
        videos.Add(video2);



        Video video3 = new Video("Jemaine Clement - Shiny (from Moana) ", "Disney", 224);
        video3._comments.Add(new Comment("Disney4ever", "It'so Shiny!!"));
        video3._comments.Add(new Comment("Username982", "Rock on!"));
        video3._comments.Add(new Comment("personusername", "Under the sea!"));
        videos.Add(video3);

         foreach (Video x in videos)
            {
                Console.WriteLine();
                Console.WriteLine("Title of the video: " + x._title);
                Console.WriteLine("Author of the video: " + x._author);
                Console.WriteLine("Length: " + x._length + " seconds long of a video");
                Console.WriteLine("Number of comments: " + x.CommentCount());
                Console.WriteLine("Comments of the video:");

                foreach (Comment c in x._comments)
                {
                    Console.WriteLine("- " + c._commentAuthor + ": " + c._commentText);
                }
                Console.WriteLine();

            }



    }
}