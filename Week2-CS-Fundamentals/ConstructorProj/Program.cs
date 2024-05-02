using System;
class Program
{
        //Create a new project
        //pick any object in the world (pizza, house, etc)
        //create  your own class for it
        //give it fields
        //give it methods
        //try out a ToString
        //try out a couple constructors - no-Arg and Full-Arg
        //come into your main file/method
        //create a couple objects of your class
        //test out the various methods you've created.

    static void Main(string[] args)
    {
        Movies movie1 = new("Indy Jonesy 100", "Harry Forb", "Phoebus Bridgerton", "Stevie Schpiel", "Action! Adventure!", 2000);
        System.Console.WriteLine(movie1);

        Movies movie2 = new();
        movie2.title = "Star Pours";
        movie2.actor1 = "Marky Hamilton";
        movie2.actor2 = "Carries Fishing";
        movie2.director = "Georgie Luca";
        movie2.genre = "Space Opera LOL";
        movie2.length = 120;

        System.Console.WriteLine(movie2.ToString);
    }
}