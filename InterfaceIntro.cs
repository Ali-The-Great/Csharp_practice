namespace revision;

public class InterfaceIntro
{
    public static void Run(){
        IStudent s = new Student(25,"Issa");
        s.GreetStudent();
    }
}

public interface IStudent
{
    public int StudentNum { get; set; }
    public string? StudentName { get; set; }

    public void GreetStudent();
}

public class Student(int num, string name) : IStudent
{
    public int StudentNum { get; set; } = num;
    public string? StudentName { get; set; } = name;

    public void GreetStudent()
    {
        System.Console.WriteLine("Hey {0}.",this.StudentName);
    }
}