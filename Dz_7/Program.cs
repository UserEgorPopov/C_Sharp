// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());
// double[,] matrix = new double [rows,columns];
// FillArrayRandomNumbers(matrix);
// PrintArray(matrix);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.Write("Введите номер строки:");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите номер столбца:");
// int columns = int.Parse(Console.ReadLine());

// int [,] matrix = new int [10,10];
// FillArrayRandomNumbers(matrix);

// if (rows > matrix.GetLength(0) || columns > matrix.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {matrix[rows-1,columns-1]}");
// }

// PrintArray(matrix);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-10, 11);
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// FillArrayRandomNumbers(matrix);


// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         avarage += matrix[i, j];
//     }
//     avarage /= rows;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// PrintArray(matrix);



// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }