namespace revision;

public class RandomStuff
{
    public static void Run(){
        Random r = new();
        int a = r.Next(100);
        System.Console.WriteLine(a);
    }
}
