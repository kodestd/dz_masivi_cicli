public class Program
{
    public static void Main()
    {
        int[] grades = { 5, 4, 3, 5, 4 };

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"{grades[i]} ");
        }
        Console.WriteLine();

        grades[2] = 5;

        foreach (int grade in grades)
        {
            Console.Write($"{grade} ");
        }
        Console.WriteLine();
    }
}
