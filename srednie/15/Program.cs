public class Program
{
    public static void Main()
    {
        int[] values = { 1, 3, 3, 5, 8, 9 };

        bool sorted = true;
        for (int i = 0; i < values.Length - 1; i++)
        {
            if (values[i] > values[i + 1])
            {
                sorted = false;
                break;
            }
        }

        Console.WriteLine(sorted ? "Массив отсортирован по неубыванию" : "Массив НЕ отсортирован по неубыванию");
    }
}
