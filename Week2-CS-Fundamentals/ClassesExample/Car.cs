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
}