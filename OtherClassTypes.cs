namespace revision;

public class OtherClassTypes
{
    public static void Run(){
        PartialClass.P1();
        PartialClass.P2();
        SealedClass s = new(25);
        s.Run();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        System.Console.WriteLine("End of Program.");
    }
}

file sealed class SealedClass(int num){
    public int Num { get; set; } = num;
    public void Run(){
        System.Console.WriteLine("this is a sealed class. num is {0}",Num);
    }
    ~SealedClass(){
        System.Console.WriteLine("Destructor called for sealed class.");
    }
}
