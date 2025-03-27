namespace revision;

public class AwaitForeach
{
    public static async Task Run(){
        await foreach (var message in GetMessageAsync()) System.Console.WriteLine(message ?? "Received a null message.");      
    }
    public static async IAsyncEnumerable<string?> GetMessageAsync(){
        yield return "Hello!";
        await Task.Delay(500);
        yield return null;
        await Task.Delay(500);
        yield return "How are you?";
    }
}
