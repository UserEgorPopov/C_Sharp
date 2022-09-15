// string str = Console.ReadLine();


// if(str.Length<=2)
// {
//     Console.WriteLine("Данное число не имеет третьей цифры");
//     return;
// }

// Console.WriteLine(str[2]);


// int testNumber = 4356;

// Console.WriteLine(testNumber==1);


// Console.WriteLine("Введите координату: x");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату: y");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// if(x>0&&y>0)
// {
//     Console.WriteLine("1");
// }

// if(x<0&&y>0)
// {
//     Console.WriteLine("2");
// }

// if(x<0&&y<0)
// {
//     Console.WriteLine("3");
// }

// if(x>0&&y<0)
// {
//     Console.WriteLine("4");
// }

// if(x==0||y==0)
// {
//     Console.WriteLine("Определить нельзя");
// }

// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Введите номер четверти:");

// int number = Convert.ToInt32(Console.ReadLine());

// if(number == 1)
// {
//     Console.WriteLine("Значение х: от 0 до +бесконечности; Значение у: от 0 до +бесконечности");
// }
// if(number == 2)
// {
//     Console.WriteLine("Значение х: от 0 до -бесконечности; Значение у: от 0 до +бесконечности");
// }
// if(number == 3)
// {
//     Console.WriteLine("Значение х: от 0 до -бесконечности; Значение у: от 0 до -бесконечности");
// }
// if(number == 4)
// {
//     Console.WriteLine("Значение х: от 0 до +бесконечности; Значение у: от 0 до -бесконечности");
// }
// else
// {
//     Console.WriteLine("Error");
// }



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21



// Console.WriteLine("Введите Х1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Х2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y2:");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));

// // int x = x1*x1;
// int x = Math.Pow = (x1, 2);

// double x = 51/7;
// double y = Math.Sqrt(49);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while(count <= num)
// {
//     Console.WriteLine(Math.Pow(count,3));
//     count++;
// }










