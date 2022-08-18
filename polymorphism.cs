using System; 

public class Human
{
    public virtual void work()
    {
        Console.WriteLine("Every human do some work according to their occupation.");
    }
}

public class Students:  Human
{
    public override void work()
    {
        base.work();
        Console.WriteLine("Students study to built their career.");
        Console.WriteLine("........................");
    }
}

public class Employee: Human
{
    public override void work()
    {
        base.work();
        Console.WriteLine("Employee work hard to gain knowledge and money.");
        Console.WriteLine("........................");

    }
}

public class poly
{
    public static void Main(String[] args)
    {
        Students st = new Students();
        st.work();

        Employee emp = new Employee();
        emp.work();
    }
}