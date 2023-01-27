using AulaStringB.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Comment c1 = new Comment("Have a nice trip!");
        Comment c2 = new Comment("Wow that´s awesome!");

        Post p1 = new Post(
            DateTime.Parse("21/05/2018 13:05:44"),
            "Travaling a New Zealand",
            "I´m going to visit this wonderful country",
            12
             ) ;
        p1.AddComment(c1);
        p1.AddComment(c2);

        Console.WriteLine(p1);
    }
}