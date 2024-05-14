class MovieStorage
{
    /*
    This Entire Setup is TEMPORARY!
    We don't know how to work with Databases yet.
    - by extension- communicate with them. 

    SO we are going to build some devices for Storing Movies. 
    BUT everything is sadly lost every time the application shuts down. 
    */

    public Dictionary<int, Movie> movies = [];

    public int idCounter = 1;

    //Making this constructor give us some pre-loaded Movies to work with. 
    public MovieStorage()
    {
        Movie movie1 = new(idCounter++, "Iron Ham", 5.5, true, 0, null); //this is a pre-increment- will use the value first, then add 1
        Movie movie2 = new(idCounter, "Bravefart", 5.5, true, 0, null); idCounter++; //this is a post-increment - the existing id is set, then one is added outside
        Movie movie3 = new(idCounter++, "Top Fun", 5.5, true, 0, null);

        movies.Add(movie1.Id, movie1);
        movies.Add(movie2.Id, movie2); //Alternative, probably more proper syntax here.
        movies.Add(movie3.Id, movie3);
    }
}