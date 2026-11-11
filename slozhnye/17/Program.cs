public class Program
{
    public static void Main()
    {
        Console.Write("Строк (R): ");
        if (!int.TryParse(Console.ReadLine(), out int rows) || rows < 1)
        {
            Console.WriteLine("Размер должен быть целым числом больше нуля!");
            return;
        }
        Console.Write("Столбцов (C): ");
        if (!int.TryParse(Console.ReadLine(), out int cols) || cols < 1)
        {
            Console.WriteLine("Размер должен быть целым числом больше нуля!");
            return;
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
