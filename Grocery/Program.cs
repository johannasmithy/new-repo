namespace Grocery;

class Program
{
    static void Main(string[] args)
    {
        string itemsInList = "";

        System.Console.WriteLine("Grocery List Menu");
        // System.Console.WriteLine("First item: ");
        bool enterAnother = true;
        string another = "";
        List<string> groceryList = new List<string>();
        do
        {
            System.Console.WriteLine("Do you want to enter an item to add to your grocery list? Answer Yes or No: ");
            another = Console.ReadLine();
            if (another == "Yes")
            {
                enterAnother = true;
                System.Console.WriteLine("Enter an item to add to your grocery list: ");
                itemsInList = Console.ReadLine();
                groceryList.Add(itemsInList);
            }
            else if (another == "No") enterAnother = false;

        } while (enterAnother);

        foreach (string item in groceryList)
        {
            System.Console.WriteLine(item);
        }





        //Lists- dynamic array. Array has a fixed size, lists do not have a fixed size, you can add and remove










    }
}
