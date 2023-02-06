// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введи число: ");
int N = int.Parse(Console.ReadLine());
var i = 1;
while ( i <= N)
{
    if (i % 2 == 0)
    {   
    System.Console.WriteLine(i + ", ");
    i++;
    }
    else
    {
        i++;
    }
}