// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
var numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
var numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine("Число {numberA} большее, число {numberB} меньшее");
}
else
{
    Console.WriteLine("Число {numberB} большее, число {numberA} меньшее");
}
