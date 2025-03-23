namespace revision;

public class EmptyStringCompare
{
    public static void run(){
        System.Console.WriteLine("" == String.Empty);
        System.Console.WriteLine("".Equals(String.Empty));

        String Greeting = "Hello";
        Char[] chars = new char[] {'H','e','l','l','o'};
        Object greeting = new String((chars));
        Console.WriteLine(greeting == Greeting); // Comparing string object to object => diffrent because of their memory
        Console.WriteLine(Greeting.Equals(greeting)); // Equals only compares the value
    }
}