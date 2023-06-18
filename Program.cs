// Задача 19
// Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.

// int InputNum(string message) // Ввод числа
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int DigitsCount(int num) // Подсчет числа разрядов
// {
//     int temp = num;

//     int count = 0;
//     while (temp != 0)
//     {
//         temp = temp / 10; // num /= 10;
//         count++;
//     }
//     return count;
// }

// int[] FillArray(int num, int digits) // Заполнение массива
// {
//     int[] array = new int[digits];

//     for (int i = array.Length - 1; i >= 0; i--)
//     {
//         array[i] = num % 10;
//         num /= 10;
//     }
//     return array;
// }

// string Polyandrome(int[] array) // Проверка массива на симметрию -> число полиандром.
// {
//     int start = 0;
//     int finish = array.Length - 1;
//     while (start < finish)
//     {
//         if (array[start] != array[finish])
//             return "is not polyandrome.";
//         else
//         {
//             start++;
//             finish--;
//         }

//     }
//     return "is a polyandrome.";
// }


// int num = InputNum("Please input number: ");

// int digits = DigitsCount(num);

// int[] array = FillArray(num, digits);

// Console.WriteLine($"The number you've enterd {Polyandrome(array)}");

// *********************************************
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int InputNum(string message)
// {
// Console.Write(message);
// int num = int.Parse(Console.ReadLine()!);
// return num;
// }


// double Root(int xA, int yA, int xB, int yB, int zA, int zB)
// {
// double res1 = Math.Pow(xB - xA, 2);
// double res2 = Math.Pow(yB - yA, 2);
// double res3 = Math.Pow(zB - zA, 2);
// double res = Math.Sqrt(res1 + res2 + res3);
// return res;
// }

// int xA = InputNum("enter x point A: ");
// int yA = InputNum("enter y point A: ");
// int zA = InputNum("enter z point A: ");
// int xB = InputNum("enter x point B: ");
// int yB = InputNum("enter y point B: ");
// int zB = InputNum("enter z point B: ");

// double distance = Root(xA, yA, xB, yB, zA, zB);
// Console.WriteLine(Math.Round(distance, 2));

// *******************************************************
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Первый вариант с массивом ответов.

// int InputNum(string message)
// {
// Console.Write(message);
// int num = int.Parse(Console.ReadLine()!);
// return num;
// }

// int[] FillArrayCubes(int num) // Заполнение массива кубами чисел
// {
//     int[] array = new int[num];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Math.Pow((i + 1), 3));
//     }
//     return array;
// }

// void PrintArray(int[] array) // Печать массива
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]);
// if (i < array.Length - 1)
// Console.Write(", ");
// else
// Console.Write(".");
// }
// }
// int num = InputNum("Enter number please: ");
// PrintArray(FillArrayCubes(num));

// ************************************
// Второй вариант, как на семинаре.

int InputNum(string message)
{
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

void PrintCubes(int num)
{
for (int i = 1; i <= num; i++)
{
Console.Write(i * i * i);
if (i < num)
Console.Write(", ");
else
Console.Write(".");
}
}
PrintCubes (InputNum("Enter number please: "));
