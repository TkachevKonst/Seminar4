Console.Clear();
Console.Write("Введите любое число :");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите степень в которую будет возводится число :");
int numB = int.Parse(Console.ReadLine());
int pow = Power(numA, numB);
Console.WriteLine($" {numA} в степени {numB} = {pow}");

int Power(int numberA, int numberB)
{
    int pow1 = 1;
    for (int i = 1; i <= numberB; i++)
    {
        pow1 = pow1 * numberA;
    }
    return pow1;
    ;
}
