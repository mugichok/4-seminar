// Console.Clear();
// Console.WriteLine("Введите размер массива: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = new int[x]; // создаёт массив размером x, который по умолчанию заполняется нулями
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,11); 
// }
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");

// задача 1. НА вход принимается число А, программа выдаёт сумму чисел от 1 до А
// сумма элементов арифмитической прогрессии s = (a1 + an)/2 * n
// Console.Clear();
// Console.WriteLine("Введите число: ");
// double x = double.Parse(Console.ReadLine()!);
// Console.WriteLine((1+x)*x/2);

// задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// int i = 0;
// while(x > 0)
// {
//     x /= 10;
//     i++;
// }
// Console.WriteLine($"Количество цифр в числе {i}");

// задача 3. Найите факториал введённого числа
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// int fact = 1;
// for(int i = 1; i <= x; i++)
// {
//     fact *= i;
// }
// Console.WriteLine(fact);

// задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// Console.Clear();
// int[] array = new int[8];
// for(int i =0; i <8; i++)
//     array[i] = new Random().Next(0,2);
// Console.WriteLine($"Массив элементов: {string.Join(", ", array)}");
