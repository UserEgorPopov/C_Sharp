﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

 
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int num = new Random().Next(10000, 100000);
// Console.WriteLine(num);

// int a = num;
// int b = 0;
// while(num > 0)
// {
//     int c = num % 10;
//     b = b * 10 + c;
//     num = num / 10;
// }
// if(a == b)
// {
//     Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом");
// }



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите Х1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z1:");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Х2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y2:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z2:");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

// Console.WriteLine($"Расстояние между точками:{d}");




//Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while(count <= num)
// {
//     Console.WriteLine(Math.Pow(count,3));
//     count++;
// }

