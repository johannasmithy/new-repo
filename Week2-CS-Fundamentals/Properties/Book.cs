class Book
{
    /*
    General Structure to Models:
        -fields (Properties)
        -constructors
        -methods
    */

    // //Fields
    // string title;
    // string author;
    // int pages;

    //Alternative - Properties
    public string Title { get; set; } //creates an underlying private field called Title and public getters and setters
    public string Author { get; set; }
    public int Pages {get; set;}


    //Constructors
    public Book()
    {

    }

    public Book(string title, string author, int pages)
    {
        this.Title = title;
        this.Author = author;
        this.Pages = pages;
    }


    //Getters and Setters
    // public string GetTitle()
    // {
    //     return title;
    // }

    // public void SetTitle(string title)
    // {
    //     this.title = title;
    // }



    

    //Methods
    //ToString

    // public override void ToString()
    // {
    //     str
    // }

}