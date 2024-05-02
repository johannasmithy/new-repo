class Movies
{
    public string? title;
    public string? actor1;
    public string? actor2;
    public string? director;
    public string? genre;
    public int length;

    public Movies()
    {
        title = "";
    }
    public Movies(string title, string actor1, string actor2, string director, string genre, int length)
    {
        this.title = title;
        this.actor1 = actor1;
        this.actor2 = actor2;
        this.director = director;
        this.genre = genre;
        this.length = length;
    }
    public override string ToString()
        {
            string str = "";
            str += "{Title=" + title;
            str += "; Actor1=" + actor1;
            str += "; Actor2=" + actor2;
            str += "; Director=" + director;
            str += "; Genre=" + genre;
            str += "; Length" + length + "}";

            return str;
        }

}