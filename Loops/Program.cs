// See https://aka.ms/new-console-template for more information

/*
Condition continues to be true.
    - The condition is reassessed after each "iteration" of the loop, before executing the loop again.

    -While Loop
        -Do-While Loop
        -Best used when the number of outcomes needed by the loop is not known / non-deterministic
    
    -For Loop
        -Foreach Loop
        -Best used the number of iterations needed by the loop is known/calculable/Finite. 
*/

//Print the numbers 1-100


// System.Console.WriteLine(counter); //example of how to do this manually which would take forever
// counter++;
// System.Console.WriteLine(counter);

/*
while (condition)
{
    //code to execute while condition is true.
}
*/

int counter = 1;
while (counter <= 100)
{
    System.Console.WriteLine(counter);
    counter++;
}
System.Console.WriteLine("End of Program");

//Print the Sum of the numbers 1-100

counter = 1;
int sum = 0;
while (counter <= 100)
{
    sum += counter;
    counter++;
}
System.Console.WriteLine("The sum of the numbers 1-100 is: " + sum);

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