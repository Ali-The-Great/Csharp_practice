using System.Diagnostics.CodeAnalysis;

namespace revision;

public class StructExample
{
    public static void Run(){
        Person p1 = new(name:"Kamal",age:25);
        Person p2 = new(name:"Kamal",age:25);
        System.Console.WriteLine("are p1 and p2 the same person ? " + (p1.Equals(p2) ? "yes" : "no"));
        System.Console.WriteLine(p1);

    }

    readonly struct Person(int age, string name)
    {
        public int Age {get;} = age;
        public string Name {get;} = name; 
        public override readonly string ToString()
        {
            return "Name : " + Name + " , Age : " + Age;
        }
        public override readonly bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is Person p) return this.Name == p.Name && this.Age ==p.Age;
            return false;
            
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Age);
        }
    }
}