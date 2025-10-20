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

	private static bool CheckPoint(int figureNumber, double x, double y)
	{
		switch (figureNumber)
		{
			case 4:
				return Math.Abs(x - 4) + Math.Abs(y - 4) <= 2;
			case 9:
				return (x >= 2) && (x <= 6) &&
				       (y >= 0.5 * x - 1) && (y <= 0.5 * x + 3);
			case 13:
				return y >= -2 &&
				       y <= (3.0 / 2) * x + 4 &&
				       y <= (-3.0 / 2) * x + 4;
			case 14:
				return y >= 0 && y <= 4 &&
				       y <= 2 * x + 12 &&
				       y <= -2 * x + 12;
			case 15:
				return x >= 2 && y <= -0.75 * x + 5.5 && y >= 0.75 * x - 3.5;
			case 23:
				return y >= 0 && x * x + y * y >= 4 && x * x + y * y <= 25;
			default: Console.WriteLine("Неверная фигура"); return false;
		}
	}

	private static void Task55()
	{
		Console.Write("Введите номер фигуры (4, 9, 13, 14, 15, 23): ");
		int figureNumber = int.Parse(Console.ReadLine());
		Console.Write("Введите x: ");
		double x = double.Parse(Console.ReadLine());
		Console.Write("Введите y: ");
		double y = double.Parse(Console.ReadLine());

		bool result = CheckPoint(figureNumber, x, y);
		Console.WriteLine(result);
	}
	
	private static bool IsInCircle(double x, double y, double cx, double cy, double r)
	{
	    return Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2) <= r * r;
	}

	private static bool IsInRectangle(double x1, double y1, double x2, double y2, double px, double py)
	{
		double minX = Math.Min(x1, x2);
		double maxX = Math.Max(x1, x2);
		double minY = Math.Min(y1, y2);
		double maxY = Math.Max(y1, y2);

		return px >= minX && px <= maxX && py >= minY && py <= maxY;
	}

	public static void TaskFigures()
	{
	    Console.Write("Введите номер фигуры (1, 2, 3, 4, 5): ");
	    int figureNumber = int.Parse(Console.ReadLine());
	    Console.Write("Введите x: ");
	    double x = double.Parse(Console.ReadLine());
	    Console.Write("Введите y: ");
	    double y = double.Parse(Console.ReadLine());

	    bool result, a, b;

	    switch (figureNumber)
	    {
	        case 1:
	            a = IsInCircle(x, y, 0, 2, 2);
	            b = IsInCircle(x, y, 0, 1, 1);
	            result = a && !b;
	            break;

	        case 2:
	            a = IsInCircle(x, y, 0, 0, 2.5);
	            b = IsInCircle(x, y, 5, 5, 2.5);
	            result = a && b;
	            break;

	        case 3:
		        a = IsInCircle(x, y, 0, -2, 2);
		        b = IsInCircle(x, y, 0, -3, 3);
		        result = x >= 0 && !a && b;
	            break;

	        case 4:
	            a = IsInCircle(x, y, 0, 3, 3) && y >= 0 && x >= 0;
	            b = IsInCircle(x, y, 0, -2, 2) && y < 0 && x < 0;
	            result = a || b;
	            break;

	        case 5:
	            a = IsInCircle(x, y, 0, 3, 1.5);
	            b = IsInCircle(x, y, -3, 0, 1.5);
	            result = a && !b;
	            break;

	        default:
	            Console.WriteLine("Неверный номер фигуры. Допустимые: 1, 2, 3, 4, 5");
	            return;
	    }

	    Console.WriteLine(result);
	}

	private static void Task14()
	{
		Console.Write("Введите x1: ");
		double x1 = double.Parse(Console.ReadLine());
		Console.Write("Введите y1: ");
		double y1 = double.Parse(Console.ReadLine());
		Console.Write("Введите x2: ");
		double x2 = double.Parse(Console.ReadLine());
		Console.Write("Введите y2: ");
		double y2 = double.Parse(Console.ReadLine());
		
		Console.Write("Введите x: ");
		double px = double.Parse(Console.ReadLine());
		Console.Write("Введите y: ");
		double py = double.Parse(Console.ReadLine());

		Console.WriteLine(IsInRectangle(x1, y1, x2, y2, px, py));
	}
	
	private static bool IsPointOnSegment(double px, double py, double ax, double ay, double bx, double by)
	{
		const double eps = 1e-9;

		double cross = (bx - ax) * (py - ay) - (by - ay) * (px - ax);
		if (Math.Abs(cross) > eps)
			return false;

		double dot = (px - ax) * (px - bx) + (py - ay) * (py - by);
		if (dot > eps)
			return false;

		return true;
	}

	private static double DistanceFromOriginToSegment(double ax, double ay, double bx, double by)
	{
		double l2 = (bx - ax) * (bx - ax) + (by - ay) * (by - ay);
		if (l2 < 1e-12) // A == B
			return Math.Sqrt(ax * ax + ay * ay);

		double t = -(ax * (bx - ax) + ay * (by - ay)) / l2;
		t = Math.Max(0, Math.Min(1, t));

		double projX = ax + t * (bx - ax);
		double projY = ay + t * (by - ay);

		return Math.Sqrt(projX * projX + projY * projY);
	}

	private static void Task88()
	{
		Console.Write("Введите координаты вершин треугольника A(x1,y1), B(x2,y2), C(x3,y3):\n");
		double x1 = double.Parse(Console.ReadLine());
		double y1 = double.Parse(Console.ReadLine());
		double x2 = double.Parse(Console.ReadLine());
		double y2 = double.Parse(Console.ReadLine());
		double x3 = double.Parse(Console.ReadLine());
		double y3 = double.Parse(Console.ReadLine());

		Console.Write("Введите координаты точки P(x,y):\n");
		double px = double.Parse(Console.ReadLine());
		double py = double.Parse(Console.ReadLine());

		bool onAB = IsPointOnSegment(px, py, x1, y1, x2, y2);
		bool onBC = IsPointOnSegment(px, py, x2, y2, x3, y3);
		bool onCA = IsPointOnSegment(px, py, x3, y3, x1, y1);

		Console.WriteLine(onAB || onBC || onCA);
	}

	private static void Task89()
	{
		Console.Write("Введите координаты вершин треугольника A(x1,y1), B(x2,y2), C(x3,y3):\n");
		double x1 = double.Parse(Console.ReadLine());
		double y1 = double.Parse(Console.ReadLine());
		double x2 = double.Parse(Console.ReadLine());
		double y2 = double.Parse(Console.ReadLine());
		double x3 = double.Parse(Console.ReadLine());
		double y3 = double.Parse(Console.ReadLine());

		Console.Write("Введите радиус круга (центр в (0,0)): ");
		double r = double.Parse(Console.ReadLine());

		bool vertexInCircle = (x1 * x1 + y1 * y1 <= r * r) ||
		                      (x2 * x2 + y2 * y2 <= r * r) ||
		                      (x3 * x3 + y3 * y3 <= r * r);

		if (vertexInCircle)
		{
			Console.WriteLine(true);
			return;
		}

		double d1 = DistanceFromOriginToSegment(x1, y1, x2, y2);
		double d2 = DistanceFromOriginToSegment(x2, y2, x3, y3);
		double d3 = DistanceFromOriginToSegment(x3, y3, x1, y1);

		bool intersects = (d1 <= r) || (d2 <= r) || (d3 <= r);
		Console.WriteLine(intersects);
	}

	private static void TaskFigures2()
	{
		Console.Write("Введите x: ");
		double px = double.Parse(Console.ReadLine());
		Console.Write("Введите y: ");
		double py = double.Parse(Console.ReadLine());

		// Круг с квадратом
		const double r = 3.0f;
		bool result = IsInRectangle(-r, -r, r, r, px, py);

		if (result)
		{
			if (((px >= 0 && py >= 0) || (px < 0 && py < 0)) && IsInCircle(0, 0, px, py, r))
				result = true;
			if (((px >= 0 && py < 0) || (px < 0 && py >= 0)) && !IsInCircle(0, 0, px, py, r))
				result = true;
		}
		
		// Console.WriteLine(result);
		
		// Два элипса
		bool inEllipse1 = (px * px) / 25.0 + (py * py) / 9.0 <= 1.0;
		bool inEllipse2 = (px * px) / 9.0 + (py * py) / 25.0 <= 1.0;
		bool outsideStrip = (py > px + 3) || (py < px - 3);
		
		Console.WriteLine(inEllipse1 || inEllipse2 || outsideStrip);
	}

	private static void TaskExam()
	{
		while (true)
		{
			double x = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());
		
			Console.WriteLine(!(x > -2 && x < 0 && y < 2 && y > 0) && x > -3 && x < 0 && y < 3 && y > -3);
			Console.WriteLine(y <= 2 && !(x * x + y * y <= 9) && (x * x + y * y <= 25));
			Console.WriteLine((x * x + y * y <= 9) && !(x < 0 && Math.Abs(y) <= -x));
		}
	}
	
	private static void Task39()
	{
	    Console.WriteLine("Задача №39: Пересечение прямоугольников во втором квадранте");

	    Console.Write("Введите x1 (левый верхний угол первого прямоугольника): ");
	    double x1 = double.Parse(Console.ReadLine());
	    Console.Write("Введите y1 (левый верхний угол первого прямоугольника): ");
	    double y1 = double.Parse(Console.ReadLine());
	    Console.Write("Введите x2 (правый нижний угол первого прямоугольника): ");
	    double x2 = double.Parse(Console.ReadLine());

	    Console.Write("Введите x3 (левый верхний угол второго прямоугольника): ");
	    double x3 = double.Parse(Console.ReadLine());
	    Console.Write("Введите y3 (левый верхний угол второго прямоугольника): ");
	    double y3 = double.Parse(Console.ReadLine());
	    Console.Write("Введите x4 (правый нижний угол второго прямоугольника): ");
	    double x4 = double.Parse(Console.ReadLine());

	    double left = Math.Max(x1, x3);
	    double right = Math.Min(x2, x4);
	    double top = Math.Min(y1, y3);
	    double bottom = Math.Max(0, Math.Max(y1, y3));

	    bool intersects = left < right && top > bottom;

	    if (intersects)
	    {
	        double width = right - left;
	        double height = top - bottom;
	        double area = width * height;
	        Console.WriteLine($"Прямоугольники пересекаются. Площадь общей части: {area}");
	    }
	    else
	    {
	        Console.WriteLine("Прямоугольники не пересекаются.");
	    }
	}

	public static void Main()
	{
		// Task49();
		// Task50();
		// Task51();
		// Task52();
		// Task53();
		// Task55();
		// TaskFigures();
		// Task14();
		// Task88();
		// Task89();
		// TaskFigures2();
		// TaskExam();
		Task39();
	}
}
