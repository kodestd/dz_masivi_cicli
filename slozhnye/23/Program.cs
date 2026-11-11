public class Program
{
    public static void Main()
    {
        int[] values = { 9, 3, 7, 1, 5, 2 };

        Console.Write("Было: ");
        PrintArray(values);

        for (int pass = 0; pass < values.Length - 1; pass++)
        {
            bool swapped = false;

            for (int i = 0; i < values.Length - 1 - pass; i++)
            {
                if (values[i] > values[i + 1])
                {
                    int temp = values[i];
                    values[i] = values[i + 1];
                    values[i + 1] = temp;
                    swapped = true;
                }
            }

            Console.Write($"После прохода {pass + 1}: ");
            PrintArray(values);

            if (!swapped)
            {
                Console.WriteLine("Обменов не было — досрочный выход");
                break;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int value in arr)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine();
    }
}
