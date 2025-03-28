using System.Text.RegularExpressions;

namespace revision;

public class InheritenceIntro
{
    public static void Run(){
        Book B1 = new("Can't hurt me",25,"David goggins");
        Book B2 = new FictionBook("The Song of Achilles",5,"Madelaine Miller","Fantasy");
        System.Console.WriteLine(B1);
        System.Console.WriteLine(B2);
        B1.DisplayName();
        B2.DisplayName();

    }
}

file class Book(string Name, int Price, string Author)
{
    public string? Name { get; set; } = Name;
    public int Price { get; set; } = Price;
    public string? Author { get; set; } = Author;

    public override string ToString()
    {
        return "Book : " + this.Name + " by " + this.Author + " , " + (this.Price).ToString("C") + ".";
    }

    public virtual void DisplayName(){
        Console.WriteLine("This Book is {0}",this.Name);
    }
}

file class FictionBook(string Name, int Price, string Author, string genre) : Book(Name, Price, Author)
{
    private readonly string? genre = genre;

    public string GetGenre(){
        return genre ?? "no genre";
    }

    public override string ToString()
    {
        return this.genre + " " +base.ToString();
    }
    public override void DisplayName()
    {
        System.Console.WriteLine("This {0} Book is {1}",this.genre,this.Name);
    }
}
