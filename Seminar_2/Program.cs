// int num1 = 0;
// int num = 7;

// while(num1<=num)
// {
//     Console.WriteLine(num1);
//     num1+=2;
// }



//Задача №9.. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа


// int number = new Random().Next(10, 100);

// int number1 = number/10;
// int number2 = number%10;
// int max = number1;

// if(max<number2)
// {
//     max = number2;

// }

// Console.Clear();
// Console.WriteLine("Число:");
// Console.WriteLine(number);
// Console.WriteLine("Наибольшая цифра числа:");
// Console.WriteLine(max);



//Задание №10 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


// int number = new Random().Next(100, 1000);

// int num1 = number/100;
// int num3 = number%10;
// Console.WriteLine("Число:");
// Console.WriteLine(number);
// Console.WriteLine("Число после удаления второй цифры:");
// Console.Write(num1);
// Console.Write(num3);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// int number1 = new Random().Next(10, 101);
// int number2 = new Random().Next(1, 10);

// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());


// int exit = number1 % number2;

// Console.WriteLine("Первое число:");
// Console.WriteLine(Convert.ToInt32(number1));
// Console.WriteLine("Второе число:");
// Console.WriteLine(Convert.ToInt32(number2));

// if(number2 % number1 ==0 )
// {
//     Console.WriteLine("Первое число кратно второму");
// }
// else
// {
//     Console.WriteLine("Первое число не кратно второму, остаток:");
//     Console.WriteLine(Convert.ToInt32(exit));
// }






// Console.WriteLine("Введите число для проверки на кратность 7 и 23:");
// int number = Convert.ToInt32(Console.ReadLine());


// if(number % 7 ==0 && number % 23 ==0 )
// {
//     Console.WriteLine("Число кратно");
// }
// else
// {
//     Console.WriteLine("Число не кратно");
// }





// int number1 = new Random().Next(1, 101);
// int number2 = new Random().Next(1, 101);

// Console.WriteLine("Первое число:");
// Console.WriteLine(number1);
// Console.WriteLine("Второе число:");
// Console.WriteLine(number2);

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int exit = number1 / number2;


if(number1 == number2*number2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
if(number2 == number1*number1)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}
