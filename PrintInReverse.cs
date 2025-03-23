using System.Transactions;

namespace revision;

public class PrintInReverse
{
    public static void Run(){
        System.Console.Write("Enter something to reverse:");
        String? s = Console.ReadLine() ?? "";
        int length = s.Length;
        string rs = string.Empty;
        for (int i = 0; i < length; i++) rs+=s[length-i-1];
        System.Console.WriteLine(rs);
    }
}