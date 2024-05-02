using System;
using Media;


class Program
{
    static void Main(string[] args)
    {
        // PracticeProperties();
        // PracticeScopes();
        PracticeNamespaces();

    }

    public static void PracticeNamespaces()
    {
        Movie movie1= new("Avarngers", 5);
    }
     public static void PracticeScopes()
    {
        Thing thing1 =  new();
        Thing thing2 = new();

        thing1.objectNum++;
        thing2.objectNum--;
    }
    public static void PracticeProperties()
    {
        Book book1 = new Book();
        book1.Title = "Dracula";
    }
   
}