public class Program
{
    public static void Main()
    {
        FindSecondMax(new int[] { 4, 9, 2, 9, 5 });
        FindSecondMax(new int[] { 7, 7, 7 });
    }

    static void FindSecondMax(int[] arr)
    {
        Console.WriteLine($"Массив {string.Join(", ", arr)}:");

        int max = int.MinValue;
        int second = int.MinValue;
        bool hasSecond = false;

        foreach (int x in arr)
        {
            if (x > max)
            {
                if (max != int.MinValue)
                {
                    second = max;
                    hasSecond = true;
                }
                max = x;
            }
            else if (x < max && x > second)
            {
                second = x;
                hasSecond = true;
            }
        }

        if (hasSecond)
            Console.WriteLine($"Максимум: {max}, второе по величине: {second}");
        else
            Console.WriteLine("Меньше двух различных чисел — второго нет");
    }
}
