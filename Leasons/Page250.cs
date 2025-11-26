namespace Leasons;

public class Page250
{
    private static void Task101()
    {
        Console.Write("Введите натуральное число n (n <= 99): ");
        int n = int.Parse(Console.ReadLine());
        int k = n % 10;
        int result = k * 100 + n * 10 + k;
        Console.WriteLine($"Результат: {result}");
    }

    private static void Task113()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Совершенные числа, меньшие N:");
        for (int m = 2; m < n; m++)
        {
            int sumDivisors = 1; // 1 всегда делитель
            for (int i = 2; i <= m / 2; i++)
            {
                if (m % i == 0)
                    sumDivisors += i;
            }
            if (sumDivisors == m)
                Console.WriteLine(m);
        }
    }

    private static void Task114()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Числа Пифагора, меньшие N:");
        for (int a = 1; a < n; a++)
        {
            for (int b = a; b < n; b++)
            {
                int cSquared = a * a + b * b;
                int c = (int)Math.Sqrt(cSquared);
                if (c * c == cSquared && c < n)
                    Console.WriteLine($"({a}, {b}, {c})");
            }
        }
    }

    private static void Task112()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Делители числа {n}:");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    private static void Task118()
    {
        Console.Write("Введите целое число n > 2: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Простые числа в диапазоне [2, {n}]:");
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    private static void Task120()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        int maxSum = 0;
        int bestNumber = 1;

        for (int i = 1; i <= n; i++)
        {
            int sumDivisors = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    sumDivisors += j;
            }
            if (sumDivisors > maxSum)
            {
                maxSum = sumDivisors;
                bestNumber = i;
            }
        }

        Console.WriteLine($"Число с максимальной суммой делителей: {bestNumber} (сумма = {maxSum})");
    }

    private static void Task125()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                count++;
        }

        Console.WriteLine($"Количество натуральных чисел <= {n}, не делящихся на 2, 3 или 5: {count}");
    }

    public static void Run()
    {
        Task101();
        Task113();
        Task114();
        Task112();
        Task118();
        Task120();
        Task125();
    }
}
