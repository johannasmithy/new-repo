// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Intro to Variables//
//Variables should be in camelCasing//
//Syntax: variableName = some-value;
//Only declare a variable once- cannot re-declare it

int numberOfBooks;
numberOfBooks = 10;

Console.WriteLine(numberOfBooks);

//Variable Declaration and assignment at the same time

double money = 2.50;
System.Console.WriteLine(money);

//= --> Assignment Operator (set Money equal to 2.5)

//Basic Operations: 
int num = 1 + 2;
num = 1 - 2;
num=1*3;
num =  1 / 3; //will not give us a decimal because the variable is defined as an int (whole numnber). referred to as Integer Division
//num = 1 % 3; // Modulus- not necessary for this training. what is the remainder when you take 1 and divide it by 3. 
//instead of a fraction it will show the remainder. 
System.Console.WriteLine(num);

double num2 = 1 / 3.0;
System.Console.WriteLine(num2);
System.Console.WriteLine(1/3.0);

//Augmented (Compound) Assignment Operators
//What if I want to perform a calculation on a variable and store that result back into the variable.

int num3 = 10;
num3 = num3 * 3; //this will permanently affect the value of the variable - not just a mathematical equation giving us a result
System.Console.WriteLine(num3);

//Autmented Assignment Operator
num3 +=5; // exactly the same as: num3 = num3 + 5;
System.Console.WriteLine(num3);

//Increment / Decrement Operators
num3++; //Increment - Add exactly 1  --> num3 += 1 --> num3 = num3 + 1;
num3--; //Decrement - Subtract exactly 1 --> num3 -= 1 --> num3 = num3 - 1;

System.Console.WriteLine(num3);

++num3;
--num3;

System.Console.WriteLine(num3);

System.Console.WriteLine(num3++); // Post-Increment
System.Console.WriteLine(num3);
System.Console.WriteLine(++num3); // Pre-Increment

//Booleans - value-type that stores either 'true' OR 'false'

bool isSunny = true;
bool isRainy = false;

System.Console.WriteLine(isSunny);

// ! --> Null Operator or Negate or Negation Operator --> change the boolean into its opposite value
System.Console.WriteLine(!isSunny);

isSunny =  !isSunny; // A Toggle --> switch isSunny's value to the other boolean choice. (permanent change to variable)
System.Console.WriteLine(isSunny);

// Relational Operators - compare one value to another value. 
// ==, !=, <, >, <=, >=

System.Console.WriteLine(5 == 5);
// 5 == 5 --> Boolean Expression --> expression that evaluates to True or False

System.Console.WriteLine(numberOfBooks == 5);

System.Console.WriteLine(numberOfBooks != 5);

System.Console.WriteLine(numberOfBooks);

//Get Ahead study tip: Logical Operators, Conditional Statements, loops

//Other topics: strings, concatentation, maybe arrays/lists