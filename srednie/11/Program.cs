public class Program
{
    public static void Main()
    {
        int[] values = { 4, -1, 0, 7, -3, 0, 2, -8, 5 };

        int positive = 0, negative = 0, zeros = 0;

        foreach (int value in values)
        {
            if (value > 0) positive++;
            else if (value < 0) negative++;
            else zeros++;
        }

        Console.WriteLine($"Положительных: {positive}");
        Console.WriteLine($"Отрицательных: {negative}");
        Console.WriteLine($"Нулей: {zeros}");
    }
}
