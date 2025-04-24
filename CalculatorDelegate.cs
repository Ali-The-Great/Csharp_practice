namespace revision;

public static class CalculatorDelegate
{
    private delegate int MathOp(int a , int b);
    private static int Add(int a, int b) => a + b;
    private static int Mult(int a , int b) => a * b;
    private static int Sub(int a,int b) => a - b;
    private static int Div(int a, int b) => a/b;
    
    // the way this code works is similar to a strategy pattern

    public static void Run(){
        Console.WriteLine("Enter operation (+, -, *, /): ");
        string? op = Console.ReadLine();

        Console.WriteLine("Enter first number: ");
        if (!int.TryParse(Console.ReadLine(), out var a))
        {
            a = 0;
            Console.WriteLine("Invalid number. Defaulting to 0.");
        }

        Console.WriteLine("Enter second number: ");
        if (!int.TryParse(Console.ReadLine(), out var b))
        {
            b = 0;
            Console.WriteLine("Invalid number. Defaulting to 0.");
        }

        MathOp operation;

        switch (op)
        {
            case "+":
                operation = Add;
                break;
            case "-":
                operation = Sub;
                break;
            case "*":
                operation = Mult;
                break;
            case "/":
                operation = Div;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        if (operation == Div && b == 0)
        {
            Console.WriteLine("Division by zero. Indefinite result.");
            return;
        }
        int result = Ope(operation, a, b);

        if (op == "/")
        {
            double realResult = (double)a / b;
            Console.WriteLine($"Result: {realResult} (real), {result} (integer division)");
        }
        else
        {
            Console.WriteLine($"Result: {result}");
        }
    }

    private static int Ope(MathOp ope,int a,int b){
        return ope(a,b);
    }
}
