// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.Clear();
// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());

// void Proizvedenie(int number)
// {
//     int pro = 1;

//     for (int i = 1; i <= number; i++)
//     {
//         // sum = sum * i;
//         pro *= i;
//     }

//     Console.WriteLine(pro);
// }

// Proizvedenie(num);


Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int res = 1;
int start = 1;

while (start <= num)
{
    checked
    {
        res *= start;
        start++;
    }
}

Console.WriteLine($"Произведение чисел от одного до {start - 1} равно {res}");