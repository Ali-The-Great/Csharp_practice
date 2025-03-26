namespace revision;

public class QueueIntro
{
    public static void Run(){
        Queue<int> q = new();
        q.TryDequeue(out int result);
        System.Console.WriteLine(result);
        q.Enqueue(3);
        System.Console.WriteLine(q.Peek());
        q.Enqueue(4);
        System.Console.WriteLine(q.Dequeue());      
        System.Console.WriteLine(q.Dequeue());      
    }
}
