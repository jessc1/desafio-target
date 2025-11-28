public class Program
{
    public static void Main()
    {
        string salesFilePath = "sales.json";
        Commission.CalculateCommissions(salesFilePath);
    }
}