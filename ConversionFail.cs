namespace revision;

public class ConversionFail
{
    public static void Run(){
        bool success = false;
        while (!success)
        {
            Console.Write("Enter a number: ");
            string? numInput = Console.ReadLine();

            if (int.TryParse(numInput, out int num))
            {
                success=true;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Failed Conversion.");
            }
        }
    } 
}
