﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень числа: ");
// int y = int.Parse(Console.ReadLine()!);
// int n = 1;
// while(y > 1)
// {
//     n *= x;
//     y--;
// }
// Console.WriteLine(n);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// int sum = 0;
// while(x > 0)
// {
//     sum += x%10;
//     x /= 10;
// }
// Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Console.Clear();
// int[] array = new int[8];
// for(int i =0; i < 8; i++)
// {
//     Console.WriteLine("Введите число: ");
//     int x = int.Parse(Console.ReadLine()!);
//     array[i] = x;
// }
// Console.WriteLine($"Массив элементов: [{string.Join(", ",array)}]");

// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Console.Clear();
Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine()!);
int[] array = int new[x];
for(int i = 0; i < x; i++)
{
    ConsoleWriteLine("Введите элемент массива: ");
    int n = int.Parse(Console.ReadLine()!);
    array[i] = n;
}
Console.WriteLine("Введите число для сдвига: ");
int y = int.Parse(Console.ReadLine()!);
if(y > 0)
{
    for( int j = 0; j > y; j++)
    {
        array[j] = array[j+1];
    }
}
else
{
    for( int h = 0; h > Math.Abs(y); h++)
    {
        array[h] = array[x-h];
    }
}
Console.WriteLine(array);
