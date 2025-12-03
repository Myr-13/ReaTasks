namespace Leasons;

public class Page260
{
	private static void Task30()
    {
        Console.Write("Введите количество элементов n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        Random rand = new Random();

        Console.Write("Исходный массив: ");
        for (int i = 0; i < n; i++)
        {
            a[i] = rand.Next(-50, 51);
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();

        int min = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i] < min)
                min = a[i];
        }

        Console.WriteLine($"Минимум: {min}");
    }

    private static void Task32()
    {
        int[] cubes = new int[10];
        Random rand = new Random();

        // Заполняем массив случайными числами от 1 до 6 (очки на кубиках)
        Console.Write("Кубики в ячейках: ");
        for (int i = 0; i < 10; i++)
        {
            cubes[i] = rand.Next(1, 7);
            Console.Write(cubes[i] + " ");
        }
        Console.WriteLine();

        // Ищем три соседних ячейки, сумма которых равна 10
        bool found = false;
        for (int i = 0; i <= 7; i++) // i+2 <= 9
        {
            if (cubes[i] + cubes[i + 1] + cubes[i + 2] == 10)
            {
                Console.WriteLine($"Открываем ячейки {i + 1}, {i + 2}, {i + 3} — сумма равна 10.");
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("Не удалось найти три соседние ячейки с суммой 10. Код не разгадан.");
    }

    private static void Task34()
    {
        const int days = 30;
        int[] observations = new int[days];
        Random rand = new Random();

        // Заполняем массив случайными значениями: 1 - солнечный, 0 - пасмурный
        Console.Write("Наблюдения (1 - солнечно, 0 - пасмурно): ");
        for (int i = 0; i < days; i++)
        {
            observations[i] = rand.Next(2);
            Console.Write(observations[i] + " ");
        }
        Console.WriteLine();

        int currentHeight = 0;
        int startDay = 0;

        // Определяем тип дня наблюдения (A-ый день)
        Console.Write("Введите номер дня наблюдения A (от 1 до 30): ");
        int a = int.Parse(Console.ReadLine());
        if (a < 1 || a > 30)
        {
            Console.WriteLine("Некорректный номер дня.");
            return;
        }

        // Считаем высоту улитки к началу A-го дня
        for (int i = 0; i < a - 1; i++)
        {
            if (observations[i] == 1) // солнечный
                currentHeight += 2;
            else // пасмурный
                currentHeight -= 1;
        }

        if (currentHeight < 0)
        {
            Console.WriteLine("Улитка упала с дерева");
            return;
        }

        Console.WriteLine($"Высота улитки к началу {a}-го дня: {currentHeight} см");

        // Определяем тип дня A
        if (observations[a - 1] == 1)
            Console.WriteLine("День наблюдения — солнечный.");
        else
            Console.WriteLine("День наблюдения — пасмурный.");

        // Определяем местоположение улитки к концу 30-го дня
        for (int i = a - 1; i < days; i++)
        {
            if (observations[i] == 1) // солнечный
                currentHeight += 2;
            else // пасмурный
                currentHeight -= 1;
        }

        Console.WriteLine($"Местоположение улитки к концу 30-го дня: {currentHeight} см");
        
        if (currentHeight < 0)
        {
            Console.WriteLine("Улитка упала с дерева");
            return;
        }
    }
    
    private static void Task63()
    {
        Console.Write("Введите размер первого массива n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите размер второго массива m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число k (1 ≤ k ≤ min(n, m)): ");
        int k = int.Parse(Console.ReadLine());

        // Генерация случайных данных
        Random rand = new Random();
        int[] a = new int[n];
        int[] b = new int[m];

        Console.Write("Массив A: ");
        for (int i = 0; i < n; i++)
        {
            a[i] = rand.Next(1, 51);
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Массив B: ");
        for (int i = 0; i < m; i++)
        {
            b[i] = rand.Next(1, 51);
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();

        // Объединение без использования дополнительного массива
        // Сначала копируем элементы из a[0] до a[k-1]
        int[] result = new int[n + m - 2]; // исключаем a[k] и b[k+1]
        int idx = 0;

        for (int i = 0; i < k; i++) // a[0] ... a[k-1]
            result[idx++] = a[i];

        for (int i = k + 1; i < m; i++) // b[k+1] ... b[m-1]
            result[idx++] = b[i];

        // Добавляем оставшиеся элементы из b[k] и далее
        for (int i = k; i < m; i++)
            result[idx++] = b[i];

        // Добавляем оставшиеся элементы из a[k+1] и далее
        for (int i = k + 1; i < n; i++)
            result[idx++] = a[i];

        // Вывод результата
        Console.Write("Объединённый массив (без a[k] и b[k+1]): ");
        for (int i = 0; i < result.Length; i++)
            Console.Write(result[i] + " ");
        Console.WriteLine();
    }

    public static void Run()
    {
        // Task30();
        // Task32();
        // Task34();
        Task63();
    }
}