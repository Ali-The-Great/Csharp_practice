namespace revision;

public class DataTypes
{
    public static void Run()
    {
        // signed short (16-bit signed integer)
        //short signedShort = 5; // Assigned as a regular integer
        Console.WriteLine("signed short range: {0}, {1}", short.MinValue, short.MaxValue);

        // unsigned short (16-bit unsigned integer)
        //ushort unsignedShort = 5U; // Assigned with the U suffix for unsigned
        Console.WriteLine("unsigned short range: {0}, {1}", ushort.MinValue, ushort.MaxValue);

        // signed int (32-bit signed integer)
        //int signedInt = 5; // Assigned as a regular integer
        Console.WriteLine("signed int range: {0}, {1}", int.MinValue, int.MaxValue);

        // unsigned int (32-bit unsigned integer)
        //uint unsignedInt = 5U; // Assigned with the U suffix for unsigned
        Console.WriteLine("unsigned int range: {0}, {1}", uint.MinValue, uint.MaxValue);

        // signed long (64-bit signed integer)
        //long signedLong = 5L; // Assigned with the L suffix for long
        Console.WriteLine("signed long range: {0}, {1}", long.MinValue, long.MaxValue);

        // unsigned long (64-bit unsigned integer)
        //ulong unsignedLong = 5UL; // Assigned with the UL suffix for unsigned long
        Console.WriteLine("unsigned long range: {0}, {1}", ulong.MinValue, ulong.MaxValue);

        // signed byte (8-bit signed integer)
        //sbyte signedByte = 5; // Assigned as a regular integer
        Console.WriteLine("signed byte range: {0}, {1}", sbyte.MinValue, sbyte.MaxValue);

        // unsigned byte (8-bit unsigned integer)
        //byte unsignedByte = 5U; // Assigned with the U suffix for unsigned byte
        Console.WriteLine("unsigned byte range: {0}, {1}", byte.MinValue, byte.MaxValue);

        // float (32-bit floating-point number)
        //float floatValue = 5.5F; // Assigned with the F suffix for float
        Console.WriteLine("float range: {0}, {1}", float.MinValue, float.MaxValue);

        // double (64-bit floating-point number)
        //double doubleValue = 5.5; // Assigned as a regular double
        Console.WriteLine("double range: {0}, {1}", double.MinValue, double.MaxValue);

        // decimal (128-bit precise decimal type)
        //decimal decimalValue = 5.5M; // Assigned with the M suffix for decimal
        Console.WriteLine("decimal range: {0}, {1}", decimal.MinValue, decimal.MaxValue);

        // char (Unicode character, 16-bit)
        //char characterValue = 'A'; // Assigned as a regular character
        Console.WriteLine("char range: {0}, {1}", (int)char.MinValue, (int)char.MaxValue);

        // bool (Boolean type)
        bool isTrue = true; // Assigned as a true or false value
        Console.WriteLine("bool value: {0}", isTrue);

        // string (sequence of characters)
        string greeting = "Hello, World!"; // Assigned as a regular string
        Console.WriteLine("string value: {0}", greeting);

        // object (base type for all types)
        object objValue = 5; // Can store any type (e.g., int, string, etc.)
        Console.WriteLine("object value: {0}", objValue);

        // dynamic (type resolved at runtime)
        dynamic dynamicValue = 10; // Assigned dynamically; type is determined at runtime
        Console.WriteLine("dynamic value: {0}", dynamicValue);

        // Nullable types (can hold null values)
        int? nullableInt = null; // Assigned with a nullable type, can be null
        Console.WriteLine("nullable int value: {0}", nullableInt.HasValue ? nullableInt.ToString() : "null");

        unsafe{
            int num = 5;
            int* pointer = &num; // Pointer type that holds the memory address of a variable
            Console.WriteLine("Pointer value: {0}", *pointer);
            Console.WriteLine("Pointer value address: {0}", (IntPtr)pointer);

        }
    }
}
