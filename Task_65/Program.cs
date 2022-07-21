// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Clear();
Console.WriteLine("Задайте первое число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число:");
int num1 = Convert.ToInt32(Console.ReadLine());

NaturalNumber(num, num1);

void NaturalNumber(int number, int number1)
{
	
	if (number < number1)
	{
		Console.Write($"{number} ");
		NaturalNumber(number + 1, number1);
		
	}
	
	if (number > number1)
	{
		Console.Write($"{number} ");
		NaturalNumber(number - 1, number1);
		
	}
	if(number==number1)
	Console.Write($"{number1}");
	

}

// void NumbersMN(int m, int n)
// {
//     if (m <= n)
//     {
//         Console.Write($"{m} ");
//         if (m == n) return;
//         NumbersMN(m + 1, n);
//     }
//     else if (m > n)
//     {
//         Console.Write($"{m} ");
//         if (m == n) return;
//         NumbersMN(m - 1, n);
//     }
// }

