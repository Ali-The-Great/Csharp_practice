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
    public string Name { get;}
    public int Age { get;}
    public Person(string name, int age){
        this.Name = name;
        this.Age=age;
    }

    public Person(){
        this.Name = string.Empty;
        this.Age = 0;
    }

    public override string ToString()
    {
        return Name + ", " + Age +" years old.";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Person p) return p.Name == this.Name && p.Age == this.Age;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.Name, this.Age);
    }
}
