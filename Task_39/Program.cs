// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

void PrintArray(int[] arr)                          //метод для печати 
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");                       // если i равно первому элементу массива
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");  // если i меньше последнего элемента массива
        else Console.Write(arr[i] +"]");                      
    }
}

void Reverse (int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size -1;
    while (index1 < index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
        index1++;
        index2--;
    }
}

int[] array = CreateArrayRndInt(5,1,9);
PrintArray(array);
Reverse(array);
Console.WriteLine();
PrintArray(array);
