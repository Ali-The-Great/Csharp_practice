namespace revision;

public class AreaTriangle
{
    public static void Run(){
        System.Console.Write("Enter width: ");
        if (!int.TryParse(Console.ReadLine(),out int width)) width = 1;
        System.Console.Write("Enter height: ");
        if (!int.TryParse(Console.ReadLine(),out int height)) height = 1;
        System.Console.WriteLine(TriangleArea(width,height));
    }
    static float TriangleArea(int w, int h){
        return w*h/2F;
    }
}
