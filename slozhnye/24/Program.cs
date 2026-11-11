public class Program
{
    public static void Main()
    {
        int[] warehouses = { 12, 0, 7, 25, 0, 15, 8, 0, 3, 20 };

        Console.Write("Склады: ");
        for (int i = 0; i < warehouses.Length; i++)
        {
            Console.Write($"[{i}]={warehouses[i]} ");
        }
        Console.WriteLine();

        int sum = 0;
        for (int i = 0; i < warehouses.Length; i++)
        {
            sum += warehouses[i];
        }
        Console.WriteLine($"Общая сумма запасов: {sum}");

        int max = warehouses[0];
        int min = warehouses[0];
        for (int i = 1; i < warehouses.Length; i++)
        {
            if (warehouses[i] > max) max = warehouses[i];
            if (warehouses[i] < min) min = warehouses[i];
        }
        Console.WriteLine($"Максимальный запас: {max}");
        Console.WriteLine($"Минимальный запас: {min}");

        int i2 = 0;
        int empty = 0;
        while (i2 < warehouses.Length)
        {
            if (warehouses[i2] == 0) empty++;
            i2++;
        }
        Console.WriteLine($"Пустых складов: {empty}");

        Console.Write("Какое количество ищем (первый склад с таким запасом)? ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int target))
        {
            Console.WriteLine("Это не целое число!");
            return;
        }

        int index = 0;
        int found = -1;
        while (index < warehouses.Length)
        {
            if (warehouses[index] == target)
            {
                found = index;
                break;
            }
            index++;
        }

        if (found >= 0)
            Console.WriteLine($"Первый склад с количеством {target}: индекс {found}");
        else
            Console.WriteLine($"Склада с количеством {target} нет");
    }
}
