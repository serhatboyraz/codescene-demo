namespace SonarQube_Demo;

public class EmptyCatch
{
    public void Divide()
    {
        try
        {
            int result = 10 / int.Parse("0");
            System.Console.WriteLine(result);
        }
        catch (Exception e)
        {
            //logged 
            System.Console.WriteLine(e);
        }
    }
}
