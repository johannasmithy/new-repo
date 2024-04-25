// /*
// Problem: There is a lot of data that exists!
// Managing each piece in its own variable is going to become impractical
// A lot is quite similar or related whether its by purpose or even data type.
// We need to introduce means to store multiple pieces of data within one device/variable

// Arrays -> offers a way for us to very simply store multiple values of the same

// DataType[] variableName = new DataType[size];

// Arrays - in C# - have a fixed size upon instantiation (initialization).

// Arrays use Indexes (just like Strings) -> An Array of size 5 - Indexes: 0-4
// */

// //Basic Example
// int[] numbers = new int[5]; // Create an Array that can hold 5 ints.

// //Assign a value to any *element* of this array
// numbers[0] = 10;
// numbers[1] = 11;
// numbers[2] = 12;

// //Recall/use said value stored inside any *element* of this array.
// System.Console.WriteLine(numbers[0]);
// System.Console.WriteLine(numbers[1]);
// System.Console.WriteLine(numbers[4]);

// //Foreach Loop
// string arrString = "[";
// foreach (int num in numbers)
// {
//     arrString += num + ",";
// }
// arrString = arrString.Remove(arrString.Length -1);
// arrString += "]";
// System.Console.WriteLine(arrString);

// //string result = string.Join(", ", Array.ConvertAll(numbers, x => x.ToString()))

// string[] numberStrings = new string[numbers.Length];
// for (int i = 0; i < numbers.Length; i++)
// {
//     numberStrings[i] = numbers[i].ToString();
// }
// System.Console.WriteLine(string.Join(",", numberStrings));

// // Even less important
// //Multi-dimenensional Arrays
// int[,] twoDimArray = new int[3, 3];
// twoDimArray[0, 0] = 1;
// twoDimArray[0, 1] = 2;
//  //------back to the lesson

//  //Alternative syntax for instantiating Arrays

//  string[] words = ["Hello", "Hi", "Hey"];
//  System.Console.WriteLine(words[0]);
// //can still reassign
//  words[1] = "Bye";