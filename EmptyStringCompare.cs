namespace revision;

public class EmptyStringCompare
{
    public static void run(){
        System.Console.WriteLine("" == String.Empty);
        System.Console.WriteLine("".Equals(String.Empty));

        String Greeting = "Hello";
        Char[] chars = new char[] {'H','e','l','l','o'};
        Object greeting = new String((chars));
        Console.WriteLine(greeting == Greeting); // Greeting is a String object while greeting is an obj ,both Greeting and greeting are references, but they refer to different objects in memory.
        Console.WriteLine(Greeting.Equals(greeting)); // Equals only compares the value.
    }
}