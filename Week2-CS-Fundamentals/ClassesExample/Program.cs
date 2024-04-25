using System;

class Program
{
    static void Main(string[] args)
    {
        // int num = 1;
        // string word = "Hello";

        //Object Declaration and Instantiation (Initialization)
        Object obj1 = new Object();
        Object obj2 = new();
        Object obj3 = new();

        DateTime currentTime = DateTime.Now;
        System.Console.WriteLine(currentTime);

        Car car1 = new Car();
        System.Console.WriteLine(car1);

        car1.color = "Blue";
        car1.make = "Jeep";
        car1.model = "Cherokee";
        car1.year = 2021;

        System.Console.WriteLine(car1.color);
        System.Console.WriteLine(car1.make);
        System.Console.WriteLine(car1.model);
        System.Console.WriteLine(car1.year);

        System.Console.WriteLine("Year" + car1.year + " Make" + car1.make + " Model" + car1.model);

        car1.Honk();
        car1.Drive(100);
        car1.Drive(100);

        //ToString method
        //Copying Object references
        //Properties
        //Constructors
        //Scopes (static keyword)
        //Access modifiers

        //Inheritance
        //Polymorphism - overloaded methods / overridden methods
    }
}