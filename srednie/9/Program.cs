public class Program
{
    public static void Main()
    {
        int[] values = { 3, 8, 2, 5, 14, 7 };

        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        double average = (double)sum / values.Length;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Среднее: {average:0.##}");
    }
}
