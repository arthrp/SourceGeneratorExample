namespace SourceGeneratorExample;
    
public static class Program
{
    public static void Main()
    {
        var helper = new MathHelper();
        Console.WriteLine(helper.Add(1,2));
        Console.WriteLine(helper.Subtract(2,1));
    }
}