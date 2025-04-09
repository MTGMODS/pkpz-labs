using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[6, 5];
        Random rnd = new Random();

     
        for (int i = 0; i < 6; i++)
        for (int j = 0; j < 5; j++)
            matrix[i, j] = rnd.Next(-50, 50);


        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        int maxCol = 0, minCol = 0;
        int maxAbs = Math.Abs(matrix[0, 0]);
        int minAbs = Math.Abs(matrix[0, 0]);


        for (int j = 0; j < 5; j++)
        {
            for (int i = 0; i < 6; i++)
            {
                int val = Math.Abs(matrix[i, j]);
                if (val > maxAbs)
                {
                    maxAbs = val;
                    maxCol = j;
                }
                if (val < minAbs)
                {
                    minAbs = val;
                    minCol = j;
                }
            }
        }
        
        for (int i = 0; i < 6; i++)
        {
            int temp = matrix[i, maxCol];
            matrix[i, maxCol] = matrix[i, minCol];
            matrix[i, minCol] = temp;
        }

        Console.WriteLine("\nМатриця після обміну стовпців:");
        PrintMatrix(matrix);
        Console.WriteLine($"\nНомери стовпців (0-based): мінімальний = {minCol}, максимальний = {maxCol}");
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j],4}");
            Console.WriteLine();
        }
    }
}