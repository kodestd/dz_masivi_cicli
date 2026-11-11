public class Program
{
    public static void Main()
    {
        int[] values = { 1, 2, 3, 4, 5, 6 };

        Console.Write("Было: ");
        foreach (int value in values)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine();

        int last = values[values.Length - 1];
        for (int i = values.Length - 1; i > 0; i--)
        {
            values[i] = values[i - 1];
        }
        values[0] = last;

        Console.Write("Стало: ");
        foreach (int value in values)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine();
    }
}
