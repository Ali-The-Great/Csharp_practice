namespace revision;

public class ArrayIntSum
{
    public static void Run(){
        System.Console.Write("Enter array size: ");
        if (!int.TryParse(Console.ReadLine(),out int Size)) Size = 1; 
        int[] arr = new int[Size];
        for (int i = 0; i < Size; i++)
        {
            if (!int.TryParse(Console.ReadLine(),out int num)) num = 0; 
            arr[i]=num;
        }
        System.Console.WriteLine(SumOfNumbers(arr));

    }
    static int SumOfNumbers(int[] arr){
        int Sum = 0;
        foreach (int item in arr) Sum+=item;
        return Sum;
    }
}