namespace revision;

public class DelegatesExample
{
    public delegate void PointDelegate(string s);
    public static void Run(){
#pragma warning disable IDE0039
        PointDelegate OnePoint = (string s) => {
            System.Console.WriteLine(s+".");
        };

        PointDelegate ThreePoints = (string s) => {
            System.Console.WriteLine(s+"...");
        };
#pragma warning restore IDE0039

        OnePoint("I hate you");
        ThreePoints("I hate you");

        static void Print(PointDelegate l){
            l("i love fish");
        }

        Print(OnePoint);
        Print(ThreePoints);

    }
}
