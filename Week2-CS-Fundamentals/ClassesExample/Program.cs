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

        Car car2 = new();
        car2.color = "Silver";
        car2.make = "Honda";
        car2.model = "Accord";
        car2.year = 2020;

        System.Console.WriteLine("Car 1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);

        car2.Drive(50);
        System.Console.WriteLine("==After Driving Car 2 some more===");
        System.Console.WriteLine("Car 1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);

        Car car3 = car2;
        System.Console.WriteLine("Car 3 Color: " + car3.color);
        System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);
        //Are car3 and car2 the SAME car? or just borrowing the same initial value?
        car3.Drive(50);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);
        System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);

        System.Console.WriteLine("Car 1 info: " + car1.ToString());
        
        Car car4 = new Car();
        Car car5 = new Car("Silver");
        Car car6 = new Car("Yellow", "Volkswagen", "Beetle", 2005, 10000);

        //How to copy over one object's values to another object.
        //No-arg
        Car car8 = new();
        car8.color = car6.color;
        car8.make = car6.make;
        car8.model = car6.model;
        car8.year = car6.year;
        car8.mileage = car6.mileage;
        //Full-arg
        Car car9 = new(car6.color, car6.make, car6.model, car6.year, car6.mileage);
        //Copy
        Car car10 = new(car6);

        //Create a new project
        //pick any object in the world (pizza, house, etc)
        //create  your own class for it
        //give it fields
        //give it methods
        //try out a ToString
        //try out a couple constructors - no-Arg and Full-Arg
        //come into your main file/method
        //create a couple objects of your class
        //test out the various methods you've created.


    }
}