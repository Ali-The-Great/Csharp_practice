
using System.Reflection.Metadata.Ecma335;

namespace revision;

public class StringConcat
{
    public static void run(){
        String name = "john";
        int age = 25;
        Console.WriteLine("My name is " + name + " , I am " + age + " years old");  //String Concatenation
        Console.WriteLine(String.Concat("My name is ", name , " , I am " , age , " years old"));  //String Concatenation
        Console.WriteLine("My name is {0} , I am {1} years old",name,age);          //String Composite Formatting
        Console.WriteLine($"My name is {name} , I am {age} years old");             //String interpolation
       
    }
}
