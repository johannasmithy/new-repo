class Child : Parent
{
    public string FavoriteGame { get; set; }
    
    public Child()
    {
        FavoriteGame = "";
    }

    public Child(string jobTitle, string favoriteGame) : base(jobTitle)
    {
        FavoriteGame = favoriteGame;
    }

    public void Play()
    {
        System.Console.WriteLine("Playing my favorite game: " + FavoriteGame);
    }

//This is now an overridden Method which changes its implementation for this Class ONLY.
    public override void Work()
    {
        System.Console.WriteLine("Doing my homework to get good grades!");
    }
}