public class Program
{
    public static void Main()
    {
        Console.WriteLine("Через while:");
        int i = 1;
        while (i <= 20)
        {
            Console.Write($"{i} ");
            i++;
        }
        Console.WriteLine();

        Console.WriteLine("Через for:");
        for (int j = 1; j <= 20; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
}
