namespace revision;

public class EvenOddSplit
{
    public static void Run(){
        
        List<int> Odd =[];
        List<int> Even = [];
        
        for (int i = 0; i < 51; i++)
        {  
            if(i%2==0) Even.Add(i);
            else Odd.Add(i);
        }

        System.Console.Write("Odd: ");
        for (int i = 0; i < Odd.Count; i++)System.Console.Write("{0} ",Odd[i]);
        System.Console.WriteLine();

        System.Console.Write("Even: ");
        for (int i = 0; i < Even.Count; i++)System.Console.Write("{0} ",Even[i]);
        System.Console.WriteLine();

    }
}
