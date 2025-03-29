namespace revision;

public class EnumExample
{
    public static void Run(){
        Days today = Days.Monday;
        System.Console.WriteLine(today);
        System.Console.WriteLine((int)today);
    }
}
file enum Days : byte
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }