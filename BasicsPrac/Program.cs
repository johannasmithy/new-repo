// int num = 10 + 10;
// System.Console.WriteLine(num);
// num = num -10;
// System.Console.WriteLine(num);
// num++;
// System.Console.WriteLine(num);
// num--;
// System.Console.WriteLine(num);

// System.Console.WriteLine("-------");
// // System.Console.WriteLine("Please enter your favorite number:");
// // string input = Console.ReadLine();
// // int number = 0;
// // if (input!= null) 
// //     {
// //         number = int.Parse(input);
// //     }
// // string phrase = "Your number is " + ((number > 10) ? "greater than 10" : "not greater than 10");
// // System.Console.WriteLine(phrase);

// // num = 0;
// // while (num != 5)
// // {
// //     System.Console.WriteLine("Please input the number 5");
// //     string? input = Console.ReadLine();

// //     if (input != null) num=int.Parse(input);

// //     if(num!=5)
// //     {
// //         System.Console.WriteLine("Please try again");
// //     } 
// // }
// // if(num == 5)
// // {
// //     System.Console.WriteLine("Good job");
// // }
// // else
// // {
// //     System.Console.WriteLine("You failed");
// // }

// // num = 0;
// // do
// // {
// //     System.Console.WriteLine("Please input the number 5");
// //     string? input = Console.ReadLine();

// //     if (input!=null) num=int.Parse(input);

// //     if (num != 5)
// //     {
// //         System.Console.WriteLine("Please try again");
// //     }
// // }
// // while (num!=5);

// // for(int count = 1; count <= 100; count++)
// // {
// //     System.Console.WriteLine(count);
// // }

// // for(int i = 2; i <= 200; i+=2)
// // {
// //     System.Console.WriteLine(i);
// // }

// System.Console.WriteLine("-------------");

// for(int j = 50; j >= 25; j--)
// {
//     System.Console.WriteLine(j);
// }

// int num3 = 3;
// int num4 = 5;
// int num5 = num3 += num4;
// System.Console.WriteLine(num5);

// int num1, num2, num3;
// System.Console.WriteLine("Input the first number to multiply: ");
// string input = Console.ReadLine();
// if(input != null) num1 = int.Parse(input);
// System.Console.WriteLine("Input the second number to multiply: ");
// string? input2 = Console.ReadLine();
// if(input2 != null) num2 = int.Parse(input2);
// System.Console.WriteLine("Input the third number to multiply: ");
// string? input3 = Console.ReadLine();
// if(input3 != null) num3 = int.Parse(input3);

// int result = 

// int[] input = new int[3];
// System.Console.WriteLine("Please enter a number");
// for(int i=0; i<3; i++)
// {
//     input[i] = int.Parse(Console.ReadLine());
//     System.Console.WriteLine("You entered " + input[i] + ". Please enter another number.");
// }

// int result = input[0] * input[1] * input[2];
// System.Console.WriteLine(input[0] + " multiplied by " + input[1] + " multiplied by " + input[2] + " equals: " + result);


// for(int i = 1; i <=99; i+=2)
// {
//     System.Console.WriteLine(i);
// }

// using System;

// class ReverseString
// {
//     static void Main(string[] args)
//     {
//         string str = "Hello";
//         char[] stringArray = str.ToCharArray();
//         Array.Reverse(stringArray);
//         string reversedStr = new string(stringArray);
//         System.Console.WriteLine("Original String is: " + str);
//         System.Console.WriteLine("Reversed String is :  " + reversedStr);
//     }


// }

// using System;

// class Programs
// {
//     static void Main(string[] args)
//     {

//         ReturnsTrue(0);
//     }

//     public static void ReturnsTrue(int num1)
//     {
//         bool isLessThanZero;
//         if(num1 <= 0) isLessThanZero = true;
//         else isLessThanZero = false;
//         System.Console.WriteLine(isLessThanZero);
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int max = 0;
//         int[] input = new int[3];
//         for (int i= 0; i < 3; i++)
//         {
//             input[i] = int.Parse(Console.ReadLine());
//             if(i > max) max = i;
//         }


//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = new int[4];
//         array = [1, 5, 2, 7];
//         int max = 0;
//         foreach (int num in array)
//         {
//             if (num > max)
//                 max = num;
//         }

//         System.Console.WriteLine(max);
//     }

// }


// string str = "Hello, World!";
//         string str2 = "";

//         foreach (char c in str)
//         {
//             str2 = c + str;
//         }
//         for(int i = str.Length - 1; i>= 0; i--)
//         {
//             str2 += str[i];
//         }

//         System.Console.WriteLine(str2);

// string str = "Hello, world!";
// string reverse = "";
// int len = str.Length - 1;

// for(int i = 0; i< len; i++)
// {
//     reverse += str[i];
// }
// foreach (char c in str)
// {
//     reverse = c + reverse;
// }
// System.Console.WriteLine(reverse);

// using System;
// {
//     //DO NOT TOUCH THE CODE BELOW
//     public static void Main(){
//         string[] inputArray = Console.ReadLine().Replace("[","").Replace("]","").Split(",");
// 		int[] intArray = new int[inputArray.Length];
// 		for(int i=0;i<intArray.Length;i++){
// 		intArray[i]=Int32.Parse(inputArray[i]);
// 		}
//         Console.WriteLine(FindMin(intArray));
//     }
//     public class Test{
//     public static int FindMin(int[] intArray){
//         //WRITE YOUR CODE HERE

//         intArray = [1, 2, 3, 4];
//         int min = 0;
//         foreach(int num in intArray)
//         {
//             if(num < min)
//                 min = num;
//         }




//     }
// }

// using System;

// public class Test
// {
//     public static int FindMin(int[] intArray)
//     {

//     }

//     public static void Main()
//     {
//        string[] inputArray = Console.ReadLine().Replace("[","").Replace("]","").Split(",");
// 		int[] intArray = new int[inputArray.Length];
// 		for(int i=0;i<intArray.Length;i++)
//             {
//                 intArray[i]=Int32.Parse(inputArray[i]); 
//             }
//     }
// }

// using System;

// public class Test
// {
//     public static void Main()
//     {
//         int b = int.Parse(Console.ReadLine());
//         int s = int.Parse(Console.ReadLine());
//         int t = int.Parse(Console.ReadLine());
//         Console.WriteLine(RockGame());
//     }

//     public static int RockGame()
// //     {
// int[] intArray = new int[4];
//         intArray = [1, 2, 3, 4];
//         int min = 0;
//         foreach(int num in intArray)
//         {
//             if(num <= min)
//                 min = num;
//         }
//         System.Console.WriteLine(min);

/*
Write a C# program that takes a string representing a message encrypted with a simple substitution cipher, where each letter in the alphabet
is replaced with its corresponding position in the alphabet (a=1, b=2...). Your program should be able to decrypt the message and print the original message.
*/

/*
Char to Int
*/

// using System;

// class Program
// {


//     public static int CharToInt(char c)
//     {
//         // Convert the character to lowercase for simplicity
//         c = char.ToLower(c);
//         // Subtract the Unicode value of 'a' from the Unicode value of the character,
//         // then add 1 to make 'a' correspond to 1, 'b' correspond to 2, and so on.
//         return c - 'a' + 1;

//     }

//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("Enter a string: ");
//         string inputString = Console.ReadLine();
//         foreach (char c in inputString)
//         {
//         // char inputChar = 'A'; //You can change this to any character you want to convert
//         int result = CharToInt(c);

//         }
//         System.Console.WriteLine("The Unicode int value of '" + inputString + "' is: " + result);

//     }

// }

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;

// class Solution
// {
//     static void Main(string[] args) //This one reverses the characters in a string and also reverses the case of the characters in the string.
//     {
//         System.Console.WriteLine("Enter a string");
//         string _string = Console.ReadLine();
//         //This part is all another way to reverse a string that was entered from ReadLine
//         char[] stringArray = _string.ToCharArray(); //takes the charactes from the _string entered above and Copies the characters (in this instance) to a Unicode character array.
//         //Returns: A Unicode character array whose elements are the individual characters of this instance. If this instance is an empty string, the returned array is empty and has a zero length.
//         Array.Reverse(stringArray); //takes the stringArray we just created above and Reverses the sequence of the elements.
//         string reversed_string = new string(stringArray); //Makes a new string out of the reversed array above- Initializes a new instance of the string class to the Unicode characters indicated in the specified character array.
//         //At this point, we are done reversing the string. the rest of the code has to do with reversing the case of the characters in the string. (however we would have to change the name of the string we are printing out if we are done here.)
//         // int ln = reversed_string.Length; // I don't think we actually need this
//         StringBuilder str = new StringBuilder(reversed_string); //building a new string named str our of our existing reversed_string
//         convertOpposite(str); //running the method that reverses the case of the characters
//         Console.WriteLine(str); //printing our completed string

//     }

//     static void convertOpposite(StringBuilder str) //building a method that will build a string named str
//     {
//         int ln = str.Length; // this could be done within the loop to shorten/simplify the code, it's just declaring a new int defined by the length of the string. 
//         //because the loop declares i must be less than instead of less than or equal to, we don't need to set it to Length-1.
//         for (int i=0; i<ln; i++) //Loop setting up that i is currently 0 (the first indexed location of the string) how many times it runs (less than the length of the string)
//         //and adds 1 to i each time it runs- going through each indexed placement of the chars in the string.
//         {
//             if (str[i]>='a' && str[i]<='z') //this is identifying if the 'i' indexed char in the string is a lowercase letter based on its assigned unicode value
//                 str[i] = (char) (str[i] - 32); //and if it is a lowercase letter, we subtract 32 to bring it to its uppercase letter
//             else if(str[i]>= 'A' && str[i]<='Z') //else if it's not lowercase, this identifies if it's uppercase
//                 str[i] = (char) (str[i] + 32); // and adds 32 to bring it to lowercase
//         }
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         string str = "Hello, World!"; //The string we are going to be reversing
//         string reverse = ""; //The new reversed string, blank until after the code
//         // foreach(char c in str) //Loop
//         // {
//         //     reverse = c + reverse; //Adds each char to reverse - somehow it ends up backwards?
//         // }
//         //Below is a second option , does the same thing, I understand why a bit more
//         for(int i = str.Length-1; i >= 0; i--) //a loop that runs the number of times set by 'int i', which is equal to the string length - 1 (in this case 11)
//         //(minus 1 bc the first char is 0 indexed), as long as i remains greater than or equal to 0, and each time it runs, we subtract 1 from i.
//         {
//             reverse += str[i]; //each time the loop is run, the empty reverse string is equal to reverse + the string char in the index (place in the string) of i (hence putting it in reverse)
//         }
//         System.Console.WriteLine(reverse);
//     }
// }

/*
bool isPalindrome;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if(s[i] != s[s.])
        }
*/
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string str = "madams"; //this line of code tells the compiler to store the string "madam" in the variable str
//         char[] cArray = str.ToCharArray(); //this line of code tells the compiler to convert the string into a character array
//         Array.Reverse(cArray); //this line of code tells the compiler to reverse the character array
//         string revStr = new string(cArray); //this line of code tells the compiler to convert the character array into a string

//         System.Console.WriteLine(str == revStr ? "Palindrome" : "Not Palindrome");

//         // The above code will output "Palindrome" because the string "madam" is the same forwards and backwards

//         // Loop - the next example will use a loop to check if the string is a palindrome. 

//         string name = "pap"; //this line of code tells the compiler to store the string "pat in the variable name
//         bool isPalindrome = true; //this line of code tells the compiler to store the boolean value true in the variable isPalindrome
//         for (int i = 0; i < name.Length / 2; i++) // this line of code tells the compiler to loop through the string in this case the string is "pat" and the loop will run 3 times
//         {
//             if(name[i] != name[name.Length - i - 1]) // this line of code tells the compiler to check if the first character is not equal to the last character
//             {
//                 isPalindrome = false; // this line of code tells the compiler to store the boolean value false in the variable isPalindrome
//                 break; // this line of code tells the compiler to break out of the loop
//             }
//         }
//         System.Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome"); //this line of code tells the compiler to output "Not Palindrome" because the string "pat" is not 
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // static void AsciiSum()
//             {
//                 string? S = Console.ReadLine();
//                 int value = 0;

//                 foreach (char A in S)
//                 {
//                     value += A;
//                 }

//                 Console.WriteLine(value);
//             }
//     }
// }

            // int val; 
            // string input = Console.ReadLine();
            // // getting parsed value 
            // val = Int32.Parse(input); 
            // Console.WriteLine("'{0}' parsed as {1}", input, val); 

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("Enter a string: ");
//         string? inputString = Console.ReadLine();
//         int result = 0;
//         foreach ( char ch in inputString)
//         {
//             int lower = CharToInt(ch);
//             // System.Console.WriteLine("The Unicode int value of '" + inputString + "' is: " + result);
//             result += lower;
            
//         }


//         System.Console.WriteLine("The sum of the unicode values of: " + inputString + " is: " + result);
        
//     }
//     public static int CharToInt(char ch)
//     {
//         // Convert the character to lowercase for simplicity
//         ch = char.ToLower(ch);
//         // Subtract the Unicode value of 'a' from the Unicode value of the character,
//         // then add 1 to make 'a' correspond to 1, 'b' correspond to 2, and so on.
//         // var (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z) 
//         //   = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26);
//         return ch - 'a' + 1;

//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string str = "madams"; //this line of code tells the compiler to store the string "madam" in the variable str
//         char[] cArray = str.ToCharArray(); //this line of code tells the compiler to convert the string into a character array
//         Array.Reverse(cArray); //this line of code tells the compiler to reverse the character array
//         string revStr = new string(cArray); //this line of code tells the compiler to convert the character array into a string

//         System.Console.WriteLine(str == revStr ? "Palindrome" : "Not Palindrome");

//         // The above code will output "Palindrome" because the string "madam" is the same forwards and backwards

//         // Loop - the next example will use a loop to check if the string is a palindrome. 

//         // string name = "pap"; //this line of code tells the compiler to store the string "pat in the variable name
//         // bool isPalindrome = true; //this line of code tells the compiler to store the boolean value true in the variable isPalindrome
//         // for (int i = 0; i < name.Length / 2; i++) // this line of code tells the compiler to loop through the string in this case the string is "pat" and the loop will run 3 times
//         // {
//         //     if(name[i] != name[name.Length - i - 1]) // this line of code tells the compiler to check if the first character is not equal to the last character
//         //     {
//         //         isPalindrome = false; // this line of code tells the compiler to store the boolean value false in the variable isPalindrome
//         //         break; // this line of code tells the compiler to break out of the loop
//         //     }
//         // }
//         // System.Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome"); //this line of code tells the compiler to output "Not Palindrome" because the string "pat" is not 
//     }
// }





// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string s = Console.ReadLine();
//         // Console.WriteLine(checkForPalindrome(s).ToString().ToLower());
//         checkForPalindrome(s);
//         System.Console.WriteLine();
//     }
    
//     public class Test
//     {
//         public static bool checkForPalindrome(string s)
//         {
            
//         bool isPalindrome;
//         char[] charArray = s.ToCharArray();
//         Array.Reverse(charArray);
//         string reversedStr = new(charArray); 
//         if(s == reversedStr)
//         {
//             return isPalindrome = true;
//         }
//         else return isPalindrome = false;
        
//         }
                

//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         string s = Console.ReadLine();
//         System.Console.WriteLine(createSecretCode(s));
        
//     }

//     public class Test
//     {
//         public static int createSecretCode(string s)
//         {
//             var result = 0;
//             foreach(char c in s)
//             {
//                 result = CharToInt(c);
//                 result += c;
//                 result.ToString("D2");
                
//             }
//             System.Console.WriteLine(result);
            
//             return result;
            

//         }
//         public static int CharToInt(char c)
//     {
//         // Convert the character to lowercase for simplicity
//         c = char.ToLower(c);
//         // Subtract the Unicode value of 'a' from the Unicode value of the character,
//         // then add 1 to make 'a' correspond to 1, 'b' correspond to 2, and so on.
//         return c - 'a' + 1;
//     }


//     }
// }

// class Solution
// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("Enter a number");
//         int N = int.Parse(Console.ReadLine());
//         int loop = 0;
//         int one = 1;
//         int two= 2; 
//         int three=3;
//         int four=4;
//         int five=5;
//         int six=6;
//         int seven=7;
//         int eight=8;
//         int nine=9;
//         int ten=10;
//         while (loop <= 10)
//         {
//         one = N * one;
//         two = N * two;
//         three = N * three;
//         four = N * four;
//         five = N * five;
//         six = N * six;
//         seven = N * seven;
//         eight = N * eight;
//         nine = N * nine;
//         ten = N * ten;
        
//         loop++;
//         }
        

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");

//         Console.Write(one);
//         Console.Write(two) ;
//         Console.Write(three);
//         Console.Write(four);
//         Console.Write(five);
//         Console.Write(six) ;
//         Console.Write(seven);
//         Console.Write(eight);
//         Console.Write(nine);
//         Console.Write(ten);

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");
//     }
// }

//^this was a ridiculously long and slow way to go about this, I was just in a panic and time crunch.

// using System;
// using System.Linq;
// using System.IO;
// using System.Text;
// using System.Collections;
// using System.Collections.Generic;

// /**
//  * Auto-generated code below aims at helping you parse
//  * the standard input according to the problem statement.
//  **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         int N = int.Parse(Console.ReadLine());

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");

//         for (int i = 1; i <= 10; i++)
//         {
//             Console.Write(i * N);
//             if (i < 10)
//                 Console.Write(" ");
//         }
//     }
// }

//another option. this problem was for taking a given int and printing out its multiples, all on one row, with spaces in between, no trailing space.
// class Solutions
// {
//     static void Main(string[] args)
//     {
//         int N = int.Parse(Console.ReadLine());
//         List<int> result = new();
//         for (int i = 1; i <= 10; i++)
//         {
//             result.Add(N * i);

//         }

//             Console.WriteLine(string.Join(" ", result));

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");

        
//     }
// }

// using System;
// using System.Linq;
// using System.IO;
// using System.Text;
// using System.Collections;
// using System.Collections.Generic;

// /**
//  * Auto-generated code below aims at helping you parse
//  * the standard input according to the problem statement.
//  **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         string s = Console.ReadLine();
//         var one = s.Count(x => x == '$');
        
        
//     }
// }

// using System;
// using System.Linq;
// using System.IO;
// using System.Text;
// using System.Collections;
// using System.Collections.Generic;

// /**
//  * Auto-generated code below aims at helping you parse
//  * the standard input according to the problem statement.
//  **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         bool Success;
        
//         int nbRoll = int.Parse(Console.ReadLine());
//         for (int i = 0; i < nbRoll; i++)
//         {
//             string[] inputs = Console.ReadLine().Split(' ');
//             int roll = int.Parse(inputs[0]);
//             int expected = int.Parse(inputs[1]);
//             int critical = 20;

//             if (roll>= expected)
//             {
//                 Success = true;
//                 Console.WriteLine("Success");
//             }
//             else if (roll == critical)
//             {
//                 Success = true;
//                 Console.WriteLine("Success");
//             }
//             else Success = false;
//             Console.WriteLine("Failure");
//         }

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");

        
//     }
// }

// using System;
// using System.Linq;
// using System.IO;
// using System.Text;
// using System.Collections;
// using System.Collections.Generic;

// /**
//  * Auto-generated code below aims at helping you parse
//  * the standard input according to the problem statement.
//  **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         int N = int.Parse(Console.ReadLine());

//         if (N <0)
//         {
//         System.Console.WriteLine("no negative numbers");
//         }
        
//         else if (N%3 ==0)
//         {
//         System.Console.WriteLine("true");
//         }
       
//         else     
//         {
//         System.Console.WriteLine("false");
//         }
        

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");

        
//     }
// }



/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("Enter a number, like 7");
//         int chunks = int.Parse(Console.ReadLine());
//         System.Console.WriteLine("Enter a number, like 9");
//         int size = int.Parse(Console.ReadLine());
//         for(int i = 0; i< chunks; i++)
//         {      
//             Console.Write("#");
//         }
//         for(int j = 0; j < size-chunks; j++)
//         {
//             Console.Write(".");            
//         }
//         double percent = chunks * 100 /size;
//         // percent = Math.Round(percent);
//         Console.Write(" " + Math.Round(percent) + "%");

//         // Write an answer using Console.WriteLine()
//         // To debug: Console.Error.WriteLine("Debug messages...");

        
//     }
// }
// using System;
// using System.Linq;
// using System.IO;
// using System.Text;
// using System.Collections;
// using System.Collections.Generic;

// /**
//  * Auto-generated code below aims at helping you parse
//  * the standard input according to the problem statement.
//  **/
// class Solution
// {
//     static void Main(string[] args)
//     {
//         long n = long.Parse(Console.ReadLine());

//         //Track both values
//         long even = 0;
//         long odd = 0;

//         //Run a loop over all numbers. start at 1 (or 0) and go to N.
//         for(int i = 0; i <= n; i++)
//         {
//             //determine if even or odd.
//             if(i % 2 == 0)
//             {
//                 even += i;
//             }
//             else
//             {
//                 odd += i;
//             }
//         }

//         //Print out result.
//         Console.WriteLine(odd);
//         Console.WriteLine(even);
//     }
// }
