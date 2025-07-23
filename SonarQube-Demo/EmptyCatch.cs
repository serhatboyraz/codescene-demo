namespace SonarQube_Demo;

public class EmptyCatch
{
    public void Divide()
    {
        try
        {
            int result = 10 / int.Parse("0");
        }
        catch (Exception e)
        {
            //ignored. 
        }
    }
}
