using System.Diagnostics;

class Calculator
{

/*
Polymorphism -> Many Forms -> an entity can exist with multiple labels attached to it all at the same time.

Static Polymorphism - Overloading
    - We can have multiple methods with the same name, the only requirement is that they each have a unique set of parameters. 
        - change the quantity of parameters (based strictly on DataTypes.)
        - change the type
        - change the order (permutation?)

Dynamic Polymorphism - Overriding
    - We can change the implementation of methods that we inherit into a new Child Class to fit the narrative of our new class.
        - C# does require for you to specify that a method can be overridden                         - virtual
        - and by extension, you must explicitly declare that you are overriding an implementation    - override
*/

public static int Add(int num1, int num2)
{
    return num1 + num2;
}

//Both versions of this method can exist at the same time b/c C# can always identify which version of the Add() method we'd want to use at any given moment in time.

public static int Add(int num1, int num2, int num3)
{
    return num1 + num2 + num3;
}

public static double Add(string num1, string num2)
{
    return double.Parse(num1) + double.Parse(num2);
}

public static double Add(double num1, string num2)
{
    return num1 + double.Parse(num2);
}

public static int Add()
{
    return 0;
}

public static int Add(int[] array)
{
    int sum = 0;
    foreach (int num in array)
    {
        sum += num;
    }
    return sum;
}

//params -> parameter array argument. Essentially lets you provide a variable number of arguments to satisfy this one parameter, 
//in which it will 'collect' them into one array for us. 
//you can only have 1 parameter array per method
//it MUST be the LAST parameter in the method.
public static double Add(params double[] array)
{
    double sum = 0;
    foreach (double num in array)
    {
        sum += num;
    }
    return sum;
}

public static int Add(int[] array1, int[] array2, int[] array3)
{
    return 0;
}

//can you use parameter array with other data types like strings?
public static int Add(params string[] array)
{
    string str;
    return 0;
}
}