//Making Methods Practice:
//Takes in two strings and prints both of them twice.
//FInd the largest number between 3 ints.

using System;

class Program
{
    static void Main(string[] args)
    {
        PrintTwice();
        LargestInt();

    }
    

    public static void PrintTwice()
    {
        System.Console.WriteLine("Please enter your first word:");
        string word1 = Console.ReadLine();
        System.Console.WriteLine("You entered: " + word1 + ". Please enter your second word:");
        string word2 = Console.ReadLine();
        System.Console.WriteLine("You entered: " + word2 + ".");
        System.Console.WriteLine(word1 + " " + word2 + " " + word1 + " " + word2);
    }

    public static void LargestInt()
    {
        System.Console.WriteLine("Please enter a number between 1 and 100: ");
        string int1 = Console.ReadLine();
        int firstInt = 0;
        if(int1 != null) firstInt = int.Parse(int1);
        System.Console.WriteLine("You entered " + firstInt + ". Please enter a different number between 1 and 100:");
        string int2 = Console.ReadLine();
        int secondInt = 0;
        if(int2 != null) secondInt = int.Parse(int2);
        System.Console.WriteLine("You entered " + secondInt + ". Please enter another different number between 1 and 100:");
        string int3 = Console.ReadLine();
        int thirdInt = 0;
        if(int3 != null) thirdInt = int.Parse(int3);
        System.Console.WriteLine("You entered " + thirdInt + ".");
        if (firstInt > secondInt)
        if (firstInt > thirdInt)
        {
            System.Console.WriteLine("The largest number is: " + firstInt + ".");
        }
        if (secondInt > firstInt)
        if (secondInt > thirdInt)
        {
            System.Console.WriteLine("The largest number is: " + secondInt + ".");
        }
        if (thirdInt > firstInt)
        if (thirdInt > secondInt)
        {
            System.Console.WriteLine("The largest number is: " + thirdInt + ".");
        }
    }
}


