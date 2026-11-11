public class Program
{
    public static void Main()
    {
        int[] values = { 1, 2, 3, 4, 5, 6 };

        Console.Write("Назад (массив не изменён): ");
        for (int i = values.Length - 1; i >= 0; i--)
        {
            Console.Write($"{values[i]} ");
        }
        Console.WriteLine();

        int left = 0;
        int right = values.Length - 1;
        while (left < right)
        {
            int temp = values[left];
            values[left] = values[right];
            values[right] = temp;
            left++;
            right--;
        }

        Console.Write("Развёрнут на месте: ");
        foreach (int value in values)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine();
    }
}
