public class Program
{
    public static void Main()
    {
        int[] values = { 9, 4, 7, 2, 7, 5 };
        int target = 7;

        int index = -1;
        for (int i = values.Length - 1; i >= 0; i--)
        {
            if (values[i] == target)
            {
                index = i;
                break;
            }
        }

        Console.WriteLine($"Последний индекс числа {target}: {index}");
    }
}
