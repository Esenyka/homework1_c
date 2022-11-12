Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Максимальео число {numberA}");
}
else if (numberB > numberA)
{
    Console.WriteLine($"Максимальео число {numberB}");
}