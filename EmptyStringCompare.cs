namespace revision;

public class EmptyStringCompare
{
    public static void Run(){
        System.Console.WriteLine("" == String.Empty);
        System.Console.WriteLine("".Equals(String.Empty));

        String Greeting = "Hello";
        Char[] chars = ['H','e','l','l','o'];
        Object greeting = new String((chars));
#pragma warning disable CS0252
        Console.WriteLine(greeting == Greeting); // Greeting is a String object while greeting is an obj ,both Greeting and greeting are references, but they refer to different objects in memory.
#pragma warning restore CS0252
        Console.WriteLine(Greeting.Equals(greeting)); // Equals only compares the value.
    }
}