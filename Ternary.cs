namespace revision;

public class Ternary
{
    public static void run(){
        Console.Write("Enter a valid age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} is {1}",age , age > 0 ? "valid" : "invalid");
    }
}
