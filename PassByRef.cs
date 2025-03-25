namespace revision;

public class PassByRef
{
    public static void Run(){
        int a = 5 , b = 6;
        System.Console.WriteLine("original: {0}, {1}",a,b);
        Swap(a,b);
        System.Console.WriteLine("swapped: {0}, {1}",a,b);
        SwapRef(ref a,ref b);
        System.Console.WriteLine("swapped by ref: {0}, {1}",a,b);
    }
    static void Swap(int a, int b){
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
    }
    static void SwapRef(ref int a, ref int b){
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
    }
}
