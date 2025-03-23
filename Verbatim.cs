namespace revision;

public class Verbatim
{
    public static void run(){
        String a = "Hello \"\\someone\"";
        String b = @"Hello ""\someone""";
        Console.WriteLine("{0}\n{1}",a,b);
    }
}
