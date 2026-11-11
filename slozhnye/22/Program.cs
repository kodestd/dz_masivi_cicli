public class Program
{
    public static void Main()
    {
        int[,] map = new int[3, 4];

        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int col = 0; col < map.GetLength(1); col++)
            {
                map[row, col] = row * 10 + col + 1;
            }
        }

        for (int row = 0; row < map.GetLength(0); row++)
        {
            int sum = 0;
            for (int col = 0; col < map.GetLength(1); col++)
            {
                Console.Write($"{map[row, col],5}");
                sum += map[row, col];
            }
            Console.WriteLine($"  | сумма строки = {sum}");
        }
    }
}
