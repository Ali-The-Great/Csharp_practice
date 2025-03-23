namespace revision;

public class PasswordChecker
{
    public static void Run(){
        System.Console.Write("Enter a Password: ");
        String Pass = Console.ReadLine() ?? "";
        System.Console.Write("Enter the Password again: ");
        String Pass2 = Console.ReadLine() ?? "";
        if (!String.IsNullOrEmpty(Pass))
        {
            bool contain = Pass2.Contains(Pass[0]);
            System.Console.WriteLine("Both Passwords Contain {0} : {1}",Pass[0],contain);
            if(contain) System.Console.WriteLine( Pass.Equals(Pass2) ? "Passwords match":"Passwords do not match");
        }
        else System.Console.WriteLine("Please enter a password.");
    }
}
