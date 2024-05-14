
class MovieRepo
{
    /*
    This class is in the Data Access / Repository Layer of our application.
    So it is solely responsible for any data access and management centered around our Movie Object.

    4 Major Operations we'd like to manage in this location.
        - CRUD Operations
        - C - Create
        - R - Read
        - U - Update
        - D - Delete
    */

    MovieStorage movieStorage = new();
    public Movie AddMovie(Movie m)
    {
        //We need to first ensure that the movie being added has a correct ID.
        //Assume it doesn't and force it to have a correct ID using our idCounter.
        m.Id = movieStorage.idCounter++; //incrementing the value afterwards to prep it for the next time it's needed. 

        //Add the movie into our collections. 
        movieStorage.movies.Add(m.Id, m);
        return m;
    }

    public Movie? GetMovie(int id)
    {
        if (movieStorage.movies.ContainsKey(id))
        {
            Movie selectedMovie = movieStorage.movies[id];
            return selectedMovie;
            // return movieStorage.movies[id]; simpler approach
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try AgainT");
            return null;

        }
    }

    public Movie? UpdateMovie(Movie updatedMovie)
    {
        //Assuming that the ID is consistent with an ID that exists, then we just have to update the value (aka Movie Object for our scenario) for said ID (key)
        try
        {

            movieStorage.movies[updatedMovie.Id] = updatedMovie;
            return updatedMovie;
        }
        catch (Exception e)//can name the exception or, since we aren't printing it (or doing anything with it), we can remove the exception name.
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

    public Movie? DeleteMovie(Movie m)
    {
        

        //If we have the ID -> then simply Remove it from storage
        bool didRemove = movieStorage.movies.Remove(m.Id);
        if (didRemove)
        {
            //now we will return the movie that got deleted
            return m;
        }
        else
        {
        System.Console.WriteLine("Invalid Movie ID - Please Try Again");
        return null;
        }

    }

    public List<Movie> GetAllMovies()
    {
        //I am chooseing to return a List because that is a much more common collection to
        //work with. It does mean I have to do a little bit of work here - but its not bad.
        return movieStorage.movies.Values.ToList();
    }
}