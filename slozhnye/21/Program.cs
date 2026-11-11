public class Program
{
    public static void Main()
    {
        int[] values = { 2, 7, 11, 15, 1, 8 };

        Console.Write("Искомая сумма K: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int k))
        {
            Console.WriteLine("Это не целое число!");
            return;
        }

        bool found = false;
        for (int i = 0; i < values.Length && !found; i++)
        {
            for (int j = i + 1; j < values.Length; j++)
            {
                if (values[i] + values[j] == k)
                {
                    Console.WriteLine($"Пара: индексы {i} и {j} ({values[i]} + {values[j]} = {k})");
                    found = true;
                    break;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("нет пары");
        }
    }
}
