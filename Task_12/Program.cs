﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

void Kratno(int in_a, int in_b)
{
    int ostatok = in_a % in_b;
    //Console.Write($"Остаток равен {ostatok} ");
    if (ostatok == 0)
        Console.Write($"кратно");
    else
        Console.Write($"не кратно, остаток {ostatok}");
}

Kratno(a, b);
