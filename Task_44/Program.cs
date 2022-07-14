﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Fibonacci(int in_num)
// {
//     int f1 = 0;
//     int f2 = 1;
//     int sum = 0;
//     Console.Write($"{f1} {f2}");
//     for (int i = 1; i <= in_num; i++)
//     {
//         sum = f1 + f2;
//         f1 = f2;
//         f2 = sum;
//         Console.WriteLine($"F({i}) = {sum}");
//     }
// }
// Fibonacci(n);


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] Feb(int size)
{

    int[] arr = new int[size];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < size; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}
int[] Array = Feb(num);
PrintArray(Array);