using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Lists();
        // StacksAndQueues();
        // HashSets();
        Dictionaries();
    }

    private static void Dictionaries()
    {
        //Dictionaries store Key-Value Pairs
        //Two datatype that you have to pick. One representing the Key, the other representing the Value.
        //Real World equivalencies - Dictionary: word-definition. word=key, definition=value. SSN: ssn-person. SSN=key, person=value.

        Dictionary<string, int> studentScores = new();
        studentScores.Add("Ryan", 80);
        studentScores.Add("Emma", 85);
        studentScores.Add("Adam", 75);

        //Accessing elements in the dictionary
        System.Console.WriteLine(studentScores["Ryan"]);

        foreach (var kvp in studentScores)
        {
            System.Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }

    private static void HashSets()
    {
        //Hash - a way of storing values - usually using some of the item's data to help formulate a spot for the hash to store said item. 
        //Set - do not preserve any order insertion
        //    - duplicates are not allowed

        HashSet<int> set = [1, 2, 3, 4, 6];
        set.Add(5);
        set.Add(5); //ignores duplicates

        System.Console.WriteLine(set.Contains(4));

        foreach(int num in set)
        {
            System.Console.WriteLine(num);
        }
    }

    private static void StacksAndQueues()
    {
        //There are more collections than just Lists.
        //Stacks and Queues take a slightly different strategy to data storage.
        //They see it as a holding cell where data enters in a particular order
        //And then exits (is removed from the collection) in a particular order. 

        //Stacks have a strategy -> First In, Last Out -> FILO
        //Queues have a strategy -> First In, First Out -> FIFO
        Queue<int> queue = new();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        System.Console.WriteLine("First item Dequeued: " + queue.Dequeue());
        queue.Enqueue(4);
        

        while(queue.Count > 0)
        {
            System.Console.WriteLine("Dequeued: " + queue.Dequeue());
        }

        Stack<int> stack = new();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        System.Console.WriteLine("first popped item " + stack.Pop());
        stack.Push(40);

        while(stack.Count > 0)
        {
            System.Console.WriteLine("Popped " + stack.Pop());
        }

    }

    private static void Lists()
    {
        // Data Structure -> Arrays
        // int[] numbers = new int[5];

        //Collections
        //List -> Java calls this ArrayList
        //List stores all of its values in side an array.
        //Parameterized Class...
        //Generics - Generic Classes
        //DataType<elementType> variableName = new DataType<elementType>();

        List<int> numbers = new List<int>(); //most proper way to write it out- can be reduced to either just new() OR just []
        //Add Values
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        //Printing out items in a Collection
        //long way
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num);
        }

        //One liner
        System.Console.WriteLine(string.Join(",", numbers));

        //Insert the element into the list at the specified index
        numbers.Insert(0, 40);
        System.Console.WriteLine(string.Join(",", numbers));

        //Add/Insert multiple values
        //Another list

        List<int> numbers2 = [1, 2, 3];
        numbers.AddRange(numbers2);
        numbers.InsertRange(0, [4, 5, 6]);
        System.Console.WriteLine(string.Join(",", numbers));

        //IndexOf
        System.Console.WriteLine(numbers.IndexOf(30));

        System.Console.WriteLine(numbers.Contains(25));

        //Accessing an Element
        System.Console.WriteLine(numbers[0]);

        //Remove an Element
        numbers.Remove(20); //Remove 20 from the list
        numbers.RemoveAt(0); //Remove the 0-indexed element
        System.Console.WriteLine(string.Join(",", numbers));

        //Reverse the List
        numbers.Reverse();
        System.Console.WriteLine(string.Join(",", numbers));

        numbers.Sort();
        System.Console.WriteLine(string.Join(",", numbers));

        //Self-Study: IComparable<datatype> -> see how you can add it to your own classes, thus allowing them to be sorted. 
    }
}