// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = num1;
// while (num2 > 1)
// {
//     num2 = num2 - 1;
//     num1 = num1 * num3;
// }

// Console.WriteLine("Результат:");    
// Console.WriteLine(num1);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число");
// int a = (Convert.ToInt32(Console.ReadLine()));
// int b = 0;
//     while (a > 0)
//     {
 
//         b = b + a % 10;
//         a = a /10 ;
 
//     }
// Console.WriteLine("Сумма цифр числа:");
// Console.WriteLine(b);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



// int[] array = new int [8];


// void FillArray(int[] collection) 
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(0,1000);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.Write(col[position] + ",");
//         position++;
//     }
// }

// FillArray(array);
// PrintArray(array);