using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        MovieRepo mr = new();

        RetrievingMovie(mr); //Tested the MovieRepo - GetMovie()

        //Let's test adding a new movie into our collection. 
        AddingNewMovie(mr);

        //Let's test updating a movie in our collection.
        UpdatingMovie(mr);

        //Let's test deleting a movie in our collection.
        DeletingMovie(mr);
    }

    private static void DeletingMovie(MovieRepo mr)
    {
        //Pick a Movie -> Ask for an ID of a Movie -> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        //Remove that Movie from our storage.
        System.Console.WriteLine("Deleted Movie: " + mr.DeleteMovie(movie));
    }

    private static void UpdatingMovie(MovieRepo mr)
    {
        //Pick a Movie -> Ask for an ID of a Movie -> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        //Let the user update some fields
        System.Console.WriteLine("Please provide a new TItle: ");
        movie.Title = Console.ReadLine() ?? "";
        //And we could add more steps to update more values...

        //Save those changed values to our storage
        movie = mr.UpdateMovie(movie); //this is just separating out the process instead of putting it all in the writeLine
        System.Console.WriteLine("Updated Movie:" + mr.UpdateMovie(movie)); 
        
    }

    private static void AddingNewMovie(MovieRepo mr)
    {
        System.Console.WriteLine("Let's Add in a new Movie");
        System.Console.WriteLine("Please provide a Movie Title: ");
        string title = Console.ReadLine() ?? "";
        System.Console.WriteLine("Please provide a price: ");
        double price = double.Parse(Console.ReadLine() ?? "0"); //the ?? "" means if it is returned as null it will be saved as an empty double (for string just leave the "" blank)
        
        //Let's just assume that the Available will default to true
        //and by extension the returnDate will be 0.

        //Also not going to ask them for an ID - because our MovieRepo - AddMovie() method already gives it the next valid number for an ID

        //Now we need to collect all of this information into a new Movie Object.
        Movie movie = new(0, title, price, true, 0);

        //Now that the information is collected into a Movie Object
        //let's use the MovieRepo to ADD it to our data storage.
        movie = mr.AddMovie(movie);
        //I am just reusing the movie variable to store the updated values (if any) from the AddMovie() process.

        //FOr the sake of clarity to the user of the app, let's inform them of the newly added movie.
        System.Console.WriteLine("Newly Added Movie: " + movie);
     
    }

    private static void RetrievingMovie(MovieRepo mr)
    {
        Movie? retrievedMovie = PromptUserForMovie(mr);
        
        //Easiest way to showcase what Movie we retrieved is to print it out.
        System.Console.WriteLine("Retrieved Movie: " + retrievedMovie);

    }

    //Helper Method
    private static Movie PromptUserForMovie(MovieRepo mr)
    {
        Movie? retrievedMovie = null;
        while (retrievedMovie == null)
        {

            //Let's test retrieving a movie that exists.
            //We have to make a little bit of assumption.
            //The user has to know what kind of IDs might work.
            System.Console.WriteLine("Please enter a Movie ID: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            retrievedMovie = mr.GetMovie(input);
        }
        //Leaving the Loop indicates they have successfully retrieved a movie
        return retrievedMovie;
    }

    //Let's test updating a movie in our collection. 


}