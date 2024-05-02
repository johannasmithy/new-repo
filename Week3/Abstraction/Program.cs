namespace Abstraction;


class Program
{
    static void Main(string[] args)
    {
        // Animal a = new Animal(); //Cannot create an instance of the abstract type or interface 'Animal'
        Dog d = new();
        d.Sleep();
        d.MakeSound();
        d.Species = "Border Collie";
        d.FavoriteChewToy = "Bone"; //Specific to Dogs
        d.EatMeat();

        d.Value = 100;
        System.Console.WriteLine(d.Value);

        System.Console.WriteLine("---------");

        Cat c = new();
        c.Sleep();
        c.MakeSound();
        c.Species = "caliby";
        // c.FavoriteChewToy = "mouse"; //this was only created in Dog so not available to Cat
        c.EatMeat();
        
        System.Console.WriteLine("-----------");
        Bunny b = new();
        b.MakeSound();
        b.Sleep();
        // b.EatPlant(); Not working for unknown reason per Ryan
    }
}