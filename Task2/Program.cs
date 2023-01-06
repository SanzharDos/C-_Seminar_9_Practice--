// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int N = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;
if (M > N)
{
    max = M;
    min = N;
}
else
{
    max = N;
    min = M;
}
Console.WriteLine($"Сумма чисел в промежутке от {min} до {max} равна = {Sum(min, max)}");

int Sum(int min, int max)
{
    if (max < min) return 0;
    return max + Sum(min, max - 1);
}