namespace revision;

public class MultipleInheritance
{
    public static void Run(){
#pragma warning disable CA1859
    IAnimal C = new Camel("greg");
#pragma warning restore CA1859
    C.MakeSound();
    ((IVehicle)C).Ride();
    }    
}

file class Camel(string name) : IAnimal,IVehicle{
    
    public string Name { get; set; } = name;

    public void MakeSound()
    {
        System.Console.WriteLine($"Camel {Name} is making noise.");
    }

    public void Ride()
    {
        System.Console.WriteLine($"I am riding Camel {Name}");
    }
}

file interface IAnimal
{
    public void MakeSound();
}

file interface IVehicle
{
    public void Ride();
}