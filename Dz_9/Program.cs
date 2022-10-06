// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// Console.Write("Введите N: ");
// int N = Convert.ToInt16(Console.ReadLine());

// Console.Write("Введите M: ");
// int M = Convert.ToInt16(Console.ReadLine());


// Console.WriteLine($"N={N}, M={M}");
// if (M>N)
// for (int i = N; i <= M; i++)
//     Console.Write($" {i}");
// else
//     for (int i = M; i <= N; i++)
//         Console.Write($" {i}");



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Summ(m, n);


// void Summ(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }


// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int m = InputInt("Введите M: ");
// int n = InputInt("Введите N: ");
// Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }


Большое спасибо за семинары и ваше потраченное время, всего хорошего.

























