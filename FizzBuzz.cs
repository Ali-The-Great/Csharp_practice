namespace revision;

public class FizzBuzz
{
    public static void run(){
        for (int i = 1; i <= 20; i++)
        {
            String Message = "";
            Message += i % 3 == 0 ? "Fizz" : "";
            Message += i % 5 == 0 ? "Buzz" : "";
            Console.WriteLine("{0} : {1}",i,Message); 
        }
    }
}
