namespace SonarQube_Demo;

public class EmptyCatch
{
    public void Divide()
    {
        try
        {
            int result = 15 / int.Parse("1");
            System.Console.WriteLine(result);
        }
        catch (Exception e)
        {
            //logged 
            System.Console.WriteLine(e);
        }
    }
}
