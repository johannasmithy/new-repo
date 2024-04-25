class Car
{
    //Fields
    public string color;
    public string make;
    public string model;
    public int year;
    public int mileage;
    
    // //another option if you don't write public in front of each field is to create a method like below
    // public string GetColor()
    // {
    //     return color;
    // }


    /*
    Constructors- a special type of method whose purpose is to help us create new objects of that class. 
    Along with any other initial set up instructions we wish to provide. 

    Syntax: 
    access_modifier ClassName(potential parameters)
    {
        //what you want the constructor to do while setting up your object.
            -setting initial values is common
    }

    C# will provide a "default" constructor when you do not explicitly create any constructors.
    As soon as you create even one constructor, the default constructor is no longer provided.

    */

    public Car()
    {
        color = "Black";
    }

    //We can have multiple constructors - the only requirement is that the parameters have to be some new unique combination of types.
    //Overloaded Methods -> Have multiple implementation to the same named method - with different

    public Car(string color)
    {
        // color = newColor;
        this.color = color;
    }

    //Full-Arg Constructor - meaning a choice of us providing ALL the values for our fields.

    public Car(string color, string make, string model, int year, int mileage)
    {
        this.color = color;
        this.make = make;
        this.model = model;
        this.year = year;
        this.mileage = mileage;
    }

    //Bonus
    //Copy Constructor

    public Car(Car other)
    {
        color = other.color;
        make = other.make;
        model = other.model;
        year = other.year;
        mileage = other.mileage;
    }
    //Methods
    public void Honk()
    {
        System.Console.WriteLine("Honk Honk!");
    }

    public void Drive(int miles)
    {
        mileage += miles;
        System.Console.WriteLine("The new total mileage is: " + mileage);
    }

    public override string ToString()
    {
        string str = "";
        str += "{Color=" + color;
        str += "; Make=" + make;
        str += "; Model=" + model;
        str += "; Year=" + year;
        str += "; Mileage=" + mileage + "}";

        return str;
    }


}