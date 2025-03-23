using System.ComponentModel.DataAnnotations;

namespace revision;

public class ArrayIntro
{
    public static void Run(){
        System.Console.Write("Enter the amount of array numbers (default is 1) : ");
        int[] arr;
        if (int.TryParse(Console.ReadLine(),out int num)) arr = new int[num];
        else arr = new int[1];
        int length = arr.Length;

        System.Console.WriteLine("Enter each number followed by Enter (default is 0) : ");
        for (int i = 0; i < length; i++)
        {
            if (int.TryParse(Console.ReadLine(),out int current )) arr[i] = current;
            else arr[i]=0;
        }
        System.Console.Write("output : ");
        for (int i = 0; i < length; i++) System.Console.Write("{0} ",arr[i]);
        System.Console.WriteLine();

        Array.Sort(arr);
        Console.Write("Sorted Array : ");
        foreach (var item in arr) System.Console.Write("{0} " , item);
        System.Console.WriteLine();

        Array.Reverse(arr);
        Console.Write("Reversed Array : ");
        foreach (var item in arr) System.Console.Write("{0} " , item);
        System.Console.WriteLine();

        Array.Clear(arr,0,length);
        Console.Write("Cleared Array : ");
        foreach (var item in arr) System.Console.Write("{0} " , item);
        System.Console.WriteLine();

        arr = [1,5,2,3,4,5,1];
        System.Console.Write("Consider the new array : ");
        foreach (var item in arr) System.Console.Write("{0} " , item);
        System.Console.WriteLine();
        System.Console.WriteLine("Index of 5 is : {0}",Array.IndexOf(arr,5));
        System.Console.WriteLine("Index of 6 is : {0}",Array.IndexOf(arr,6));
        System.Console.WriteLine("Index of 5 after index 1 is : {0}",Array.IndexOf(arr,5,2));
        System.Console.WriteLine("Index of 1 between index 1 and index 5 is : {0}",Array.IndexOf(arr,1,2,3));

    }
}
