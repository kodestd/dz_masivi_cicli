public class Program
{
    public static void Main()
    {
        Console.Write("Введите положительное целое число: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int value) || value <= 0)
        {
            Console.WriteLine("Нужно положительное целое число!");
            return;
        }

        int digits = 0;
        int temp = value;

        while (temp > 0)
        {
            temp /= 10;
            digits++;
        }

        Console.WriteLine($"В числе {value} цифр: {digits}");
    }
}
