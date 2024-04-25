        /*
        Problem: Often we have chunks of code that perform some operation that we'd like to potentially use again later in our program. 
        Right now, our only means to do is to simply copy/paste that chunk of code to repeat its intended functionality.

        Methods - Allow us to recall a chunk of code all consolidated to one place as often as we like, while simultaneously abstracting away the implementations 
        behind achieving such functionality, alllowing us to focus soley on said chunk of code.

        gives us a sense of re-usability
        gives us a set of lines of code we can re-use
        */

        // AddNumbers(1, 2);
        // AddNumbers(6, 10);

        // int result = SquareNumber(5);
        // System.Console.WriteLine(result);

        // SayHello();

       

using System;

class Program
{
    static void Main(string[] args)
    {


        PrintMenu();

        int cmd = GetCmd();

        switch (cmd)
        {
            case 1:
                {
                    SayHello();
                    break;
                }
            case 2:
                {
                    ProcessAddNumbers();
                    break;
                }
            case 3:
                {
                    ProcessSquareNumber();
                    break;
                }
        }
    }

    public static void PrintMenu()
    {
        System.Console.WriteLine("Welcome to our app");
        System.Console.WriteLine("Please enter a command: ");
        System.Console.WriteLine("[1] Say Hello");
        System.Console.WriteLine("[2] Add two numbers");
        System.Console.WriteLine("[3] Square a number");
    }

    public static int GetCmd()
    {
        string? input = Console.ReadLine();
        int cmd = 0;
        if (input != null) cmd = int.Parse(input);
        return cmd;
    }

    public static void ProcessAddNumbers()
    {
        System.Console.WriteLine("Enter 1st number:");
        string? value1 = Console.ReadLine();
        System.Console.WriteLine("Enter 2nd number:");
        string? value2 = Console.ReadLine();

        int num1 = 0, num2 = 0;
        if (value1 != null) num1 = int.Parse(value1);
        if (value2 != null) num2 = int.Parse(value2);

        AddNumbers(num1, num2);
    }

    public static void ProcessSquareNumber()
    {
        System.Console.WriteLine("Enter a Number: ");
        string? value1 = Console.ReadLine();

        int num1 = 0;
        if (value1 != null) num1 = int.Parse(value1);

        System.Console.WriteLine(SquareNumber(num1));
    }

    //Lets make a method that simply adds two numbers together (and prints that out)
    //Method Signature Syntax: access_modifier return_type MethodName(parameterType parameterName, paramType, paramName2) {}

    public static void AddNumbers(int num1, int num2)
    {
        // int result = num1 + num2;
        // System.Console.WriteLine(result);

        System.Console.WriteLine(num1 + num2);
    }

    public static void SayHello()
    {
         //Print out this welcome message
        System.Console.WriteLine("Please enter your name: ");
        string? input = Console.ReadLine();
        System.Console.WriteLine("===================");
        System.Console.WriteLine("= Hello, " + input + "!");
        System.Console.WriteLine("===================");

        //OR make a method that does all this
    }

    //Lets make a method that RETURNS the squared value of a number. 
    public static int SquareNumber(int num1)
    {
        int square = num1 * num1;
        return square;
    }

//Making Methods Practice:
//Takes in two strings and prints both of them twice.
//FInd the largest number between 3 ints. 

}