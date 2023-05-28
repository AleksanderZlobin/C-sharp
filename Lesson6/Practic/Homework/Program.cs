// Task # 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно
// палиндромом.

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int x = int.Parse(Console.ReadLine()!);
// while (x < 10000 || x > 99999)
// {
//     Console.WriteLine("Ошибка!\nВведите пятизначное число");
//     x = int.Parse(Console.ReadLine()!);
// }
// string str = x.ToString();
// char[] forReverse = str.ToCharArray();
// Array.Reverse(forReverse);
// string rStr = new string(forReverse);
// if (str == rStr)
//     Console.WriteLine("данное число является палиндромом");
// else
//     Console.WriteLine("данное число не является палиндромом");


// Task # 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// Console.WriteLine("Введите координату X первой точки: ");
// double x1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y первой точки: ");
// double y1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Z первой точки: ");
// double z1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату X второй точки: ");
// double x2 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Y второй точки: ");
// double y2 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координату Z второй точки: ");
// double z2 = double.Parse(Console.ReadLine()!);
// double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между точками равно {Math.Round(S, 3)}");


// Task # 23
// Напишите программу, которая принимает на вход число (N) и 
// выдает таблицу кубов чисел от 1 до N.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// double n = double.Parse(Console.ReadLine()!);
// n = Math.Abs(n);
// for (int i = 1; i <= n; i++)
//     Console.Write($"{i * i * i} ");


// Task # https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695
// В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, 
// причем кусты высажены только по окружности. Таким образом, у каждого куста есть ровно 
// два соседних. Всего на грядке растет N кустов.
// Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число 
// ягод – на i-ом кусте выросло ai ягод.
// В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит 
// из управляющего модуля и нескольких собирающих модулей. Собирающий модуль за один заход, находясь 
// непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.
// Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход 
// собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.

