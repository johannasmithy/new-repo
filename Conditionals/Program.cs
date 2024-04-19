// See https://aka.ms/new-console-template for more information

/*
Control Flow - fundamental aspect of programming in which the developer adds in concepts to further gain control over what 
will or will not happen within the program. And/or how often. Often a Condition/Check is used to assess whether or not a 
chunk of code will proceed. 
    -Condition -> Boolean Expression -> Any statement that evaluates to true/false. 
    -Examples:
        -true
        -false
        -boolean variable
        -expression: numberOfBooks > 5 
*/
/*
Conditional Statement - evaluates a Condition to simply determine if a chunk of code is/is not executed.
    -If Statement
        -If-Else Statements
        -If-Elseif-Else Statements
    -Ternary Operators
    -Switch (or Switch-Case) Statements   
*/


bool isRainy = true;

if (isRainy) 
{
    System.Console.WriteLine("It is Rainy outside!");
}

/*
Quick Detour - Console Input -> Console.ReadLine();
application will pause and wait for you to type something in the console
*/
System.Console.WriteLine("Please enter your favorite number: ");
string input = Console.ReadLine();
System.Console.WriteLine("Your Favorite number is: " + input);

int number= 0; //We need to create the number variable outside of the IF statement for its scope to stretch beyond just the If Block.

//Converting Data Types
if (input != null)
{
    number = int.Parse(input);
    
}
else
{
    System.Console.WriteLine("You failed to enter only digits, you suck.");
    number = -1;
}
if (number > 10)
{
    
    System.Console.WriteLine("Your favorite number is greater than 10!");
}
else 
{
    if (number == 10)
    {
        System.Console.WriteLine("Your favorite number is between 5 and 10");
    }
}

/*
An Alternative to (most) nested conditionals
If-Elseif-Else Statements
*/

//Only one of these below will ever be executed
if (number > 10)
{
    System.Console.WriteLine(">10 yay!");
}
else if (number > 5)
{
    System.Console.WriteLine("5<your number<=10 ......yay...");
}
else
{
    System.Console.WriteLine("<5... whatever...blahblahblah");
}

/*
Ternary Operators
It is an Alternative to simple If-Else statements where the tasks/outcomes are very similar
(condition) ? <option if true> : <option if false>
*/
if (number > 10)
{
    System.Console.WriteLine("Your number is greater than 10 not Ternary"); //if else example
}
else
{
    System.Console.WriteLine("Your number is not greater than 10 not Ternary");
}

//Simplified Ternary Operator
string phrase = "Your number is " + ((number > 10) ? "greater than 10" : "not greater than 10"); //ternary example
System.Console.WriteLine(phrase);


/*
Switch-Case Statements
Best used when the options we want to consider are particular, finite, and/or incremental

switch (variable)
{
    case(value1):
    {
        //some code to execute if variable == value1
    }
    case(value2):
    {
        //some code to execute if variable == value2
    }
    case(value3):
    case(value4):
    {
        //some code to execute if variable == value3 OR value4
    }
    default: 
    {
        //some code to execute if variable != to any case*
    }
}
*/

// -----
System.Console.WriteLine("Enter an option 1-4: ");
input = Console.ReadLine();
int option = 0;

if(input != null) 
option = int.Parse(input);

switch (option)
{
    case 1:
        System.Console.WriteLine("You have chosen Option 1. You win $1.");
        break;
    case 2:
        System.Console.WriteLine("You have chosen Option 2. You win $2.");
        break;
    case 3:
    case 4:
        System.Console.WriteLine("You have chosen 3 or 4");
        break;
    default:
        System.Console.WriteLine("You did not choose an Option 1-4. Please Try Again.");
        break;
}

