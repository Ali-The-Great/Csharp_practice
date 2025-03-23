using System.ComponentModel.DataAnnotations;

namespace revision;

public class StringLooping
{
    public static void run(){
        String ninja = @"The phrase ""it's just a game"" is such a weak mindset. You are ok with what happened, losing, imperfection of a craft. When you stop getting angry after losing, you've lost twice

        There's always something important to learn, and always room for improvement, never settle";
        int length =ninja.Length;
        for (int i = 0; i < length; i++)
        {
            System.Console.Write(ninja[i]);
            Thread.Sleep(50);
        }
        System.Console.WriteLine();

        if (ninja.Contains("phrase")) System.Console.WriteLine("\n- - - - - ninja copypasta - - - - -");
    }
}
