namespace revision;

public class ExceptionHandling
{
    public static void Run(){
        try
        {
            System.Console.Write("Enter a num: ");
            int a = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Success");
        }
        catch(OverflowException e){
            //System.Console.WriteLine("num too big.");
            System.Console.WriteLine(e.Message);
        }
        catch(FormatException e){
            //System.Console.WriteLine("Please enter a proper num.");
            System.Console.WriteLine(e.Message);
        }
        catch (System.Exception e)
        {
            
            //System.Console.WriteLine("Something went wrong.");
            System.Console.WriteLine(e.Message);
        }

        System.Console.WriteLine("End.");
    }
}
