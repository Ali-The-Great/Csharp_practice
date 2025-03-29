namespace revision;

public partial class PartialClass
{
    public static void P1(){
        System.Console.WriteLine("this is part 1 of the partial class");
    }

    ~PartialClass(){
        System.Console.WriteLine("Destructor called for sealed class.");
    }
}
