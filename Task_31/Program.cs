// Задача 31: 
// 1) Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2) Найдите сумму
// отрицательных и положительных элементов массива.
// Вывод результата
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] CreateArrayRndInt(int size, int min, int max) // метод для создания массива
{
    int[] arr = new int[size]; //создание массива
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);      //заполнение массива случайными числами
    }
    return arr;
}

int[] GetSumPosNegElem(int[] arr)         //метод для нахождения отрицательных и положительных элементов массива
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumNeg = sumNeg + arr[i];
            //sumNeg +=arr[i];
        }
        else
        {
            sumPos += arr[i];
        }
    }
    return new int[] { sumPos, sumNeg };
}

void PrintArray(int[] arr)                          //метод для печати 
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");                       // если i равно первому элементу массива
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");  // если i меньше последнего элемента массива
        else Console.Write(arr[i] +"]");                      
    }
}

void PrintSumPosNegElem(int[] sum)                     //метод для печати сум отрицательных и полож. чисел
{
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных чисел в массиве = {sum[0]}");
    Console.WriteLine($"Сумма отрицательных чисел в массиве = {sum[1]}");
}

            //вызов методов

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int[] sumPosNegElem = GetSumPosNegElem(array);
PrintSumPosNegElem(sumPosNegElem);
