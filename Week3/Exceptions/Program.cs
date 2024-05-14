

class Program
{
    static void Main(string[] args)
    {
        // PreventativeApproach();
        // HandlingExceptions();
        // System.Console.WriteLine(WhyFinally());
        ThrowingExceptions();
    }

    public static void ThrowingExceptions()
    {
        //You can introduce your own Exceptions into the code at will:
        //throw keyword

        System.Console.WriteLine("Enter a number between 1-100: ");
        int guess = int.Parse(Console.ReadLine() ?? "0");

        int correct = 50;
        if(guess == correct)
        {
            System.Console.WriteLine("you got it right");
        
        }
        else if(guess>correct)
        {
            System.Console.WriteLine("your guess is too high");
        }
        else if(guess < correct && guess > 0)
        {
            System.Console.WriteLine("your guess is too low");

        }
        // else
        // {
        //     throw new NoFunException("I guess you arent having fun");
        // }
    }
    public static int WhyFinally()
    {
        int x = 10;
        int y = 0;

        try
        {
            int result = x/y;
            return result;
        }
        catch (DivideByZeroException ex)
        {
            System.Console.WriteLine(ex.Message);
            return 0;
        }
        finally
        {
            System.Console.WriteLine("Printing from the finally block");
        }

        System.Console.WriteLine("Printing from the End of the method");
    }
    public static void HandlingExceptions()
    {

        int[] numbers = [1, 2, 3];
        System.Console.WriteLine("Enter an index: ");
        string input = Console.ReadLine() ?? "0";
        

        //Handling Exceptions: try-catch block
        try
        {
            int index = int.Parse(input);
            System.Console.WriteLine(numbers[index]);
        }
        catch (IndexOutOfRangeException ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("Will Execute no matter what");
        }


        System.Console.WriteLine("Program Ends");
    }
    private static void PreventativeApproach()
    {
        System.Console.WriteLine("Enter an index: ");
        int[] numbers = [1, 2, 3];
        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing

        if (index >= numbers.Length || index < 0)
        {
            System.Console.WriteLine("you entered the wrong index");
        }
        else
        {
            System.Console.WriteLine(numbers[index]);
        }

        System.Console.WriteLine("Program End");
    }
}