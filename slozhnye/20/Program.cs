public class Program
{
    public static void Main()
    {
        int[] values = { 5, 1, 3, 1, 5, 7, 3, 2, 7 };

        for (int i = 0; i < values.Length; i++)
        {
            bool seen = false;
            for (int j = 0; j < i; j++)
            {
                if (values[j] == values[i])
                {
                    seen = true;
                    break;
                }
            }

            if (!seen)
            {
                Console.Write($"{values[i]} ");
            }
        }
        Console.WriteLine();
    }
}
