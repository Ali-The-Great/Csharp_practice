namespace revision;

public class StackIntro
{
    public static void Run(){
        Stack<int> s = new();
        s.TryPeek(out int result);
        System.Console.WriteLine(result);
        s.TryPop(out result);
        System.Console.WriteLine(result);
        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);
        s.Push(5);
        System.Console.WriteLine(s.Peek());
        System.Console.WriteLine(s.Pop());
        System.Console.WriteLine(s.Peek());
        System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        Stack<int> s2 =new();
        int amount = s.Count;
        for (int i = 0; i < amount; i++)
        {
            System.Console.WriteLine(s.Peek());
            s2.Push(s.Pop());
        }
        System.Console.WriteLine("- - - - - - - - -");
        for (int i = 0; i < amount; i++)
        {
            System.Console.WriteLine(s2.Pop());
        }
    }
}
