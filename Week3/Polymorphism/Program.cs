using System;

class Programs
{
    static void Main(string[] args)
    {
        // OverloadEx();
        OverrideEx();
    }

    private static void OverloadEx()
    {
        System.Console.WriteLine(Calculator.Add(4, 5));
        System.Console.WriteLine(Calculator.Add(4, 5, 6));
        System.Console.WriteLine(Calculator.Add(12.34, "1234"));

        int[] numbers = [1, 2, 3];
        System.Console.WriteLine(Calculator.Add(2.5, 3.5, 7.8, 2, 0.2, 2.9, 3.3, 4.4));
    }

public static void OverrideEx()
{
    Parent p = new();
    p.JobTitle = "Engineer";
    p.Work();

    Child c = new();
    c.JobTitle = "Student";
    c.FavoriteGame = "Minecraft";
    c.Play();
    c.Work();

    GrandChild g = new();
    g.FavoriteGame = "Shapes";
    g.JobTitle = "Senior Associate Whatever";
    g.Play();
    g.Work();

    //Back to Parent
    System.Console.WriteLine("-------");

    System.Console.WriteLine(p.ToString());
    System.Console.WriteLine(c);
    System.Console.WriteLine(g);

    System.Console.WriteLine("----------");
    //(Somewhat) Bonus Knowledge --- turn back now!---Save yourself!

    Parent p2 = new();
    Parent p3 = p2;

    //Parent Object qualities, methods behaving as the derived class Child is implemented

    Parent pc = new Child();
    pc.JobTitle = "Blah";
    pc.Work();

    // Child c2 = new Parent(); // doesnt work the other way

    //slight detour - Casting
    System.Console.WriteLine("----------");

    int num1 = (int)2.5;
    System.Console.WriteLine(num1);
    // Child c2 = (Child)p; //Cast does not work because 'p' can only work and have JobTitle- not enough to make a child object.
    Child c2 = (Child)pc; //works because it points to the child area in memory so it has access to the other functions a child needs. 




}
}