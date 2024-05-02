class House : Building
{
    public int Bedrooms { get; set; }
    public string? Owner { get; set; }

    public House() : base() 
    {
        System.Console.WriteLine("Now lets make that Building into a House");
        Owner = "";
    }

    public House(int walls, int area) : base(walls, area)
    {
        Owner = "";
        System.Console.WriteLine("Now lets make that building with an area and walls into a House");
    }

    public House(int walls, int area, int bedrooms, string owner) : this(walls, area)
    {
        Bedrooms = bedrooms;
        Owner = owner;
    }

    public override string ToString()
    {
        return "{walls:" + Walls + ",area:" + Area + ",bedrooms:" + Bedrooms + "owner:" + Owner +"}";
    }

}