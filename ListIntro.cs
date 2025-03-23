using System.Diagnostics.Metrics;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace revision;

public class ListIntro
{
    public static void Run(){
        List<int> L = [];
        System.Console.WriteLine("Add 10 numbers to the list (default is 0) :");
        for (int i = 0; i < 10; i++)
        {
            if(int.TryParse(Console.ReadLine(),out int num)) L.Add(num);
            else L.Add(0);
        }
        System.Console.WriteLine("count of numbers in list : {0}",L.Count);
        System.Console.Write("items in the list : ");
        foreach (int item in L) System.Console.Write("{0} ",item);
        System.Console.WriteLine();
    }
}
