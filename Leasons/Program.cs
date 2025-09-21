using System;

class Program
{
	public static void Task54()
	{
		Console.Write("Введите номер задачи (1-26): ");
		int task = int.Parse(Console.ReadLine());

		switch (task)
		{
			case 1:
				Console.Write("Введите четырехзначное число: ");
				int n1 = int.Parse(Console.ReadLine());
				int a = n1 / 1000;
				int b = (n1 / 100) % 10;
				int c = (n1 / 10) % 10;
				int d = n1 % 10;
				bool res1 = (a + b) == (c + d);
				Console.WriteLine(res1);
				break;

			case 2:
				Console.Write("Введите трехзначное число: ");
				int n2 = int.Parse(Console.ReadLine());
				int sum = (n2 / 100) + ((n2 / 10) % 10) + (n2 % 10);
				bool res2 = sum % 2 == 0;
				Console.WriteLine(res2);
				break;

			case 3:
				Console.Write("Введите x: ");
				double x = double.Parse(Console.ReadLine());
				Console.Write("Введите y: ");
				double y = double.Parse(Console.ReadLine());
				Console.Write("Введите m: ");
				double m = double.Parse(Console.ReadLine());
				Console.Write("Введите n: ");
				double n = double.Parse(Console.ReadLine());
				bool res3 = (x > m && x < n) || (y > m && y < n);
				Console.WriteLine(res3);
				break;

			case 4:
				Console.Write("Введите трехзначное число: ");
				int n4 = int.Parse(Console.ReadLine()); // 10 
				int sum4 = (n4 / 100) + ((n4 / 10) % 10) + (n4 % 10);
				bool res4 = n4 * n4 == sum4 * sum4 * sum4;
				Console.WriteLine(res4);
				break;

			case 5:
				Console.Write("Введите N: ");
				int n5 = int.Parse(Console.ReadLine());
				bool res5 = n5 % 2 == 0 && n5 >= 10 && n5 <= 99;
				Console.WriteLine(res5);
				break;

			case 6:
				Console.Write("Введите a: ");
				double a6 = double.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				double b6 = double.Parse(Console.ReadLine());
				Console.Write("Введите c: ");
				double c6 = double.Parse(Console.ReadLine());
				bool res6 = a6 == b6 && b6 == c6;
				Console.WriteLine(res6);
				break;

			case 7:
				Console.Write("Введите a: ");
				double a7 = double.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				double b7 = double.Parse(Console.ReadLine());
				Console.Write("Введите c: ");
				double c7 = double.Parse(Console.ReadLine());
				bool res7 = a7 == b7 || b7 == c7 || a7 == c7;
				Console.WriteLine(res7);
				break;

			case 8:
				Console.Write("Введите a: ");
				double a8 = double.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				double b8 = double.Parse(Console.ReadLine());
				Console.Write("Введите c: ");
				double c8 = double.Parse(Console.ReadLine());
				bool res8 = (a8 == -b8) || (b8 == -c8) || (a8 == -c8);
				Console.WriteLine(res8);
				break;

			case 9:
				Console.Write("Введите c: ");
				double c9 = double.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				double b9 = double.Parse(Console.ReadLine());
				Console.Write("Введите a: ");
				double a9 = double.Parse(Console.ReadLine());
				Console.Write("Введите d: ");
				double d9 = double.Parse(Console.ReadLine());
				bool res9 = (c9 * c9 + b9 * b9 == a9 * a9) && (a9 * a9 + d9 * d9 == c9 * c9 + b9 * b9);
				Console.WriteLine(res9);
				break;

			case 10:
				Console.Write("Введите стороны первого треугольника (a, b, c): ");
				double a10 = double.Parse(Console.ReadLine());
				double b10 = double.Parse(Console.ReadLine());
				double c10 = double.Parse(Console.ReadLine());
				Console.Write("Введите стороны второго треугольника (d, e, f): ");
				double d10 = double.Parse(Console.ReadLine());
				double e10 = double.Parse(Console.ReadLine());
				double f10 = double.Parse(Console.ReadLine());
				bool res10 = (a10 + b10 + c10 == d10 + e10 + f10);
				Console.WriteLine(res10);
				break;

			case 11:
				Console.Write("Введите a: ");
				int a11 = int.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				int b11 = int.Parse(Console.ReadLine());
				Console.Write("Введите c: ");
				int c11 = int.Parse(Console.ReadLine());
				bool res11 = a11 * a11 + b11 * b11 == c11 * c11;
				Console.WriteLine(res11);
				break;

			case 12:
				Console.Write("Введите четырехзначное число: ");
				int n12 = int.Parse(Console.ReadLine());
				int d1 = n12 / 1000;
				int d2 = (n12 / 100) % 10;
				int d3 = (n12 / 10) % 10;
				int d4 = n12 % 10;
				bool res12 = d1 != d2 && d1 != d3 && d1 != d4 && d2 != d3 && d2 != d4 && d3 != d4;
				Console.WriteLine(res12);
				break;

			case 13:
				Console.Write("Введите x: ");
				double x13 = double.Parse(Console.ReadLine());
				Console.Write("Введите y: ");
				double y13 = double.Parse(Console.ReadLine());
				bool res13 = x13 > 0 && y13 > 0;
				Console.WriteLine(res13);
				break;

			case 14:
				Console.Write("Введите x1: ");
				double x14 = double.Parse(Console.ReadLine());
				Console.Write("Введите y1: ");
				double y14 = double.Parse(Console.ReadLine());
				Console.Write("Введите x2: ");
				double x214 = double.Parse(Console.ReadLine());
				Console.Write("Введите y2: ");
				double y214 = double.Parse(Console.ReadLine());
				Console.Write("Введите x: ");
				double xA = double.Parse(Console.ReadLine());
				Console.Write("Введите y: ");
				double yA = double.Parse(Console.ReadLine());
				bool res14 = xA >= x14 && xA <= x214 && yA >= y14 && yA <= y214;
				Console.WriteLine(res14);
				break;

			case 15:
				Console.Write("Введите a: ");
				double a15 = double.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				double b15 = double.Parse(Console.ReadLine());
				Console.Write("Введите c: ");
				double c15 = double.Parse(Console.ReadLine());
				bool res15 = c15 == (a15 + b15) / 2;
				Console.WriteLine(res15);
				break;

			case 16:
				Console.Write("Введите N: ");
				int n16 = int.Parse(Console.ReadLine());
				bool res16 = Math.Sqrt(n16) == Math.Floor(Math.Sqrt(n16));
				Console.WriteLine(res16);
				break;

			case 17:
				Console.Write("Введите четырехзначное число: ");
				int n17 = int.Parse(Console.ReadLine());
				int d17_1 = n17 / 1000;
				int d17_2 = (n17 / 100) % 10;
				int d17_3 = (n17 / 10) % 10;
				int d17_4 = n17 % 10;
				bool res17 = d17_1 < d17_2 && d17_2 < d17_3 && d17_3 < d17_4;
				Console.WriteLine(res17);
				break;

			case 18:
				Console.Write("Введите трехзначное число: ");
				int n18 = int.Parse(Console.ReadLine());
				int d18_1 = n18 / 100;
				int d18_2 = (n18 / 10) % 10;
				int d18_3 = n18 % 10;
				bool res18 = (d18_2 - d18_1) == (d18_3 - d18_2);
				Console.WriteLine(res18);
				break;

			case 19:
				Console.Write("Введите трехзначное число: ");
				int n19 = int.Parse(Console.ReadLine());
				int d19_1 = n19 / 100;
				int d19_2 = (n19 / 10) % 10;
				int d19_3 = n19 % 10;
				bool res19 = (d19_2 * d19_2) == (d19_1 * d19_3);
				Console.WriteLine(res19);
				break;

			case 20:
				Console.Write("Введите c: ");
				int c20 = int.Parse(Console.ReadLine());
				Console.Write("Введите d: ");
				int d20 = int.Parse(Console.ReadLine());
				Console.Write("Введите a: ");
				int a20 = int.Parse(Console.ReadLine());
				bool res20 = c20 == a20 * a20 && d20 == a20 * a20 * a20;
				Console.WriteLine(res20);
				break;

			case 21:
				Console.Write("Введите M: ");
				int m21 = int.Parse(Console.ReadLine());
				Console.Write("Введите N: ");
				int n21 = int.Parse(Console.ReadLine());
				bool res21 = (n21 / 1000) == m21 || ((n21 / 100) % 10) == m21 || ((n21 / 10) % 10) == m21 ||
				             (n21 % 10) == m21;
				Console.WriteLine(res21);
				break;

			case 22:
				Console.Write("Введите четырехзначное число: ");
				int n22 = int.Parse(Console.ReadLine());
				int r1 = n22 / 1000;
				int r2 = (n22 / 100) % 10;
				int r3 = (n22 / 10) % 10;
				int r4 = n22 % 10;
				bool res22 = r1 == r4 && r2 == r3;
				Console.WriteLine(res22);
				break;

			case 23:
				Console.Write("Введите первое число: ");
				int a23 = int.Parse(Console.ReadLine());
				Console.Write("Введите второе число: ");
				int b23 = int.Parse(Console.ReadLine());
				bool res23 = (a23 + b23) % 2 == 0;
				Console.WriteLine(res23);
				break;

			case 24:
				Console.Write("Введите a: ");
				int a24 = int.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				int b24 = int.Parse(Console.ReadLine());
				Console.Write("Введите c: ");
				int c24 = int.Parse(Console.ReadLine());
				bool res24 = a24 * b24 == c24;
				Console.WriteLine(res24);
				break;

			case 25:
				Console.Write("Введите a: ");
				double a25 = double.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				double b25 = double.Parse(Console.ReadLine());
				bool res25 = (a25 + b25) % 1 == 0;
				Console.WriteLine(res25);
				break;

			case 26:
				Console.Write("Введите a: ");
				int a26 = int.Parse(Console.ReadLine());
				Console.Write("Введите b: ");
				int b26 = int.Parse(Console.ReadLine());
				Console.Write("Введите c: ");
				int c26 = int.Parse(Console.ReadLine());
				bool res26 = a26 % b26 == 0 && a26 % c26 != 0;
				Console.WriteLine(res26);
				break;

			default:
				Console.WriteLine("Неверный номер задачи");
				break;
		}
	}

	public static void Task49()
	{
		Console.Write("m = "); int m = int.Parse(Console.ReadLine());
		Console.Write("n = "); int n = int.Parse(Console.ReadLine());
		Console.Write("k = "); int k = int.Parse(Console.ReadLine());
		TimeOnly time = new(m, n, k);
		Console.WriteLine($"Текущее время: {time.Hour}:{time.Minute}:{time.Second}");
		Console.Write("p = "); int p = int.Parse(Console.ReadLine());
		Console.Write("q = "); int q = int.Parse(Console.ReadLine());
		Console.Write("r = "); int r = int.Parse(Console.ReadLine());
		time = time.Add(new TimeSpan(p, q, r));
		Console.WriteLine($"Обновленное время: {time.Hour}:{time.Minute}:{time.Second}");
	}

	private static void Task50()
	{
		Console.Write("Кошки = "); double c = double.Parse(Console.ReadLine());
		Console.Write("Часы = "); double h = double.Parse(Console.ReadLine());
		Console.WriteLine($"Мышек съедено: {(2.0 * c * h) / 3.0}");
	}

	private static void Task51()
	{
		Console.Write("R = "); double r = double.Parse(Console.ReadLine());
		Console.Write("H = "); double h = double.Parse(Console.ReadLine());
		Console.WriteLine($"Объем цилиндра: {Math.PI * r * r * h}");
		Console.WriteLine($"Объем конуса: {1.0 / 3.0 * Math.PI * r * r * h}");
	}

	private static void Task52()
	{
		Console.Write("Символ: "); int a = Console.Read();
		Console.WriteLine($"Предыдущий символ: {(char)(a - 1)} = {a - 1}");
		Console.WriteLine($"Текущий символ: {(char)a} = {a}");
		Console.WriteLine($"Следующий символ: {(char)(a + 1)} = {a + 1}");
	}

	private static void Task53()
	{
		Console.Write("Кол-во байт = "); int b = int.Parse(Console.ReadLine());
		Console.WriteLine($"Килобайт: {b / 1000.0}");
		Console.WriteLine($"Мегабайт: {b / (1000.0 * 1000.0)}");
		Console.WriteLine($"Гигабайт: {b / (1000.0 * 1000.0 * 1000.0)}");
	}

	public static void Main()
	{
		// Task49();
		Task50();
		// Task51();
		// Task52();
		Task53();
	}
}
