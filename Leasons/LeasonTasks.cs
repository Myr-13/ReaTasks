namespace Leasons;

public class LeasonTasks
{
	public static void Task1()
	{
		// N13
		
		int N = int.Parse(Console.ReadLine());
		double S = 0;
		int x = 1;
		
		// First
		for (; x <= N; x++)
			S += Math.Pow(Math.Sin(x), 2);
		Console.WriteLine(S);
		
		// Second
		x = 1;
		S = 0;
		while (true)
		{
			S += Math.Pow(Math.Sin(x), 2);
			x++;
			if (x > N)
				break;
		}
		
		Console.WriteLine(S);
		
		// Third
		x = 1;
		S = 0;
		do
		{
			S += Math.Pow(Math.Sin(x), 2);
			x++;
		} while (x <= N);
		
		Console.WriteLine(S);
	}

	public static void Task2()
	{
		// N13
		
		Console.Write("Введите меньший номер билета M: ");
		int m = int.Parse(Console.ReadLine());
		Console.Write("Введите больший номер билета N: ");
		int n = int.Parse(Console.ReadLine());

		// Способ 1: for
		Console.WriteLine("Способ 1 (for):");
		int countFor = 0;
		for (int ticket = m; ticket <= n; ticket++)
		{
			int temp = ticket;
			int evenSum = 0, oddSum = 0;
			int position = 1;
			while (temp > 0)
			{
				int digit = temp % 10;
				if (position % 2 == 0) evenSum += digit;
				else oddSum += digit;
				temp /= 10;
				position++;
			}
			if (evenSum == oddSum) countFor++;
		}
		Console.WriteLine(countFor);

		// Способ 2: while
		Console.WriteLine("Способ 2 (while):");
		int countWhile = 0;
		int ticketWhile = m;
		while (ticketWhile <= n)
		{
			int temp = ticketWhile;
			int evenSum = 0, oddSum = 0;
			int position = 1;
			while (temp > 0)
			{
				int digit = temp % 10;
				if (position % 2 == 0) evenSum += digit;
				else oddSum += digit;
				temp /= 10;
				position++;
			}
			if (evenSum == oddSum) countWhile++;
			ticketWhile++;
		}
		Console.WriteLine(countWhile);

		// Способ 3: do while
		Console.WriteLine("Способ 3 (do while):");
		int countDoWhile = 0;
		int ticketDoWhile = m;
		do
		{
			int temp = ticketDoWhile;
			int evenSum = 0, oddSum = 0;
			int position = 1;
			do
			{
				int digit = temp % 10;
				if (position % 2 == 0) evenSum += digit;
				else oddSum += digit;
				temp /= 10;
				position++;
			}
			while (temp > 0);
			if (evenSum == oddSum) countDoWhile++;
			ticketDoWhile++;
		}
		while (ticketDoWhile <= n);
		Console.WriteLine(countDoWhile);
	}

	public static void Task3()
	{
		// N13
		// Решение ребуса ЧАЙ / АЙ = 5 → ЧАЙ = 5 * АЙ
		
		Console.WriteLine("Ребус: ЧАЙ / АЙ = 5");

		for (int ch = 1; ch <= 9; ch++)  // Ч не может быть 0
		for (int a = 0; a <= 9; a++)
		for (int y = 0; y <= 9; y++)
		{
			if (ch == a || ch == y || a == y) continue; // Все буквы — разные цифры

			int ai = a * 10 + y;     // число АЙ
			int chay = ch * 100 + a * 10 + y; // число ЧАЙ

			if (ai != 0 && chay == 5 * ai)
			{
				Console.WriteLine($"Найдено решение: Ч={ch}, А={a}, Й={y}");
				Console.WriteLine($"{chay} / {ai} = 5");
			}
		}

		Console.WriteLine("Решение не найдено.");
	}
}
