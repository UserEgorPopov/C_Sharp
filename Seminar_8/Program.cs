// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// Console.Write("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = new int [rows,columns];

// for(int i = 0; i<array.GetLength(0); i++)
// {
//     for(int j = 0; j<array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,11);
//         Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// int [] temp = new int [array.GetLength(1)];

// for(int k = 0; k<array.GetLength(1); k++)
// {
//     temp[k]=array[0, k];
//     array[0, k] = array[array.GetLength(0)-1,k];
//     array[array.GetLength(0)-1, k] = temp[k];
// }


// Console.WriteLine("New array:");


// for(int i = 0; i<array.GetLength(0); i++)
// {
//     for(int j = 0; j<array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j] + "\t");
//     }
//     Console.WriteLine();
// }


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// Console.WriteLine("Введите кол-во строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов:");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = new int [rows,columns];

// Console.WriteLine("Начальный массив:");
// for(int i = 0; i<array.GetLength(0); i++)
// {
//     for(int j = 0; j<array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,11);    
//         Console.Write(array[i,j]+ "\t");
    
//     }
//     Console.WriteLine();
// }

// if(rows==columns)
// {
//     Console.WriteLine("Новый массив:");
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[j,i] + "\t");

//         }
//         Console.WriteLine();
//     }
    
// }
// else
// Console.WriteLine("Ошибка.");
// Console.WriteLine("Кол-во строк не равно кол-ву столбцов.");



// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7



// Console.WriteLine("Введите кол-во строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов:");
// int columns = int.Parse(Console.ReadLine());

// int [,] array = new int [rows, columns];

// int minValue = int.MaxValue;
// int minIndexRows = 0;
// int minIndexColumns = 0;

// for(int i = 0; i<array.GetLength(0); i++)
// {
//     for(int j = 0; j<array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j] + "\t");
//         if(minValue > array[i,j])
//         {
//             minValue = array[i,j];
//             minIndexRows = i;
//             minIndexColumns = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Минимальное значение:" + minValue);
// System.Console.WriteLine("Результат:");
// for (int i = 0; i<rows; i++)
// {
//     if(i !=minIndexRows)
//     {

//         for(int j = 0; j<columns; j++)
//         {
//             if(j !=minIndexColumns)
//             {
//                 Console.Write(array[i,j] + "\t");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }



