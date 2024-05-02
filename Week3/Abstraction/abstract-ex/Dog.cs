class Dog : Animal, ICarnivore
{

    public string FavoriteChewToy { get; set; }
    public int Value { get; set; }

    public Dog()
    {
        FavoriteChewToy = "";
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Bark bark bark");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats some dog chow");
    }
}