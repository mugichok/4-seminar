// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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
// Console.Clear();
// Console.WriteLine("Введите размер массива: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = new int[x];
// for(int i = 0; i < x; i++)
// {
//     Console.WriteLine("Введите элемент массива: ");
//     int n = int.Parse(Console.ReadLine()!);
//     array[i] = n;
// }
// Console.WriteLine($"Изначальный массив элементов: [{string.Join(", ",array)}]");
// Console.WriteLine("Введите число для сдвига: ");
// int y = int.Parse(Console.ReadLine()!);
// if(y > 0)
// {
//     for( int i = 0; i <= y; i++)
//     {
//         array[i + 1] = array[i];
//     }
    
// }
// else
// {
//     for( int i = 0; i <= Math.Abs(y); i++)
//     {
//         array[x - i] = array[x-i -1];
//         array[x] = array[0];
//     }
// }
// Console.WriteLine($"Сдвинутый массив элементов: [{string.Join(", ",array)}]");

// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько. Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах. Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа. Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// while(x < 2 || x%2 != 0)
// {
//     Console.WriteLine("число меньше двух или нечётное!/nВведите другое число: ");
//     x = int.Parse(Console.ReadLine()!);
// }
// x = x1+x2;
// for(int i=2; i < x-1; i++)
// {

// }