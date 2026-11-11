public class Program
{
    public static void Main()
    {
        int[] numbers = { 12, 7, 19, 4, 11, 25, 3, 8 };

        Console.WriteLine($"Длина массива: {numbers.Length}");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Индекс [{i}] = {numbers[i]}");
        }
    }
}
