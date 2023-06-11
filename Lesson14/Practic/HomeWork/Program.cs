// Task # 47
// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.


// void InputMatrix(double[,] matrix)
// {
//     int end = 50, begin = 10;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
//     }
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// double[,] matrix = new double[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);


// Task # 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(10, 100);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// void MatrixSearchElement(int[,] matrix)
// {
//     Console.WriteLine("Введите номер строки: ");
//     int n = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите номер столбца: ");
//     int m = int.Parse(Console.ReadLine()!);
//     if (n <= matrix.GetLength(0) + 1 && m <= matrix.GetLength(1) + 1)
//     {
//         Console.WriteLine($"Искомый элемент: {matrix[n - 1, m - 1]}");
//     }
//     else Console.WriteLine("Такого элемента в массиве нет.");
// }


// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// MatrixSearchElement(matrix);


// Task # 52
// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 100);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// void MatrixRowAverage(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[j, i];

//         }
//         Console.WriteLine($"Среднее арифметическое элементов {i + 1} столбца равно: {Math.Round(sum / matrix.GetLength(1), 1)} ");
//     }
// }



// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// MatrixRowAverage(matrix);


// Task # Additional 1 Транспонирование.
// Задана целочисленная матрица, состоящая из N строк и M столбцов.
// Требуется транспонировать ее относительно горизонтали.


// Task # Additional 2 Миша и негатив.
// Миша уже научился хорошо фотографировать и недавно увлекся программированием. 
// Первая программа, которую он написал, позволяет формировать негатив бинарного
// черно-белого изображения.
// Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, 
// каждый из которых может быть либо черным, либо белым. Негатив такого изображения
// получается путем замены каждого черного пикселя на белый, а каждого белого пикселя – на черный.
// Миша, как начинающий программист, написал свою программу с ошибкой, поэтому в результате 
// ее исполнения мог получаться некорректный негатив. Для того чтобы оценить уровень несоответствия 
// получаемого негатива исходному изображению, Миша начал тестировать свою программу.
// В качестве входных данных он использовал исходные изображения. Сформированные программой 
// негативы он начал тщательно анализировать, каждый раз определяя число пикселей негатива,
// которые получены с ошибкой.
// Требуется написать программу, которая в качестве входных данных использует исходное бинарное
// черно-белое изображение и полученный Мишиной программой негатив, и на основе этого определяет 
// количество пикселей, в которых допущена ошибка.


// Task # Additional 3 Заполнение диагоналями.
// Даны числа m и n. Создайте массив A[m, n] и заполните его,
// как показано на примере.