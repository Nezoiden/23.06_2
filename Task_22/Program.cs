﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Clear();
// Console.WriteLine("Введите  число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= num)
// {
//     Console.WriteLine($"{i}\t|    {i * i}");
//     i++;
// }

Console.Clear();
Console.WriteLine("Введите  число: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) 
{
    Console.WriteLine($"Квадрат числа {i} = {i*i,4}");
}