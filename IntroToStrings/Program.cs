// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Create a String variable
string word = "Hello";
System.Console.WriteLine(word);

//To access fields and methods from objects we create we use the "." (member access operator)

System.Console.WriteLine(word.Length);

word= "Hi!";
System.Console.WriteLine(word.Length);

System.Console.WriteLine(word.ToUpper()); //change to upper case
System.Console.WriteLine(word.ToLower());

//() parenthasis, [], brackets, {} soft brackets

word = "Hello, World!";
//WriteLine(word); //Argument
//When defining a Method: referred to as the method's Parameters
//System.Console.WriteLine(word.Substring()); //must provide context for this method, must give it some arguments for this method to work

System.Console.WriteLine(word.Substring(3));

/*
Indexes - Strings and other various collection-based devices use what is called Indexes/Indexing 
Indexes describe the position of that element within the entire set of data.
Strings -> the position of that character within the entire String.
Indexes (in MOST programming languages) are 0-indexed.
The 1st character in the String starts at the index 0.
    -the 2nd character is at index 1, etc...
    -the last index of any String is: Length-1 (referred to as "off by one")
*/

System.Console.WriteLine(word.Substring(7, 2)); /*Retrieves a substring from this instance. The substring starts at a specified character 
position and has a specified length.Returns:A string that is equivalent to the substring of length length that begins at startIndex in this 
instance, or string. Empty if startIndex is equal to the length of this instance and length is zero.
*/

/*
String Concatenation
When using the "+" sign with Strings the behavior changes away from the mathematical addition.
Concatenatin - the combining of two or more strings in which conjoin all the characters into one new string. 
*/

string phrase = "Hello" + "World";
System.Console.WriteLine(phrase);

string fname = "Johanna";
string lname = "Smith";
System.Console.WriteLine("Hello, my name is " + fname + " " + lname);

System.Console.WriteLine("1" + 1); //performs concatenation, not addition!

int num1 = 1;
int num2 = 2;
System.Console.WriteLine("Num1 = " + num1);
System.Console.WriteLine("Num2 = " + num2);

//value-types --> == measures if they ahve the same value.
System.Console.WriteLine(num1 == 1);

//reference-types - Objects --> == this will check if they are the SAME Object

string word1 = "Hello";
string word2 = "Hello";
System.Console.WriteLine(word1 == word2);
/*Strings utilize what is called the String Pool

*/

// 3 things to practice:
//Indexes- the substring method, make a variable string of your choice
//various methods
//string concatenation