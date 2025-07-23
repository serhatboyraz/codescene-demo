namespace SonarQube_Demo;

public class FileWriter
{
    public void WriteFile()
    {
        var writer = new StreamWriter("output.txt");
        writer.WriteLine("Hello");
        // writer.Dispose(); eksik
    }
}