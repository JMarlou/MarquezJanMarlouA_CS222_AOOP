using System;

class SquarePatternWithSkippedRow
{
    static void Main()
    {
        Console.Write("Enter the size of the square (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the row number to skip (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            if (row == y)
            {
                Console.WriteLine();
                continue;
            }

            for (int col = 1; col <= n; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
