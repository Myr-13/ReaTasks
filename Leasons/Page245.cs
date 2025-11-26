namespace Leasons;

public class Page245
{
    private static void Task20()
    {
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 0; i <= n; i++)
        {
            double term = Math.Pow(-1, i) / Math.Pow(2, i);
            s += term;
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task21()
    {
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        double sinSum = 0;

        for (int i = 1; i <= n; i++)
        {
            sinSum += Math.Sin(i);
            s += 1.0 / sinSum;
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task22()
    {
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        double product = 1;
        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }
        Console.WriteLine($"Произведение первых {n} сомножителей: {product}");
    }

    private static void Task23()
    {
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        double numerator = 1;
        double denominator = 0;
        double s = 1;

        for (int i = 1; i <= n; i++)
        {
            numerator *= Math.Cos(i);
            denominator += Math.Sin(i);
            if (i < n)
                s *= numerator / denominator;
        }

        Console.WriteLine($"S = {s}");
    }

    private static void Task24()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        double s = x;
        int sign = -1;
        int factorial = 1;

        for (int i = 3; i <= 13; i += 2)
        {
            factorial *= i * (i - 1);
            s += sign * Math.Pow(x, i) / factorial;
            sign *= -1;
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task25()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        double s = Math.Sin(x);
        double current = x;

        for (int i = 1; i < n; i++)
        {
            current = Math.Sin(current);
            s += current;
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task26()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double p = 1;
        for (int i = 0; i < n; i++)
        {
            p *= (a + i);
        }
        Console.WriteLine($"P = {p}");
    }

    private static void Task27()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double p = 1;
        for (int i = 0; i < n; i++)
        {
            p *= (a - i * i);
        }
        Console.WriteLine($"P = {p}");
    }

    private static void Task28()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 0; i < n; i++)
        {
            s += 1.0 / Math.Pow(a, 2 * i - 2);
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task29()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        double numerator = 1;
        double denominator = 1;

        for (int i = 1; i <= 32; i++)
        {
            numerator *= (x - (2 * i - 1));
            denominator *= (x - 2 * i);
        }

        double result = numerator / denominator;
        Console.WriteLine($"S = {result}");
    }

    private static void Task30()
    {
        double product = 1;
        for (int i = 1; i <= 10; i++)
        {
            product *= (1 + Math.Sin(i * 0.1));
        }
        Console.WriteLine($"Произведение: {product}");
    }

    private static void Task31()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        double s = Math.Sin(x);
        double power = x;

        for (int i = 2; i <= n; i++)
        {
            power *= x;
            s += Math.Sin(power);
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task32()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += i * (i + 1);
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task33()
    {
        Console.Write("Введите n (n>2): ");
        int n = int.Parse(Console.ReadLine());

        double p = 1;
        for (int i = 2; i <= n; i++)
        {
            p *= (1 - 1.0 / (i * i));
        }
        Console.WriteLine($"P = {p}");
    }

    private static void Task34()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double p = 1;
        for (int i = 1; i <= n; i++)
        {
            p *= (1 - 1.0 / (2 * i));
        }
        Console.WriteLine($"P = {p}");
    }

    private static void Task35()
    {
        Console.Write("Введите n (n>1): ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            s += factorial;
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task36()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += 1.0 / Math.Pow(2 * i + 1, 2);
        }
        Console.WriteLine($"S = {s}");
    }

    private static void Task37()
    {
        int f0 = 1, f1 = 1;
        if (40 == 0 || 40 == 1)
        {
            Console.WriteLine(1);
            return;
        }

        int fn = 0;
        for (int i = 2; i <= 40; i++)
        {
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;
        }
        Console.WriteLine($"f40 = {fn}");
    }

    private static void Task38()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double y = 1;
        for (int i = 1; i <= n; i++)
        {
            y *= (2 * i - 1);
        }
        Console.WriteLine($"y = {y}");
    }

    private static void Task39()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double y = 2;
        for (int i = 2; i <= n; i++)
        {
            y *= (2 * i);
        }
        Console.WriteLine($"y = {y}");
    }

    private static void Task40()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double y = Math.Cos(1);
        double power = 1;

        for (int i = 2; i <= n; i++)
        {
            power *= 1;
            y += Math.Cos(power);
        }
        Console.WriteLine($"y = {y}");
    }

    private static void Task41()
    {
        double y = Math.Sin(1);
        for (double i = 1.1; i <= 2.0; i += 0.1)
        {
            y += Math.Sin(i);
        }
        Console.WriteLine($"y = {y}");
    }

    private static void Task42()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        double s = Math.Sqrt(k);
        for (int i = 1; i <= n - 1; i++)
        {
            s = Math.Sqrt(k * i + s);
        }
        Console.WriteLine($"Результат: {s}");
    }

    private static void Task43()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += (i + 1.0) / i;
        }
        Console.WriteLine($"S = {s}");
    }

    public static void Run()
    {
        Task20();
        Task21();
        Task22();
        Task23();
        Task24();
        Task25();
        Task26();
        Task27();
        Task28();
        Task29();
        Task30();
        Task31();
        Task32();
        Task33();
        Task34();
        Task35();
        Task36();
        Task37();
        Task38();
        Task39();
        Task40();
        Task41();
        Task42();
        Task43();
    }
}
