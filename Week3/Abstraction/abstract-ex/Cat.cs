class Cat : Animal, ICarnivore, IAdorable
{
    public int Value { get; set; }

    public override void Sleep()
    {
        System.Console.WriteLine("curls into fluff ball");
    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Meow Brrrrreow!");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats some stinky cat food");
    }
}