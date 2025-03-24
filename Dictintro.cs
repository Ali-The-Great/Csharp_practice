using System.Collections.Generic;
namespace revision;

public class Dictintro
{
    public static void Run(){
        Dictionary<int , string> dict = new() { {1,"deez"},{2,"Nuts"}};
        for (int i = 0; i < dict.Count; i++)
        {
            KeyValuePair<int,string> pair = dict.ElementAt(i);
            System.Console.WriteLine("{0} : {1}" , pair.Key , pair.Value);
        }

        if (dict.TryGetValue(3,out string? dic))
        {
            System.Console.WriteLine(dic);
        }
        else System.Console.WriteLine("no value");
        if (dict.TryGetValue(2,out string? dic2))
        {
            System.Console.WriteLine(dic2);
        }
        else System.Console.WriteLine("no value");
        
    }
    
}
