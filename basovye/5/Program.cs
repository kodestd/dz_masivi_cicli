public class Program
{
    public static void Main()
    {
        Console.Write("Введите число: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Это не целое число!");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
