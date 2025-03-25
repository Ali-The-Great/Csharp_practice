namespace revision;

public class MultipleArray
{
    public static void Run(){

        System.Console.Write("Enter The Num: ");
        if (!int.TryParse(Console.ReadLine(), out int num)) num = 1;
    
    System.Console.Write("Enter The Length: ");
    if (!int.TryParse(Console.ReadLine(), out int length)) length = 1;
    
    int[] arr = new int[length];
    
    for (int i = 0; i < length; i++) arr[i]=num*(i+1);

    System.Console.Write("Multiples array of {0}: ",num);
    for (int i = 0; i < length; i++) System.Console.Write("{0} ", arr[i]);
    System.Console.WriteLine();

    }
}
