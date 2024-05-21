class MovieService
{
    /*
        Services:
            - Checkout Movie
            - Checkin Movie
            - View (Your) Checked out Movies
            - View Available Movies 

        Trivial Services:
            -Remember why we organize our application into Layers.
                - It allows us to organize and clearly conceptualize the flow of operations within the app at any given moment of time. 
            - We like to have the app ALWAYS flow Up and Down one Layer at a time!

    //if you need something you communicate to the service layer to do that, the service layer communicates to the data layer
    */
    

    MovieRepo mr;
    public MovieService(MovieRepo mr)
    {
        this.mr = mr;
    }
    public Movie? Checkin(Movie m)
    {
        if (m.Available || m.ReturnDate == 0)
        {
        System.Console.WriteLine("movie not currently checked out");
        return null; //movie doesn't get checked in
        }
        //Update these fields
        m.Available = true;
        m.ReturnDate = 0;

        //Make these changes permanent in the data storage
        mr.UpdateMovie(m);

        return m;

    }

    public Movie Checkout (Movie m)
    {


        //Let's first check to see if the Movie is Available OR let's return null if it's not available.
        if (!m.Available)
        {
            System.Console.WriteLine("move unavailable");
            return null; //Movie is not checked out
        }
        //Happy Path Execution -> Movie is Available, can be checked out
        //What does it mean to check out the movie?
        //1. the movie becomes unavailable
        //2. a returnDate is set.
        //3. (not able to do this yet) set to a particular user.
        

        m.Available = false;
        m.ReturnDate = DateTimeOffset.Now.ToUnixTimeSeconds() + (60*60*24*14 );

        //Make sure to update the data storage with these changes.
        mr.UpdateMovie(m);
        return m;
    }
    public List<Movie> GetAvailableMovies()

    {
        //Get All Movies
        List<Movie> allMovies = mr.GetAllMovies();

        List<Movie> availableMovies = new();

        foreach (Movie movie in allMovies)
        {
            if (movie.Available)
            {
                availableMovies.Add(movie);
            }
        }

        return availableMovies;
        
    }

//A Trivial Service
public Movie? GetMovie(int id)
    {
        return mr.GetMovie(id);
    }
}