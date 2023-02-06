// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
var numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
var numberB  = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
var numberC = int.Parse(Console.ReadLine());
int max = numberA;
if(numberB > max ) max = numberB;
if(numberC > max ) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);