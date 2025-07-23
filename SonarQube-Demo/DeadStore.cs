namespace SonarQube_Demo;

public class DeadStore
{
    public void DoSomething()
    {
        int x = 5;
        x = 10;
        Console.WriteLine(x);
    }
}