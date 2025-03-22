namespace revision;

public class Conversion
{
    public static void run(){
        string s = "235";
        string s2 = "true";
        int i = Convert.ToInt32(s);
        long l = Convert.ToInt64(s);
        float f = Convert.ToSingle(s);
        double d = Convert.ToDouble(s);
        decimal dec = Convert.ToDecimal(s);
        bool b = Convert.ToBoolean(s2);
        char c = Convert.ToChar(s[0]);
        byte bte = Convert.ToByte(s);
        short sh = Convert.ToInt16(s);
        uint ui = Convert.ToUInt32(s);
        ulong ul = Convert.ToUInt64(s);
        ushort ush = Convert.ToUInt16(s);

        Console.WriteLine("{0} is a string", s);
        Console.WriteLine("{0} is the int conversion", i);
        Console.WriteLine("{0} is the long conversion", l);
        Console.WriteLine("{0} is the float conversion", f);
        Console.WriteLine("{0} is the double conversion", d);
        Console.WriteLine("{0} is the decimal conversion", dec);
        Console.WriteLine("{0} is the bool conversion", b);
        Console.WriteLine("{0} is the char conversion", c);
        Console.WriteLine("{0} is the byte conversion", bte);
        Console.WriteLine("{0} is the short conversion", sh);
        Console.WriteLine("{0} is the uint conversion", ui);
        Console.WriteLine("{0} is the ulong conversion", ul);
        Console.WriteLine("{0} is the ushort conversion", ush);
    }
}

