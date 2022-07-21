// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();




int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

int[,] ExchangeMatrix(int[,] array)
{
    int[,] arr = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[j, i] = array[i, j];
        }
    }
    return arr;
}
// void ExchangeMatrix(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1))
//     {
//         Console.WriteLine("Matrix is not square");
//     }
//     else
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = i; j < matrix.GetLength(1); j++)
//             {
//                 int temp = matrix[i, j];
//                 matrix[i, j] = matrix[j, i];
//                 matrix[j, i] = temp;
//             }
//         }
//     }
// }

void PrintMatrix(int[,] arr)                          
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");                       
        if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} | ");  
        else Console.Write($"{arr[i, j], 3} | ");         
        }
            Console.WriteLine();         
    }
}

int[,] arrayResult = CreateMatrixRndInt(4, 4, 1, 20);
PrintMatrix(arrayResult);
Console.WriteLine();
int[,] exchange = ExchangeMatrix(arrayResult);
PrintMatrix(exchange);