using System.Globalization;

namespace revision;

public class Formatting
{
    public static void run(){
        double value = 81.0309;
        Console.WriteLine(value);
        Console.WriteLine("{0:0.000}",value);
        Console.WriteLine("{0:0.###}",value);
        Console.WriteLine("{0:0.00}",value);
        Console.WriteLine("{0:0.0}",value);
        Console.WriteLine("{0:0.#}",value);
        Console.WriteLine((-value).ToString("C"));
        Console.WriteLine(value.ToString("C",CultureInfo.CreateSpecificCulture("en-LB")));
    }
}
