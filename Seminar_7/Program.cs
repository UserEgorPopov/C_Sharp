﻿// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1



// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows,columns];

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for(int j = 0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();




// }





// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows,columns];

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for(int j = 0; j<matrix.GetLength(1); j++)
//     {
//         Console.Write(i+j + "\t");
//     }
//     Console.WriteLine();




// }



// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.



// int rows = int.Parse(Console.ReadLine());
// int columns = int.Parse(Console.ReadLine());
// double [,] matrix = new double [rows,columns];

// for(int i = 0; i<rows; i++)
// {
    
//     for(int j=0 ;j<columns; j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         if(i%2 == 0 && j%2==0)
//         {
//             matrix[i,j] = Math.Pow(matrix[i,j], 2);
            
//         }
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }





// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.





// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());
// int [,] matrix = new int [rows,columns];
// int sum = 0;
// for(int i = 0; i<rows; i++)
// {
    
//     for(int j=0 ;j<columns; j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         if(i==j)
//         {
//             sum += matrix[i,j];
            
//         }
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Summa = {sum}");
