/* // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите a: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine("a больше b");
}
else
{
    if (number1 < number2)
    {
        Console.WriteLine("b больше a"); 
    }
    else
    {
        Console.WriteLine("a равно b");
    }
} */


/* // Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (max < number1)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Максимальное число = {max}"); */


/* // Напишите программу, которая на ввод принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(number%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
} */


/* // Напишите программу, которая на ввод принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
} */
