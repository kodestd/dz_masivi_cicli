public class Program
{
    public static void Main()
    {
        Console.Write("Введите N: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int n))
        {
            Console.WriteLine("Это не целое число!");
            return;
        }

        if (n < 1)
        {
            Console.WriteLine("N должен быть не меньше 1!");
            return;
        }

        int sum = 0;
        int i = 1;
        while (i <= n)
        {
            sum += i;
            i++;
        }

        Console.WriteLine($"Сумма чисел от 1 до {n} = {sum}");
    }
}
