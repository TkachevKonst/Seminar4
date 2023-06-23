Console.Clear();
Console.Write("Введите размер массива :");
int length = int.Parse(Console.ReadLine());
if (length < 0)
{
    length = length * -1;
}
int[] arr = new int[length];
FullArr(arr);
PrintArr(arr);
void FullArr(int[] arroy)
{
    for (int i = 0; i < arroy.Length; i++)
    {
        arroy[i] = new Random().Next(100);
    }
}
void PrintArr(int[] arroy)
{
    for (int i = 0; i < arroy.Length; i++)
        Console.Write(arroy[i] + " ");
}

