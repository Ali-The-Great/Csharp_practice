using System.Security.Cryptography.X509Certificates;

namespace revision;

public class ClassIntro
{
    public static void Run(){
        Person p = new("Hussein", 25);
        System.Console.WriteLine(p);
        Person p2 = new("Hussein", 25);
        System.Console.WriteLine(p.Equals(p2));
        System.Console.WriteLine(p.GetHashCode());
        System.Console.WriteLine(p2.GetHashCode());
    }
}

public class Person{
    private readonly string name;
    private readonly int age;
    public Person(string name, int age){
        this.name = name;
        this.age=age;
    }

    public Person(){
        this.name = string.Empty;
        this.age = 0;
    }
    public string GetName(){
        return name;
    }
    public int GetAge(){
        return age;
    }

    public override string ToString()
    {
        return name + ", " + age +" years old.";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Person p) return p.name == this.name && p.age == this.age;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.name, this.age);
    }
}
