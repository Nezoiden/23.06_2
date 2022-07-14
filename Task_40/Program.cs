// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число");
int numC = Convert.ToInt32(Console.ReadLine());

void Suma(int a, int b, int c)
{
	if (a < b + c && b<a+c && c < a+b) Console.WriteLine("треугольник существует");
	else Console.WriteLine("треугольник не существует");
}
Suma( numA, numB, numC);
