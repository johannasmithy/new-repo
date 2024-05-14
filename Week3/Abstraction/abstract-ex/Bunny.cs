class Bunny : Animal, IHerbivore, IAdorable
{
    public override void MakeSound()
    {
        System.Console.WriteLine("chew chomp, what's up, Doc?");
    }


}