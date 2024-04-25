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
        for(var i=0; i<3; i++){
            System.Console.WriteLine(word1 + " " + word2);
        }

        
    }

    public static void LargestInt()
    {
        int[] input = new int[3];
        System.Console.WriteLine("Please enter a number between 1 and 100: ");
        for(int i=0; i<3; i++){
            
            input[i] = int.Parse(Console.ReadLine());
            System.Console.WriteLine("You entered " + input[i] + ". Please enter a different number between 1 and 100:");
        }
        
        // int firstInt = 0;
        // if(input[0] != null) firstInt = int.Parse(input[0]);
        
        // input[1] = Console.ReadLine();
        // int secondInt = 0;
        // if(input[1] != null) secondInt = int.Parse(input[1]);
        // System.Console.WriteLine("You entered " + secondInt + ". Please enter another different number between 1 and 100:");
        // input[2] = Console.ReadLine();
        // int thirdInt = 0;
        // if(input[2] != null) thirdInt = int.Parse(input[2]);
        // System.Console.WriteLine("You entered " + thirdInt + ".");


        // if (input[0] > input[1])
        // {
        //     if (input[0] > input[2])
        //         {
        //             System.Console.WriteLine("The largest number is: " + input[0] + ".");
        //         }
        // }
        
        // if (input[1] > input[0])
        // if (input[1] > input[2])
        // {
        //     System.Console.WriteLine("The largest number is: " + input[1] + ".");
        // }
        // if (input[2] > input[0])
        // if (input[2] > input[1])
        // {
        //     System.Console.WriteLine("The largest number is: " + input[2] + ".");
        // }

        var maxValue = 0;

        foreach (var num in input)
        {
            if (num > maxValue)
                maxValue = num;
        }
        System.Console.WriteLine("The largest number is: " + maxValue);
    }
}


