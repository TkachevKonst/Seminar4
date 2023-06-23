Console.Clear();
Console.Write("Введите любое число :");
int numA = int.Parse(Console.ReadLine());
int sum = SumNum(numA);
Console.WriteLine($"Сумма чисел в числе {numA} равна {sum}");
int SumNum(int number)
{
    if (number < 0)
    {
        number = number * -1;
    }
    int sum = 0;
    while (number != 0)
    {
        int outside = number % 10;
        sum = sum + outside;
        number /= 10;
    }
    return sum;
}
