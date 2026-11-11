public class Program
{
    public static void Main()
    {
        int[] values = { 6, -2, 13, 9, 0, -5, 13 };

        if (values.Length == 0)
        {
            Console.WriteLine("Массив пустой!");
            return;
        }

        int max = values[0];
        int min = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max) max = values[i];
            if (values[i] < min) min = values[i];
        }

        Console.WriteLine($"Минимум: {min}");
        Console.WriteLine($"Максимум: {max}");

        int[] empty = new int[0];
        Console.WriteLine(empty.Length == 0 ? "Пустой массив обработан без ошибки" : "");
    }
}
