// int [] array = new int [12];
// int size = array.Length;

// int positiveSum=0;
// int negativeSum=0;

// for(int i=0; i<size; i++)
// {
//     array[i]=new Random().Next(-9,10);

//     if(array[i]>0)
//     {
//         positiveSum+=array[i];
//     }
//     else
//     {
//         negativeSum+=array[i];
//     }

// }
// Console.WriteLine("Сумма положительных чисел ="+positiveSum + " | Сумма отрицательных чисел="+negativeSum);
// Console.WriteLine(String.Join(";",array));





int [] inputArray = {1,2,3,4,5};

int [] resultArray = new int[inputArray.Length/2 + inputArray.Length%2];

for(int i=0; i<resultArray.Length; i++)
{
    resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];

    if(i==(inputArray.Length-1-i)) 
    {
        resultArray[i]=inputArray[i];
    }
}

Console.WriteLine(String.Join(";",resultArray));







// Напишите программу замена элементов массива: положительные элементы замените на соответствующие
// отрицательные и наоборот.


// int [] Array = {-4, -8, 8, 2};

// for(int i=0; i<Array.Length; i++)
// {
//     Array[i]*=-1;    
    
// }

// Console.WriteLine("[{0}]", String.Join(";",Array));



//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; array [6, 7, 19, 345, 3] -> no
// -3; array [6,7, 19, 345, 3] -> yes

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array = {4, -8, 5, -2};
// string result = "No";

// for(int i = 0; i < array.Length; i++ )
// {
//     if(array[i]==num)
//     {
//         result = "Yes";
//     }
// }
// Console.WriteLine(result);