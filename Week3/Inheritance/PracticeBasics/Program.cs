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