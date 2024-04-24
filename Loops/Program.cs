// // See https://aka.ms/new-console-template for more information

// /*
// Condition continues to be true.
//     - The condition is reassessed after each "iteration" of the loop, before executing the loop again.

//     -While Loop
//         -Do-While Loop
//         -Best used when the number of outcomes needed by the loop is not known / non-deterministic
    
//     -For Loop
//         -Foreach Loop
//         -Best used the number of iterations needed by the loop is known/calculable/Finite. 
// */

// //Print the numbers 1-100


// // System.Console.WriteLine(counter); //example of how to do this manually which would take forever
// // counter++;
// // System.Console.WriteLine(counter);

// /*
// while (condition)
// {
//     //code to execute while condition is true.
// }
// */

// using System.Globalization;

// int counter = 1;
// while (counter <= 100)
// {
//     System.Console.WriteLine(counter);
//     counter++;
// }
// System.Console.WriteLine("End of Program");

// //Print the Sum of the numbers 1-100

// counter = 1;
// int sum = 0;
// while (counter <= 100)
// {
//     sum += counter;
//     counter++;
// }
// System.Console.WriteLine("The sum of the numbers 1-100 is: " + sum);

/*
Guessing Game - Make a new Project
    -Start with the assumed range of numbers 1-100
    -Prompt the user to Enter a number in said range
    -Tell the user if the numbre is Higher, lower, or equal to <some number of your choice>
        -If equal, they win the guessing game. Yay!
        -If higher or lower, let them guess again!
        -The while loop essentially needs to contain 
            -prompting the user,
            -retrieving their guess,
            -telling them higher, lower, or correct
            -while (guess != correctChoice) -> run the loop again

    Bonuses:
        -Introduce yourself to some other libraries (the random class) to help you randomize the correct answer

    Extra Bonus:
        -The user is prompted to play again, without having to restart your application
*/

//Monday: continuing loops

//Input Validation
//Tell the user to print out the number: 5
// int num = 0;
// while (num != 5)
// {
//     System.Console.WriteLine("Please input the number: 5");
//     string? input =  Console.ReadLine();

//     if (input != null) num = int.Parse(input);

//     if (num != 5)
//     {
//         System.Console.WriteLine("Please try again");
//     }
// }
// if(num == 5)
// {
//     System.Console.WriteLine("Good job, you followed the instructions");
// }
// else
// {
//     System.Console.WriteLine("you failed, you dummy");
// }

// if (num != 5)
// {
//     System.Console.WriteLine("Please Try Again");
// } 
// }

// //Down here is for when the loop is done - they input the correct value

// System.Console.WriteLine("you got it right, you enetered " + num");

//^figure this out later

//Do-While Loop
//Do-While Loops, as opposed to just while loops, will always execute AT LEASt once. Before catching the condition.
/*

*/
int num = 0;
// do
// {
//     System.Console.WriteLine("Please input the number 5");
//     string? input = Console.ReadLine();

//     if (input != null) num = int.Parse(input);

//     if (num != 5) 
//     {
//         System.Console.WriteLine("Please try again");
//     }
// }
// while (num !=5);


//For Loops
/*
Best used when the number of iterations is known/calculable.
for (initialization; condition; update)
{

}
*/

//Print the numbers 1-100
for(int count = 1; count <= 100; count++)
{
    System.Console.WriteLine(count);
}

//Print the sum of the numbers 1- 10000
int sum2 = 0;
for(int count = 1; count <= 10000; count++)
{
    sum2 += count;
}
System.Console.WriteLine(sum2);



//Print only even numbers 2-200
for(int i = 2 ; i <= 200; i += 2)
{
    System.Console.WriteLine(i);
}

//Print all numbers starting with 50 going to 25
for(int i = 50; i >= 25; i--)
{
    System.Console.WriteLine(i);
}

// Nesting Loops
/*
    -Any control flow can put coded / nested into any other control flow. 
        -Therefore Loops can be built inside other loops.
        -However, we should exercise caution, we could potentially develop scenarios that will drastically increase processing time.
    -Problem:
        -Single Loop -> 100 iterations -> 100 Processes
        -Nested Loop -> 100 iterations inside 100 iterations -> 10,000 Processes
        -Quadratic Growth of Time
*/

// Build a square out of * of whatever size we want.
System.Console.WriteLine("--------------------");
int size = 4;

for(int i = 1; i <= size; i++)
{
    for(int j = 1; j <+ size; j++)
    {
        System.Console.Write("* ");
    }
    System.Console.WriteLine();
}

//Staircase challenge
//Print 1 * for the first line. Then 2 * for the second line, etc...


System.Console.WriteLine("-------------------");
size = 5;
// The outer loop deals with namaging additional rows / Steps
for(int i = 1; i <= size; i++)
{
    //The inner loop deals with managing the contents of each row / step
    for(int j = 1; j <= i; j++)
    {
        System.Console.Write("* ");
    }
    System.Console.WriteLine();
}

//Staircase challenge continued.
//There are 3 other directions the staircase can face. 
//Build them all
//

/*
Right Facing
    *
   **
  ***
 ****


*/
// - Afterwards, solve any of them with a single loop

//Guessing game bonus bonus
//Adjust the range in which you tell the user to guess based on their previous wrong answers. 
//(tell them to guess between the lowest high guess and the highest high guess) ex. right answer is 55, they guessed 50. tell them their guess was too low, guess between 51-100
//Allow the user to pick the numbers that they will guess between when the game starts.
//Keep track of the number of guesses, tell them how many guesses it took them to win the game. 


//Foreach Loop
/*
Best used when iterating (once) over each item of a collection of values. 
*/

//Before foreach
string word = "Hello";
for (int i = 0; i< word.Length; i++)
    {
    System.Console.WriteLine(word[i]);
    }

System.Console.WriteLine("---------FOREACH LOOP------------");
//Foreach Loop
foreach (char c in word)
{
    System.Console.WriteLine(c);
}

System.Console.WriteLine("---------Staircase Challenge----------");

size = 5;
// The outer loop deals with namaging additional rows / Steps
for(int i = 1; i <= size; i++)
{
    //The inner loop deals with managing the contents of each row / step
    for(int j = 1; j <= i; j++)
    {
        System.Console.Write("* ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("---");

// The outer loop deals with managing additional rows / Steps
size = 5;
for(int i = 0; i < size; i++)
{
    //The inner loop deals with managing the contents of each row / step
    for(int j = 0; j < size; j++)
    {
        if(j < size - i - 1)
            System.Console.Write("  ");
        else
            System.Console.Write("* ");
    }
    System.Console.WriteLine();
    
}
System.Console.WriteLine("---");

size = 5;
// The outer loop deals with namaging additional rows / Steps
for(int i = 5; i <= size; i++)
{
    //The inner loop deals with managing the contents of each row / step
    for(int j = 0; j <= i; j++)
    {
        System.Console.Write("* ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("---");

