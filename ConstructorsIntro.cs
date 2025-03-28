using System.Numerics;

namespace revision;

public class ConstructorsIntro
{
    public static void Run(){
        House h1 = new();
        House h2 = new(20);
        House h3 = House.CreateHouse("Ali's House");
        House h4 = new(h3);

        System.Console.WriteLine(h1);
        System.Console.WriteLine(h2);
        System.Console.WriteLine(h3);
        System.Console.WriteLine(h4);
        System.Console.WriteLine("House amount: {0}" ,House.Total());
    }

}
file class House
{
    public int ChairAmount { get; set; }
    private readonly string? name;
    private static int TotalHouses;

    //Empty Constructor
    public House (){TotalHouses++;}

    //Parameterized Constructor
    public House (int ChairAmount){
        this.ChairAmount = ChairAmount;
        TotalHouses++;
    }

    //Private Constructor
    private House (string name){
        this.name = name;
        TotalHouses++;
    }
    public static House CreateHouse(string name){
        return new House(name);
    }

    //Static Constructor
    static House(){
        System.Console.WriteLine("Houses are being created.");
        TotalHouses = 0 ;
    }

    //Copy Constructor
    public House(House h){
        this.name = h.name;
        this.ChairAmount = h.ChairAmount;
        TotalHouses++;
    }

    public static int Total(){
        return TotalHouses;
    }

    public override string ToString()
    {
        if (!string.IsNullOrEmpty(name))
        {
            return "House name: " + this.name;
        }
        return "Chair number:" + this.ChairAmount;
    }
}