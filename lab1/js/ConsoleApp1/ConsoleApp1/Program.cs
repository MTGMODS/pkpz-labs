using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть R: ");
        double R = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        string result = CheckPoint(x, y, R);
        Console.WriteLine("Результат: " + result);
    }

    static string CheckPoint(double x, double y, double R)
    {
     
        if (x >= 0 && y >= 0)
        {
            double dist = Math.Sqrt(x * x + y * y);
            if (Math.Abs(dist - R) < 1e-6)
                return "На межі";
            else if (dist < R)
                return "Так";
            else
                return "Ні";
        }

        // Третя чверть — трикутник, обмежений y = x, x ≥ -R, y ≥ -R
        if (x <= 0 && y <= 0)
        {
            if (x >= -R && y >= -R)
            {
                if (Math.Abs(x - y) < 1e-6 || Math.Abs(x + R) < 1e-6 || Math.Abs(y + R) < 1e-6)
                    return "На межі";
                else if (y >= x)
                    return "Так";
                else
                    return "Ні";
            }
        }

        return "Ні";
    }
}
