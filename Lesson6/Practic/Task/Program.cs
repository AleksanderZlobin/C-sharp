// Task # 17
// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причем X!=0 и Y!=0 и выдает номер
// четверти плоскости, в которой находится эта точка.

// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y: ");
// double y = Double.Parse(Console.ReadLine()!);
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");

// Task # 18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой
// четверти (x и y).


// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int x = int.Parse(Console.ReadLine()!);
// while (x < 1 || x > 4)
// {
//     Console.WriteLine("Ошибка!\nВведите число от 1 до 4");
//     x = int.Parse(Console.ReadLine()!);
// }
// if (x == 1)
//     Console.WriteLine("x>0, y>0");
// else if (x == 2)
//     Console.WriteLine("x<0, y>0");
// else if (x == 3)
//     Console.WriteLine("x<0, y<0");
// else
//     Console.WriteLine("x>0, y<0");

// Task # 21
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

// Console.Clear();
// Console.WriteLine("Введите координату X(1): ");
// double x1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y(1): ");
// double y1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату X(2): ");
// double x2 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y(2): ");
// double y2 = double.Parse(Console.ReadLine()!);
// double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// // Math.Sqrt - вычисляет квадратный корень, Math.Pow возводит в степень (х)
// Console.WriteLine($"Расстояние между точками равно {Math.Round(S, 3)}");
// // Math.Round - округляет с точность до (х). 


// Task # 22
// Напишите программу, которая принимает на вход
// число (N) и выдает таблицу квадратов чисел
// от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
double n = double.Parse(Console.ReadLine()!);
n = Math.Abs(n); // Модуль числа (всегда положительное).
for (int i = 1; i <= n; i++)
    Console.Write($"{i * i} ");




