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

        Animal[] animals = new Animal[4];

        animals[0] = d;
        animals[1] = c;
        animals[2] = b;

        ICarnivore[] carnivores = new ICarnivore[3];

        carnivores[0] = d;
        carnivores[1] = c;
        // carnivores[2] = b; // Not a carnivore, cannot add it

        IAdorable[] adorables = new IAdorable[3];

        adorables[0] = b;
        adorables[1] = c;

        TeddyBear t = new();
        adorables[2] = t;
    }
}