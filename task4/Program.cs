Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (count != number)
{
    if (count % 2 == 0 && count != 0)
    {
        Console.WriteLine(count);
        count++;
    }
    else
        count++;
}