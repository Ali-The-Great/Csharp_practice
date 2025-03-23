namespace revision;

public class Ternary
{
    public static void Run(){
        Console.Write("Enter a valid age: ");
        if (int.TryParse(Console.ReadLine(), out int age)) Console.WriteLine("{0} is {1}", age, age > 0 ? "valid" : "invalid");
        else System.Console.WriteLine("Invalid age");

    }
}
