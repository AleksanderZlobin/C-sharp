// Task # 53
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 31);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// void ReverseFirstAndLustLine(int[,] matrix)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReverseFirstAndLustLine(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

// Task # 55
// Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбы. В случае, если это невозможно, программа
// должна вывести сообщение для пользователя. 


// void InputMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 31);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// void ReverseMatrix(int[,] matrix)
// {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for(int j = i + 1; j < matrix.GetLength(1); j++) // i + 1 исключает главную диагональ
//             { 
//                 (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
//                 // int temp = matrix[i, j];
//                 // matrix[i, j] = matrix[j, i];
//                 // matrix[j, i] = temp;
//             }
//         } 
// }

// Console.Clear();
// Console.Write("Введите размеры массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// while (size[0 != size[1]])
// {
//     Console.Write("Вы ошиблись!\nВведите размер массива: ");
//     size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray;
// }
// int[,] matrix = new int[size[0], size[0]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReverseMatrix(matrix);
// PrintMatrix(matrix);

// Task # 57
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных.


// bool CheckValue(int[] array, int number)
// {
//     foreach (int element in array)
//     {
//         if(element == number)
//             return false;
//     }
//     return true;
// }


// int InputMatrix(int[,] matrix, int[] array)
// {
//     int countNumbers = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1; 10]
//             if (CheckValue(array, matrix[i, j]))
//             {
//                 array[countNumbers] = matrix[i, j];
//                 countNumbers++;
//             }
//         }
//     }
//     return countNumbers;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void ReverseMatrix(int[,] matrix, int[] array, int countNumbers)
// {
//     for(int k = 0; k < countNumbers; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (matrix[i, j] == array[k])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Число {array[k]} встретилось ровно {count} раз");
//     }
// }

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int[] helpArray = new int[size[0] * size[1]];
// int countValues = InputMatrix(matrix, helpArray);
// PrintMatrix(matrix);
// Console.WriteLine("\n\n\n");
// ReverseMatrix(matrix, helpArray, countValues);
// PrintMatrix(matrix);


// Task # 59
// Задайте двумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1; 10]
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void ReverseMatrix(int[,] matrix)
// {
//     int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (minValue > matrix[i, j])
//             {
//                 minValue = matrix[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }
//     Console.WriteLine($"Минимум найден {minValue}({minRow + 1}, {minColumn + 1})");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i != minRow)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j != minColumn)
//                     Console.Write($"{matrix[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("\n\n\n");
// ReverseMatrix(matrix);




