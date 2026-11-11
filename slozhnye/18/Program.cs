public class Program
{
    public static void Main()
    {
        Console.Write("Высота треугольника (N): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("N должен быть целым числом больше нуля!");
            return;
        }

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
