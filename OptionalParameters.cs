using System.Runtime.InteropServices;

namespace revision;

public class OptionalParameters
{
    public static void Run(){
        System.Console.Write("Input: ");
        if (!int.TryParse(Console.ReadLine(),out int a)) a = 0;
        Addv(a,out int v);
        System.Console.Write("Output: {0} \n",Add(a));
        System.Console.Write("Output: {0} \n",Add2(b:a));
        System.Console.Write("Output: {0} \n",v);


    }
    static int Add(int a , [Optional] int b){
        return a + b;
    }
    static int Add2(int a = default, int b = default){
        return a + b;
    }

    static void Addv(int a , out int v){
        v = a + a;
    }

}
