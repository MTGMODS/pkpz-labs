using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[n][];
        int maxCols = 0;

    
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть елементи для рядка {i + 1} через пробіл: ");
            string[] input = Console.ReadLine().Split();
            jaggedArray[i] = Array.ConvertAll(input, int.Parse);
            if (jaggedArray[i].Length > maxCols)
                maxCols = jaggedArray[i].Length;
        }

        Console.Write("Введіть k1 (початковий рядок, з 1): ");
        int k1 = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Введіть k2 (кінцевий рядок, з 1): ");
        int k2 = int.Parse(Console.ReadLine()) - 1;

        if (k1 < 0 || k2 >= n || k1 > k2)
        {
            Console.WriteLine("Некоректні значення k1 або k2.");
            return;
        }

        int[] productArray = new int[maxCols];

       
        for (int j = 0; j < maxCols; j++)
            productArray[j] = 1;

        
        for (int i = k1; i <= k2; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                productArray[j] *= jaggedArray[i][j];
            }
        }

      
        Console.WriteLine("\nДобутки по стовпцях з рядків k1 до k2:");
        for (int j = 0; j < maxCols; j++)
            Console.WriteLine($"Стовпець {j + 1}: {productArray[j]}");
    }
}