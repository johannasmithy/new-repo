class Thing
{
    //Scopes - a way to measure a range of visibility / existence of a particular entity. 
    //  if you are outside of a particular scope, it's not accessible by the program. 
    //Object scope - exists within any object of this class. Each Object gets its own copy of this variable with its own value.
    public int objectNum;


    //Class Scope - belongs to the entire Class, and by extension, each Object Class.
    //The value of Class Scoped variables remains the same between each Object.

    public static int classNum = 10;
    public static int count =0;

    public Thing()
    {
        objectNum = 100;
        count++;
    }

    public static void StaticMethod()
    {
        //Static methods cannot use non-static members (other fields and methods)
        System.Console.WriteLine("This is a static method from the Thing Class");
    }

    //Method Scope - any variable we create (declare) inside of a method OR and parameter used by that method is 'scoped' to that Method.
    //Will no longer be used after the Method is finished.

    public void SomeMethod(int paramNum)
    {
        int methodNum = 10;

        //Parameters and variables created within a Method can be used so long as we are still in that method.

        System.Console.WriteLine(paramNum);
        System.Console.WriteLine(methodNum);

        //Can still access the Object/Class scoped variables

        //Block Scope - any variable created within a *block* of code can only be used within that context.
        //a *block* -> Conditionals / Loops / etc

        if (true)
        {
            int blockNum = 100;
            System.Console.WriteLine(blockNum);
        }
        else
        {
            //cannot use the block scoped variable above since we have left that blok of code
            // System.Console.WriteLine(blockNum);
        }
        for (int i = 1; i <= 100; i++)
        {
            System.Console.WriteLine(i);
        }
        //Cannot use the block scoped variable above "i" since we have left that block of code
        // System.Console.WriteLine(i);
    }

    



}